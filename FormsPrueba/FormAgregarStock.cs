using IlkaPoint.Clases;
using IlkaPoint.Data.Modelos;
using IlkaPoint.Servicios;
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
    public partial class FormAgregarStock : Form
    {
        private Producto producto;
        public FormAgregarStock(Producto producto)
        {
            InitializeComponent();
            this.producto = producto;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int cantidad = int.Parse(textBox1.Text);
            ServicioInventario inventario = new ServicioInventario();

            inventario.AgregarCantidadStock(producto.id, cantidad);
            this.Close();
        }

        private void FormAgregarStock_Load(object sender, EventArgs e)
        {
            label3.Text = producto.nombre;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
