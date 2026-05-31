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
            this.BackColor = Form1Backup.AzulMenu;

       
            btnVerFactura.BackColor = Form1Backup.AzulClaroTarjetas;
            btnVerFactura.ForeColor = Color.White;      // Texto en blanco
            //btnVerFactura.Type = AntdUI.TTypeStandard.Primary;
            lblNumVenta1.ForeColor = Form1Backup.AzulClaroTarjetas;
            lblVenta1.ForeColor = Form1Backup.AzulClaroTarjetas;
        }
        public void CargarDatos(string numVenta, string fecha, string cliente, double total)
        {
            lblNumVenta1.Text = numVenta;
            lblDayVenta.Text = fecha;
            lblUserName.Text = cliente;
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
