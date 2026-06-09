using IlkaPoint.Clases;
using IlkaPoint.Data.Modelos;
using IlkaPoint.FormsPrueba;
using IlkaPoint.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IlkaPoint.Forms_Oficiales
{
    public partial class AgregarVenta : UserControl
    {

        // Pon esto arriba, junto a las otras variables globales de tu Form
        private ToolStripDropDown menuBusqueda = new ToolStripDropDown();
        // Estructura temporal para simular los productos de la BD
        private class ProductoSimulado
        {
            public int Id { get; set; }
            public string Nombre { get; set; }
            public decimal Precio { get; set; }
            public Image Foto { get; set; }
        }

        public AgregarVenta()
        {
            InitializeComponent();

            // Colores de fondo de tu interfaz
            this.BackColor = ColorTranslator.FromHtml("#1A3560");
            panelCompra.BackColor = ColorTranslator.FromHtml("#08243B");

            panelArriba.BackColor = Color.Transparent;

            // Configuración de la lista gris de productos
            flpListaProductos.BackColor = Color.Transparent;
            flpListaProductos.FlowDirection = FlowDirection.TopDown;
            flpListaProductos.WrapContents = false;
            flpListaProductos.AutoScroll = true;

            // Orden de capas
            panelArriba.SendToBack();
            flpListaProductos.BringToFront();
            panelCompra.BringToFront();

            if (cmbMetodoPago != null)
            {
                cmbMetodoPago.Items.Clear();
                cmbMetodoPago.Items.Add("Efectivo");
                cmbMetodoPago.Items.Add("Yappy");
                cmbMetodoPago.Items.Add("Tarjeta");
                cmbMetodoPago.SelectedIndex = 0; // Efectivo por defecto
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            // 1. Verificamos si se presionó Enter y si el cursor está en la caja de búsqueda
            if (keyData == Keys.Enter && txtBuscarProducto.Focused)
            {
                string criterio = txtBuscarProducto.Text.Trim();

                if (!string.IsNullOrEmpty(criterio))
                {
                    ServicioInventario servicio = new ServicioInventario();

                    // 2. Buscamos directamente en el Stock en lugar de Producto
                    List<Stock> coincidencias = servicio.BuscarStockPorNombre(criterio);

                    if (coincidencias.Count == 1)
                    {
                        // Coincidencia única exacta: pasamos el objeto Stock directo
                        AgregarTarjetaALista(coincidencias[0]);
                        txtBuscarProducto.Clear();
                    }
                    else if (coincidencias.Count > 1)
                    {
                        // Menú flotante para seleccionar entre las coincidencias encontradas
                        ContextMenuStrip menuSeleccion = new ContextMenuStrip();

                        foreach (Stock stockItem in coincidencias)
                        {
                            // Mostramos el nombre del producto y la cantidad disponible en el menú
                            ToolStripMenuItem item = new ToolStripMenuItem($"{stockItem.productoNombre} - (Disponibles: {stockItem.Cantidad})");

                            // Guardamos el objeto Stock dentro del tag
                            item.Tag = stockItem;

                            // Evento al hacer clic
                            item.Click += (s, ev) => {
                                ToolStripMenuItem itemClickeado = (ToolStripMenuItem)s;
                                Stock stockSeleccionado = (Stock)itemClickeado.Tag;

                                // Pasamos el Stock seleccionado a tu función visual
                                AgregarTarjetaALista(stockSeleccionado);
                                txtBuscarProducto.Clear(); // Limpiamos la búsqueda
                            };

                            menuSeleccion.Items.Add(item);
                        }

                        // Refleja el menú flotante justo debajo del textbox de búsqueda
                        menuSeleccion.Show(txtBuscarProducto, new Point(0, txtBuscarProducto.Height));
                    }
                    else
                    {
                        MessageBox.Show("No se encontró stock que coincida con la búsqueda.", "Ilka Point", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtBuscarProducto.Clear();
                        txtBuscarProducto.Focus();
                    }
                }

                // Retornamos true para indicar que ya procesamos la tecla Enter
                return true;
            }

            // Comportamiento por defecto para otras teclas
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void AgregarTarjetaALista(Stock prod)
        {
            InfoProducto nuevaFila = new InfoProducto();

            nuevaFila.AutoSize = false;

            // Ancho FIJO
            int anchoFijoTarjeta = 360;

            // Tamaños exactos - NO TOCAR
            nuevaFila.Size = new Size(anchoFijoTarjeta, 90);
            nuevaFila.MinimumSize = new Size(anchoFijoTarjeta, 90);
            nuevaFila.MaximumSize = new Size(anchoFijoTarjeta, 90);

            nuevaFila.Margin = new Padding(9, 0, 0, 8);

            // Cargar los textos e imágenes
            ServicioInventario inventario = new ServicioInventario();
            Producto producto = inventario.BuscarProductoPorId(prod.Id);
            Image imagenProducto = ConvertirBytesAImagen(producto.rutaImagenPng);

            nuevaFila.CargarDatos(prod.Id, prod.productoNombre, producto.precio, imagenProducto);

            nuevaFila.txtCantidad.TextChanged += (s, e) => {
                ActualizarTotales();
            };

            flpListaProductos.Controls.Add(nuevaFila);

            ActualizarTotales();

            nuevaFila.BringToFront();
            flpListaProductos.Update();
            flpListaProductos.ResumeLayout(true);
            flpListaProductos.PerformLayout();

            txtBuscarProducto.Clear();
            txtBuscarProducto.Focus();

            //ActualizarTotales();
        }

        public Image ConvertirBytesAImagen(byte[] imagenBytes)
        {
            // Validación por si el producto no tiene imagen guardada en la base de datos
            if (imagenBytes == null || imagenBytes.Length == 0)
            {
                return null; // Opcional: Aquí podrías retornar un 'Properties.Resources.ImagenPorDefecto'
            }

            // Usamos MemoryStream para leer los bytes y transformarlos en un objeto Image
            using (MemoryStream ms = new MemoryStream(imagenBytes))
            {
                return Image.FromStream(ms);
            }
        }

        private void ActualizarTotales()
        {
            int totalArticulos = 0;
            decimal granTotal = 0;

            // Recorremos las tarjetas que están dentro del panel
            foreach (Control control in flpListaProductos.Controls)
            {
                if (control is InfoProducto item)
                {
                    // Para sumar cada cantidad y evitar errores de suma
                    if (int.TryParse(item.txtCantidad.Text, out int cant))
                    {
                        totalArticulos += cant;
                        granTotal += (item.PrecioUnitario * cant);
                    }
                }
            }

            // Se le asignan los totales a los labels correspondientes
            lblTotalProductos.Text = totalArticulos.ToString();
            lblTotalPrecio.Text = $"${granTotal:F2}";
        }

        // Datos Prueba - Cambiar por base de datos
        private List<Stock> BuscarCoincidenciasEnBD(string criterio)
        {
            string termino = criterio.ToLower().Trim();
            List<Stock> resultado = new List<Stock>();

            // Foto por default en caso tal el producto no tenga una imagen asignada en la base de datos
            Image fotoDefecto = Properties.Resources.xredmarkimg;

            /*
            List<ProductoSimulado> inventarioBD = new List<ProductoSimulado>()
            {
                new ProductoSimulado { Id = 101, Nombre = "Coca Cola 2 ltrs", Precio = 2.10m, Foto = fotoDefecto },
                new ProductoSimulado { Id = 102, Nombre = "Jabon Corporal Palmolive", Precio = 1.00m, Foto = fotoDefecto },
                new ProductoSimulado { Id = 103, Nombre = "Lay's Sour Cream & Oni", Precio = 0.65m, Foto = fotoDefecto },
                new ProductoSimulado { Id = 104, Nombre = "Lay's Classic", Precio = 0.65m, Foto = fotoDefecto },
                new ProductoSimulado { Id = 105, Nombre = "Lentejas Don Henry - 4lb", Precio = 1.00m, Foto = fotoDefecto },
                new ProductoSimulado { Id = 502, Nombre = "Arroz La Morenita 5 lb", Precio = 3.25m, Foto = fotoDefecto },
                new ProductoSimulado { Id = 503, Nombre = "Leche Evaporada Clavel", Precio = 0.85m, Foto = fotoDefecto }
            };
            */

            ServicioInventario inventario = new ServicioInventario();
            List<Stock> inventarioDB = inventario.BuscarStockPorNombre(termino);

            foreach (var prod in inventarioDB)
            {
                if (prod.productoNombre.ToLower().Contains(termino) || prod.Id.ToString() == termino)
                {
                    resultado.Add(prod);
                }
            }
            return resultado;
        }

        private void cmbMetodoPago_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panelArriba_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRegistrarVenta1_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Validación de existencia de controles (productos) en la UI
                if (flpListaProductos.Controls.Count == 0)
                {
                    MessageBox.Show("Debe agregar al menos un producto a la venta.", "Ilka Point", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 2. Validación del método de pago
                string metodoPagoSeleccionado = (cmbMetodoPago != null && cmbMetodoPago.SelectedItem != null)
                                                ? cmbMetodoPago.SelectedItem.ToString()
                                                : null;

                if (string.IsNullOrEmpty(metodoPagoSeleccionado))
                {
                    MessageBox.Show("Seleccione un método de pago.", "Ilka Point", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 3. Inicializar la Transacción
                // Asumo que tienes un constructor vacío o pasas un booleano según tu prueba anterior.
                Transaccion nuevaTransaccion = new Transaccion(false);

                // Inicializamos la lista si tu modelo no lo hace automáticamente en el constructor
                if (nuevaTransaccion.Detalles == null)
                {
                    nuevaTransaccion.Detalles = new List<DetallesTransaccion>();
                }

                nuevaTransaccion.MetodoPago = metodoPagoSeleccionado;
                // nuevaTransaccion.Fecha = DateTime.Now; // Descomenta si tu modelo requiere setear la fecha manualmente

                TransaccionService service = new TransaccionService();

                // 4. Extracción de productos desde la tarjeta UI
                foreach (Control control in flpListaProductos.Controls)
                {
                    if (control is InfoProducto item)
                    {
                        if (int.TryParse(item.txtCantidad.Text, out int cant) && cant > 0)
                        {
                            // Asumimos que tu UserControl 'InfoProducto' tiene una propiedad pública ProductoId
                            int productoId = item.IdProducto;

                            // El servicio busca el producto real en la DB y crea el detalle
                            DetallesTransaccion detalle = service.CrearDetalle(productoId, cant);
                            nuevaTransaccion.Detalles.Add(detalle);
                        }
                    }
                }

                // Validación extra por si había controles pero con cantidades en 0 o inválidas
                if (nuevaTransaccion.Detalles.Count == 0)
                {
                    MessageBox.Show("Las cantidades de los productos no son válidas.", "Ilka Point", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 5. Registrar la transacción en la Base de Datos (calcula totales y descuenta stock)
                service.RegistrarTransaccion(nuevaTransaccion);

                // 6. Mostrar la Factura / Comprobante
                Form host = new Form
                {
                    StartPosition = FormStartPosition.CenterParent,
                    Width = 800,
                    Height = 600,
                    Text = "Factura de Venta"
                };

                //var muestroDeFactura = new UserControlPrueba(nuevaTransaccion) { Dock = DockStyle.Fill };
                //host.Controls.Add(muestroDeFactura);
                //host.ShowDialog(this); // Mejor usar ShowDialog para bloquear la ventana principal hasta cerrar la factura

                // 7. Limpiar la interfaz para una Nueva Venta
                flpListaProductos.Controls.Clear();
                ActualizarTotales(); // Llama a tu método para resetear los labels visuales a $0.00

                // (Opcional) Si tienes un grid de inventario en esta pantalla, actualízalo aquí:
                // ServicioInventario inventario = new ServicioInventario();
                // dataGridView1.DataSource = inventario.ObtenerElStockActual();
            }
            catch (Exception ex)
            {
                // 8. Manejo de Errores (Atrapa las excepciones de Stock o Producto no encontrado que lanzaste en el Service)
                MessageBox.Show($"Ocurrió un error al registrar la venta:\n\n{ex.Message}", "Error de Venta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // Cerrar formulario
            this.FindForm()?.Close();
        }

        private void lblNumVenta_Click(object sender, EventArgs e)
        {

        }


        private void flpListaProductos_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AgregarVenta_Load(object sender, EventArgs e)
        {
        }

        private void btnCerrarPanel_Click(object sender, EventArgs e)
        {
            this.FindForm()?.Close();
        }

        private void lblTotal_Click(object sender, EventArgs e)
        {
        }

        private void txtBuscarProducto_TextChanged(object sender, EventArgs e)
        {
            string criterio = txtBuscarProducto.Text.Trim();

            if (string.IsNullOrEmpty(criterio) || criterio.Length < 2) // Solo busca si hay al menos 2 letras
            {
                menuBusqueda.Close();
                return;
            }

            ServicioInventario servicio = new ServicioInventario();
            List<Stock> coincidencias = servicio.BuscarStockPorNombre(criterio);

            menuBusqueda.Items.Clear();

            if (coincidencias.Count > 0)
            {
                foreach (Stock stockItem in coincidencias)
                {
                    ToolStripMenuItem item = new ToolStripMenuItem($"{stockItem.productoNombre} - (Disp: {stockItem.Cantidad})");
                    item.Tag = stockItem;

                    item.Click += (s, ev) =>
                    {
                        Stock seleccionado = (Stock)((ToolStripMenuItem)s).Tag;
                        AgregarTarjetaALista(seleccionado);

                        txtBuscarProducto.Clear();
                        menuBusqueda.Close();
                        txtBuscarProducto.Focus();
                    };

                    menuBusqueda.Items.Add(item);
                }

                // --- LA MAGIA ESTÁ AQUÍ ---
                // 'AutoClose' en false ayuda a mantener el control
                menuBusqueda.AutoClose = true;

                // Mostramos el menú PERO le decimos que NO tome el foco
                menuBusqueda.Show(txtBuscarProducto, new Point(0, txtBuscarProducto.Height), ToolStripDropDownDirection.BelowRight);

                // Forzamos al textbox a recuperar el foco inmediatamente después de mostrar el menú
                txtBuscarProducto.Focus();
            }
        }
    }
}
