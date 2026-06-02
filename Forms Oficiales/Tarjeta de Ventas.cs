using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IlkaPoint.Clases
{
    public partial class Tarjeta_de_Ventas : UserControl
    {
        public Tarjeta_de_Ventas()
        {
            InitializeComponent();
            ConfigurarEstiloEstetico();
        }

        private void ConfigurarEstiloEstetico()
        {
            this.BackColor = Form1.AzulMenu;


            btnVerFactura.BackColor = Form1.AzulClaroTarjetas;
            btnVerFactura.ForeColor = Color.White;  
            lblNumVenta1.ForeColor = Form1.AzulClaroTarjetas;
            lblVenta1.ForeColor = Form1.AzulClaroTarjetas;
        }

        /// <summary>
        /// Carga los datos de la venta en la tarjeta estética del historial.
        /// </summary>
        /// <param name="metodoPago"> 
        public void CargarDatos(string numVenta, string fecha, string metodoPago, double total)
        {
            lblNumVenta1.Text = numVenta;
            lblDayVenta.Text = fecha;
            lblPaidMet.Text = metodoPago;
            lblTotalVenta.Text = $"$ {total:N2}";
        }

        private void Tarjeta_de_Ventas_Load(object sender, EventArgs e)
        {

        }

        private void btnVerFactura_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblNumVenta1_Click(object sender, EventArgs e)
        {

        }
    }
}