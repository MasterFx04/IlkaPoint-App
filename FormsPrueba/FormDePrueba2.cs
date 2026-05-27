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
using IlkaPoint.Data.Modelos;
using IlkaPoint.Servicios;

namespace IlkaPoint
{
    public partial class FormDePrueba2 : Form
    {
        public FormDePrueba2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServicioInventario inventario = new ServicioInventario();
            dataGridView1.DataSource = inventario.ObtenerElStockActual();
        }

        private void FormDePrueba2_Load(object sender, EventArgs e)
        {
            ServicioInventario inventario = new ServicioInventario();
            dataGridView1.DataSource = inventario.ObtenerElStockActual();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
