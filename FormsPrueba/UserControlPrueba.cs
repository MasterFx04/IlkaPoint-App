using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IlkaPoint.Clases;

namespace IlkaPoint.FormsPrueba
{
    public partial class UserControlPrueba : UserControl
    {
        private Transaccion transaccion;
        public UserControlPrueba(Transaccion transaccion)
        {
            InitializeComponent();
            this.transaccion = transaccion;
        }

        private void UserControlPrueba_Load(object sender, EventArgs e)
        {
            panel1.Controls.Clear();

            int posicionY = 0; // Posición inicial en Y

            foreach (DetallesTransaccion detalle in transaccion.Detalles)
            {
                //SE CREARA UN LABEL POR CADA DETALLE
                Label lblDetalle = new Label();
                lblDetalle.Text = $"{detalle.Cantidad}x {detalle.ProductoNombre} - ${detalle.PrecioUnitario} = ${detalle.SubTotal}";
                lblDetalle.Location = new Point(10, posicionY);
                lblDetalle.AutoSize = true;

                panel1.Controls.Add(lblDetalle);
                posicionY += 25; // BAJARA PARA EL SIGUIENTE LABEL
            }

            label3.Text = "Total: " + transaccion.CalcularTotal().ToString("F2");
        }
    }
}
