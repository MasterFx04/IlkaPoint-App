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

        public static readonly Color AzulMenu = ColorTranslator.FromHtml("#08243B");

        public ucEditarProducto()
        {
            InitializeComponent();
            this.BackColor = ColorTranslator.FromHtml("#1A3560");
        }
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

            // 2. Congelar el tamaño exacto que le diste en tu diseño
            // Pon aquí los pixeles exactos que mide tu panel lateral (ejemplo: 350 de ancho por 700 de alto)
            this.MinimumSize = new Size(456, 968);
            this.MaximumSize = new Size(480, 1018);
            this.Size = new Size(456, 968);

            // 3. Forzar que el botón Guardar mantenga su posición abajo
            btnGuardar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
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

        private void btnNuevaVenta_Click(object sender, EventArgs e)
        {

        }

        private void FrmEditarProducto_Load(object sender, EventArgs e)
        {
            // 1. Forzar el tamaño de la nube a sus dimensiones reales (ejemplo: 150x150)
            // Cambia estos números por el tamaño ideal que quieres que tenga
            pbProducto.Size = new Size(208, 100);

            // 2. Calcular el espacio vertical disponible entre el campo de texto 4 y el botón
            // Tomamos la posición Y del botón de abajo y la Y del campo de arriba
            int limiteSuperior = txtPrecio2.Location.Y + txtPrecio2.Height;
            int limiteInferior = btnGuardar.Location.Y;

            // 3. Encontrar el centro exacto de ese espacio vacío
            int espacioDisponible = limiteInferior - limiteSuperior;
            int centroY = limiteSuperior + (espacioDisponible / 2) - (pbProducto.Height / 2);

            // 4. Centrar también horizontalmente en la ventana
            int centroX = (this.Width / 2) - (pbProducto.Width / 2);

            // 5. Asignar la posición matemática exacta
            pbProducto.Location = new Point(centroX, centroY);
        }

        private void btnCerrarPanel_Click_1(object sender, EventArgs e)
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
                txtPrecio2.Text = _producoSeleccionado.precio.ToString();
            }

            if (_producoSeleccionado.rutaImagenPng != null && _producoSeleccionado.rutaImagenPng.Length > 0)
            {
                using (MemoryStream ms = new MemoryStream(_producoSeleccionado.rutaImagenPng))
                {
                    pbProducto.Image = Image.FromStream(ms);
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
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
                _producoSeleccionado.precio = decimal.Parse(txtPrecio2.Text);
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
