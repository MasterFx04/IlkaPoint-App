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
        // Variables globales
        private ToolStripDropDown menuBusqueda = new ToolStripDropDown();

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

            flpListaProductos.BackColor = Color.Transparent;
            flpListaProductos.FlowDirection = FlowDirection.TopDown;
            flpListaProductos.WrapContents = false;

            // Forzamos solo el scroll vertical
            flpListaProductos.AutoScroll = true;
            flpListaProductos.HorizontalScroll.Enabled = false;
            flpListaProductos.HorizontalScroll.Visible = false;
            flpListaProductos.HorizontalScroll.Maximum = 0;
            flpListaProductos.VerticalScroll.Visible = true;

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
                cmbMetodoPago.SelectedIndex = 0;
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter && txtBuscarProducto.Focused)
            {
                string criterio = txtBuscarProducto.Text.Trim();

                if (!string.IsNullOrEmpty(criterio))
                {
                    ServicioInventario servicio = new ServicioInventario();
                    List<Stock> coincidencias = servicio.BuscarStockPorNombre(criterio);

                    if (coincidencias.Count == 1)
                    {
                        AgregarTarjetaALista(coincidencias[0]);
                        txtBuscarProducto.Clear();
                    }
                    else if (coincidencias.Count > 1)
                    {
                        ContextMenuStrip menuSeleccion = new ContextMenuStrip();

                        foreach (Stock stockItem in coincidencias)
                        {
                            ToolStripMenuItem item = new ToolStripMenuItem($"{stockItem.productoNombre} - (Disponibles: {stockItem.Cantidad})");
                            item.Tag = stockItem;

                            item.Click += (s, ev) => {
                                ToolStripMenuItem itemClickeado = (ToolStripMenuItem)s;
                                Stock stockSeleccionado = (Stock)itemClickeado.Tag;

                                AgregarTarjetaALista(stockSeleccionado);
                                txtBuscarProducto.Clear();
                            };

                            menuSeleccion.Items.Add(item);
                        }

                        menuSeleccion.Show(txtBuscarProducto, new Point(0, txtBuscarProducto.Height));
                    }
                    else
                    {
                        MessageBox.Show("No se encontró stock que coincida con la búsqueda.", "Ilka Point", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtBuscarProducto.Clear();
                        txtBuscarProducto.Focus();
                    }
                }
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void AgregarTarjetaALista(Stock prod)
        {
            flpListaProductos.SuspendLayout();

            InfoProducto nuevaFila = new InfoProducto();
            nuevaFila.AutoSize = false;

            // Si quiero modificar el ancho de las tarjetas cambio esto
            int anchoFijoTarjeta = 370;

            // Tamaños estables del User Control
            nuevaFila.Size = new Size(anchoFijoTarjeta, 90);
            nuevaFila.MinimumSize = new Size(anchoFijoTarjeta, 90);
            nuevaFila.MaximumSize = new Size(anchoFijoTarjeta, 90);

            // Margen para agregar algo de espacio entre tarjetas y evitar choque con el scrollbar
            nuevaFila.Margin = new Padding(4, 0, 0, 8);

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

            flpListaProductos.ResumeLayout(true);
            flpListaProductos.PerformLayout();

            flpListaProductos.HorizontalScroll.Maximum = 0;

            txtBuscarProducto.Clear();
            txtBuscarProducto.Focus();
        }

        public Image ConvertirBytesAImagen(byte[] imagenBytes)
        {
            if (imagenBytes == null || imagenBytes.Length == 0)
            {
                return null;
            }

            using (MemoryStream ms = new MemoryStream(imagenBytes))
            {
                return Image.FromStream(ms);
            }
        }

        private void ActualizarTotales()
        {
            int totalArticulos = 0;
            decimal granTotal = 0;

            foreach (Control control in flpListaProductos.Controls)
            {
                if (control is InfoProducto item)
                {
                    if (int.TryParse(item.txtCantidad.Text, out int cant))
                    {
                        totalArticulos += cant;
                        granTotal += (item.PrecioUnitario * cant);
                    }
                }
            }

            lblTotalProductos.Text = totalArticulos.ToString();
            lblTotalPrecio.Text = $"${granTotal:F2}";
        }

        private List<Stock> BuscarCoincidenciasEnBD(string criterio)
        {
            string termino = criterio.ToLower().Trim();
            List<Stock> resultado = new List<Stock>();
            Image fotoDefecto = Properties.Resources.xredmarkimg;

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

        private void cmbMetodoPago_SelectedIndexChanged(object sender, EventArgs e) { }
        private void panelArriba_Paint(object sender, PaintEventArgs e) { }

        private void btnRegistrarVenta1_Click(object sender, EventArgs e)
        {
            try
            {
                if (flpListaProductos.Controls.Count == 0)
                {
                    MessageBox.Show("Debe agregar al menos un producto a la venta.", "Ilka Point", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string metodoPagoSeleccionado = (cmbMetodoPago != null && cmbMetodoPago.SelectedItem != null)
                                                ? cmbMetodoPago.SelectedItem.ToString()
                                                : null;

                if (string.IsNullOrEmpty(metodoPagoSeleccionado))
                {
                    MessageBox.Show("Seleccione un método de pago.", "Ilka Point", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Transaccion nuevaTransaccion = new Transaccion(false);

                if (nuevaTransaccion.Detalles == null)
                {
                    nuevaTransaccion.Detalles = new List<DetallesTransaccion>();
                }

                nuevaTransaccion.MetodoPago = metodoPagoSeleccionado;
                TransaccionService service = new TransaccionService();

                foreach (Control control in flpListaProductos.Controls)
                {
                    if (control is InfoProducto item)
                    {
                        if (int.TryParse(item.txtCantidad.Text, out int cant) && cant > 0)
                        {
                            int productoId = item.IdProducto;
                            DetallesTransaccion detalle = service.CrearDetalle(productoId, cant);
                            nuevaTransaccion.Detalles.Add(detalle);
                        }
                    }
                }

                if (nuevaTransaccion.Detalles.Count == 0)
                {
                    MessageBox.Show("Las cantidades de los productos no son válidas.", "Ilka Point", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                service.RegistrarTransaccion(nuevaTransaccion);

                Form host = new Form
                {
                    StartPosition = FormStartPosition.CenterParent,
                    Width = 800,
                    Height = 600,
                    Text = "Factura de Venta"
                };

                flpListaProductos.Controls.Clear();
                ActualizarTotales();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al registrar la venta:\n\n{ex.Message}", "Error de Venta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.FindForm()?.Close();
        }

        private void lblNumVenta_Click(object sender, EventArgs e) { }
        private void flpListaProductos_Paint(object sender, PaintEventArgs e) { }
        private void AgregarVenta_Load(object sender, EventArgs e) { }

        private void btnCerrarPanel_Click(object sender, EventArgs e)
        {
            this.FindForm()?.Close();
        }

        private void lblTotal_Click(object sender, EventArgs e) { }

        private void txtBuscarProducto_TextChanged(object sender, EventArgs e)
        {
            string criterio = txtBuscarProducto.Text.Trim();

            if (string.IsNullOrEmpty(criterio) || criterio.Length < 2)
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

                menuBusqueda.AutoClose = true;
                menuBusqueda.Show(txtBuscarProducto, new Point(0, txtBuscarProducto.Height), ToolStripDropDownDirection.BelowRight);
                txtBuscarProducto.Focus();
            }
        }
    }
}