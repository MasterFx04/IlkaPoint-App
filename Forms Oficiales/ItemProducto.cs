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
    public partial class ItemProducto : UserControl
    {
        public ItemProducto()
        {
            InitializeComponent();
        }

        // Este método para recibir datos individuales del producto y configurar el item
        public void ConfigurarRenglon(string nombre, int cantidad, decimal precio, decimal subtotal)
        {
            lblNombreProducto.Text = nombre;

            // Operación matemática (Ej: "3 x 1.00")
            lblOperacion.Text = $"{cantidad} x {precio:F2}";

            // 3. Asignamos el subtotal final a la derecha (Ej: "3.00")
            lblSubtotal.Text = $"{subtotal:F2}";
        }

        private void ItemProducto_Load(object sender, EventArgs e)
        {

        }
    }
}
