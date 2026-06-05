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
        }

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

        private void btnCerrarPanel_Click(object sender, EventArgs e)
        {
            this.FindForm()?.Close();
        }
    }
}
