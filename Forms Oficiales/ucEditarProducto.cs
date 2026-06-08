using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        //DISEÑO CÓDIGO (LÍNEA 24 A 39)
        //Este evento es por si el usuario desea modificar la imagen que ya se encuentra cargada.
        private void pbProducto_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrir =
      new OpenFileDialog();

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
            int limiteInferior = btnNuevaVenta.Location.Y;

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
    }
}
