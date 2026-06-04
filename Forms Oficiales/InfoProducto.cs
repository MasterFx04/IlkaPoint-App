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
    public partial class InfoProducto : UserControl
    {
        // Variables para almacenar los datos que vienen de la BD
        public int IdProducto { get; set; }
        public decimal PrecioUnitario { get; set; }

        public InfoProducto()
        {
            InitializeComponent();
            this.BackColor = ColorTranslator.FromHtml("#08243B");

            txtCantidad.AutoSize = false;
            txtCantidad.Size = new Size(65, 65);

        }

        public void CargarDatos(int id, string nombre, decimal precio, Image foto)
        {
            IdProducto = id;
            PrecioUnitario = precio;

            lblNombre.Text = nombre;
            lblPrecio.Text = $"${precio:F2} (C/U)";

            if (foto != null)
            {
               picref.Image = foto;
            }
            else
            {
                // Por si el producto no tiene foto en la BD, se coloca una por defecto. POR EL MOMENTO ES LA QUE ESTAMOS USANDO
               picref.Image = Properties.Resources.xredmarkimg;
            }
        }

        // Evento para cuando el cajero digite un cambio en el cuadrante numérico
        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void InfoProducto_Load(object sender, EventArgs e)
        {

        }

        private void txtCantidad_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void lblPrecio_Click(object sender, EventArgs e)
        {

        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }
    }
}
