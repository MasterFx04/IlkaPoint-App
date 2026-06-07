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

    public partial class ucAgregarProducto : UserControl
    {
        private string rutaImagen = "";
        public ucAgregarProducto()
        {
            InitializeComponent();
            // 1. Evitar que herede escalados raros de la pantalla de inventario
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;

            // 2. Congelar el tamaño exacto que le diste en tu diseño
            // Pon aquí los pixeles exactos que mide tu panel lateral (ejemplo: 350 de ancho por 700 de alto)
            this.MinimumSize = new Size(456, 968);
            this.MaximumSize = new Size(480, 1018);
            this.Size = new Size(456, 968);

            // 3. Forzar que el botón Añadir mantenga su posición abajo
            btnAgregarProducto.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        }
     

        //Este evento lo geeneré por error mientras diseñaba, pueden borrarlo.
        private void label2_Click(object sender, EventArgs e)
        {

        }

        //ESTE CÓDIGO NO SE UTILIZA ORIGINALMENTE!!
        //Aquí se configura el evento del botón para subir la imagen pero ese botón
        //lo eliminé porque en el diseño de tu Figma, la imagen se sube al hacer
        //clic directamente sobre el PictureBox.
        private void btnSubirImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrir = new OpenFileDialog();

            abrir.Filter =
                "Archivos de Imagen|*.jpg;*.jpeg;*.png;*.bmp";

            if (abrir.ShowDialog() == DialogResult.OK)
            {
                rutaImagen = abrir.FileName;

                pbProducto.Image =
                    Image.FromFile(rutaImagen);
            }
        }

        //ESTE ES EL EVENTO CORRECTO PARA SUBIR LA IMAGEN HACIENDO CLIC EN EL PICTUREBOX!!
        //DISEÑO CÓDIGO (LÍNEA 50 A 65)
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

        //DISEÑO CÓDIGO (LÍNEA 69 A 70)
        //Este evento configura la "X" para cerrar la ventana de agregar producto.
        private void btnCerrarPanel_Click(object sender, EventArgs e)
        {
            this.FindForm()?.Close();
        }
    }
}