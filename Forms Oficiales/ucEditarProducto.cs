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
        public ucEditarProducto()
        {
            InitializeComponent();
            cmbCategorías.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            // 1. Evitar que herede escalados raros de la pantalla de inventario
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;

            // 2. Congelar el tamaño exacto que le diste en tu diseño
            // Pon aquí los pixeles exactos que mide tu panel lateral (ejemplo: 350 de ancho por 700 de alto)
            this.MinimumSize = new Size(456, 968);
            this.MaximumSize = new Size(480, 1018);
            this.Size = new Size(456, 968);

            // 3. Forzar que el botón Añadir mantenga su posición abajo
            btnGuardarCambios.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
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
    }
}
