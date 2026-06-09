using IlkaPoint.Clases;
using IlkaPoint.Data.Modelos;
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

namespace IlkaPoint
{

    public partial class ucEditarProducto : UserControl
    {
        private string rutaImagen = "";
        private Stock stockSeleccionado;
        private Producto _producoSeleccionado;
        public ucEditarProducto(Stock stock)
        {
            InitializeComponent();
            stockSeleccionado = stock;

            CargarDatosProducto();
            cmbCategorías.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            // 1. Evitar que herede escalados raros de la pantalla de inventario
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = Color.FromArgb(26, 53, 96);

            /*
            // 2. Congelar el tamaño exacto que le diste en tu diseño
            // Pon aquí los pixeles exactos que mide tu panel lateral (ejemplo: 350 de ancho por 700 de alto)
            this.MinimumSize = new Size(450, 1024);
            this.MaximumSize = new Size(480, 1024);
            this.Size = new Size(480, 1024);
            */

            // 3. Forzar que el botón Añadir mantenga su posición abajo
            btnGuardarCambios.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        }

        //DISEÑO CÓDIGO (LÍNEA 24 A 39)
        //Este evento es por si el usuario desea modificar la imagen que ya se encuentra cargada.
        private void pbProducto_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrir = new OpenFileDialog();

            abrir.Filter =
                "Imágenes|*.jpg;*.jpeg;*.png;*.bmp";

            if (abrir.ShowDialog() == DialogResult.OK)
            {
                rutaImagen = abrir.FileName;

                pbProducto.Image =
                    Image.FromFile(rutaImagen);
            }
        }

        //DISEÑO CÓDIGO (LÍNEA 43 A 45)
        //Este evento es para cerrar la ventana de editar producto al hacer clic en la "X"
        //que se encuentra en la parte superior derecha del panel.
        private void btnCerrarPanel_Click(object sender, EventArgs e)
        {
            this.FindForm()?.Close();
        }

        private void CargarDatosProducto()
        {
            ServicioInventario inventario = new ServicioInventario();
            _producoSeleccionado = inventario.BuscarProductoPorId(stockSeleccionado.ProductoId);


            if (_producoSeleccionado != null)
            {
                txtNombreProducto.Text = _producoSeleccionado.nombre;
                cmbCategorías.Text = _producoSeleccionado.categoria;
                inputNumberCantProducto.Value = stockSeleccionado.Cantidad;
                input1.Text = _producoSeleccionado.precio.ToString();
            }

            if (_producoSeleccionado.rutaImagenPng != null && _producoSeleccionado.rutaImagenPng.Length > 0)
            {
                using (MemoryStream ms = new MemoryStream(_producoSeleccionado.rutaImagenPng))
                {
                    pbProducto.Image = Image.FromStream(ms);
                }
            }
        }

        private void btnNuevaVenta_Click(object sender, EventArgs e)
        {
            /*
            OpenFileDialog abrir = new OpenFileDialog();
            abrir.Filter = "Imágenes|*.jpg;*.jpeg;*.png;*.bmp";
            if (abrir.ShowDialog() == DialogResult.OK)
            {
                rutaImagen = abrir.FileName;
                pbProducto.Image = Image.FromFile(rutaImagen);
            }
            */

            try
            {
                _producoSeleccionado.nombre = txtNombreProducto.Text;
                _producoSeleccionado.categoria = cmbCategorías.Text;
                _producoSeleccionado.precio = decimal.Parse(input1.Text);
                stockSeleccionado.Cantidad = (int)inputNumberCantProducto.Value;
                // convertir imagen a bytes si se cambió
                if (rutaImagen != "")
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        pbProducto.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                        _producoSeleccionado.rutaImagenPng = ms.ToArray();
                    }
                }

                ServicioInventario servicio = new ServicioInventario();
                servicio.EditarProducto(_producoSeleccionado, stockSeleccionado);

                MessageBox.Show("Producto actualizado correctamente");
                this.FindForm()?.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
