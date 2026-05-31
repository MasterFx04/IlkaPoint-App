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

namespace IlkaPoint.FormsPrueba
{
    public partial class EditProduct : UserControl
    {
        private Stock stock;
        private Producto producto;

        public EditProduct(Stock stock, Producto producto)
        {
            InitializeComponent();
            this.stock = stock;
            this.producto = producto;
        }

        private void EditProduct_Load(object sender, EventArgs e)
        {
            textBox2.Text = producto.categoria;
            textBox3.Text = producto.nombre;
            textBox1.Text = stock.Cantidad.ToString();
            textBox4.Text = producto.CalcularPrecio().ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            producto.nombre = textBox3.Text;
            producto.precio = decimal.Parse(textBox4.Text);
            producto.categoria = textBox2.Text;
            stock.Cantidad = int.Parse(textBox1.Text);

            ServicioInventario inventario = new ServicioInventario();
            inventario.EditarProducto(producto, stock);

            //this.Close()

            this.Dispose();
            
        }
    }
}
