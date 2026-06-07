using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IlkaPoint.Forms_Oficiales
{
    public partial class AgregarVenta : UserControl
    {
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
            if (keyData == Keys.Enter && txtBuscarProducto.Focused)
            {
                string criterio = txtBuscarProducto.Text.Trim();

                if (!string.IsNullOrEmpty(criterio))
                {
                    // Para obtener coincidencias de la base de datos simulada
                    List<ProductoSimulado> coincidencias = BuscarCoincidenciasEnBD(criterio);

                    if (coincidencias.Count == 1)
                    {
                        // Coincidencia única exacta: se agrega directo
                        AgregarTarjetaALista(coincidencias[0]);
                    }
                    else if (coincidencias.Count > 1)
                    {
                        // Menu flotante para seleccionar entre las coincidencias encontradas
                        ContextMenuStrip menuSeleccion = new ContextMenuStrip();

                        foreach (var prod in coincidencias)
                        {
                            // Menú mostrando Nombre y Precio
                            ToolStripMenuItem item = new ToolStripMenuItem($"{prod.Nombre} - ${prod.Precio:F2}");

                            // Guardamos el objeto completo dentro del tag de la opción
                            item.Tag = prod;

                            // Evento al hacer clic en este producto específico
                            item.Click += (s, ev) => {
                                ToolStripMenuItem itemClickeado = (ToolStripMenuItem)s;
                                ProductoSimulado prodSeleccionado = (ProductoSimulado)itemClickeado.Tag;
                                AgregarTarjetaALista(prodSeleccionado);
                            };

                            menuSeleccion.Items.Add(item);
                        }

                        // Refleja el menu flotante justo debajo del textbox de búsqueda
                        menuSeleccion.Show(txtBuscarProducto, new Point(0, txtBuscarProducto.Height));
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron productos que coincidan con la búsqueda.", "Ilca Point", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtBuscarProducto.Clear();
                        txtBuscarProducto.Focus();
                    }
                }

                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void AgregarTarjetaALista(ProductoSimulado prod)
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
            nuevaFila.CargarDatos(prod.Id, prod.Nombre, prod.Precio, prod.Foto);

            flpListaProductos.Controls.Add(nuevaFila);

            nuevaFila.BringToFront();
            flpListaProductos.Update();
            flpListaProductos.ResumeLayout(true);
            flpListaProductos.PerformLayout();

            txtBuscarProducto.Clear();
            txtBuscarProducto.Focus();

            ActualizarTotales();
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
        private List<ProductoSimulado> BuscarCoincidenciasEnBD(string criterio)
        {
            string termino = criterio.ToLower().Trim();
            List<ProductoSimulado> resultado = new List<ProductoSimulado>();

            // Foto por default en caso tal el producto no tenga una imagen asignada en la base de datos
            Image fotoDefecto = Properties.Resources.xredmarkimg;

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

            foreach (var prod in inventarioBD)
            {
                if (prod.Nombre.ToLower().Contains(termino) || prod.Id.ToString() == termino)
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
            // Validación de existencia de productos en la venta antes de registrar
            if (flpListaProductos.Controls.Count == 0)
            {
                MessageBox.Show("Debe agregar al menos un producto a la venta.", "Ilka Point", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validacion del metodo de pago
            string metodoPagoSeleccionado = (cmbMetodoPago != null && cmbMetodoPago.SelectedItem != null)
                                           ? cmbMetodoPago.SelectedItem.ToString()
                                           : "Efectivo";

            // Para recalcular totales (total de productos) antes de guardar
            ActualizarTotales();

            var nuevaVenta = new Form1v2.RegistroVenta()
            {
                IdVenta = "00" + (Form1v2.BaseDatosVentas.Count + 1), 
                MetodoPago = metodoPagoSeleccionado, 
                Fecha = DateTime.Now.ToString("dd-MM-yyyy"),
                TotalArticulos = int.Parse(lblTotalProductos.Text),
                MontoTotal = decimal.Parse(lblTotalPrecio.Text.Replace("$", ""))
            };

            // Extracción de productos desde la tarjeta para agregarlos a la factura
            foreach (Control control in flpListaProductos.Controls)
            {
                if (control is InfoProducto item)
                {
                    if (int.TryParse(item.txtCantidad.Text, out int cant) && cant > 0)
                    {
                        nuevaVenta.Productos.Add(new Form1v2.ItemVendido
                        {
                            Nombre = item.lblNombre.Text,
                            Cantidad = cant,
                            Precio = item.PrecioUnitario
                        });
                    }
                }
            }

            // Guardamos venta
            Form1v2.BaseDatosVentas.Add(nuevaVenta);

            MessageBox.Show($"¡Venta registrada con éxito (ID: {nuevaVenta.IdVenta})!", "Ilka Point", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
    }
}
