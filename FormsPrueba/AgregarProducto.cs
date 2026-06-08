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
    public partial class AgregarProducto : UserControl
    {

        public AgregarProducto()
        {
            InitializeComponent();
        }

        private void AgregarProducto_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            /*
            producto.nombre = textBox3.Text;
            producto.precio = decimal.Parse(textBox4.Text);
            producto.categoria = textBox2.Text;
            stock.Cantidad = int.Parse(textBox1.Text);
            */
            string nombre = textBox3.Text;
            decimal precio = decimal.Parse(textBox4.Text);
            string categoria = textBox2.Text;
            int cantidad = int.Parse(textBox1.Text);
            byte[] image = null; //ESTO NO TIENE SENTIDO PERO COMO YA NO USAMOS EL FORMS :D

            Producto productoNuevo = new Producto(nombre, categoria, "proovedor prueba", precio, image);
            

            ServicioInventario inventario = new ServicioInventario();
            inventario.AgregarProducto(productoNuevo);
            inventario.AgregarCantidadStock(productoNuevo.id, cantidad);

            //this.Close()

            this.Dispose();

        }
    }
}
