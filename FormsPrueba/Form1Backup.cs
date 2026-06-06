using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IlkaPoint.Data.Modelos;
using IlkaPoint.Clases;
using IlkaPoint.Servicios;
using IlkaPoint.FormsPrueba;

namespace IlkaPoint.FormsPrueba
{
    public partial class Form1Backup : Form
    {
        public Form1Backup()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServicioInventario inventario = new ServicioInventario();

            string nombre = textBox1.Text;
            string categoria = textBox2.Text;
            string proovedor = textBox3.Text;
            decimal precio = decimal.Parse(textBox4.Text);

            Producto productoPrueba = new ProductoPorUnidad(nombre, categoria, proovedor, precio, "skibidi");

            /*
            if (comboBox1.SelectedItem.ToString() == "Unitario")
            {
                productoPrueba = new ProductoPorUnidad(nombre, categoria, proovedor, precio, "skibidi");

            }
            else if (comboBox1.SelectedItem.ToString() == "Por Precio")
            {
                productoPrueba = new ProductoPorPeso(nombre, categoria, proovedor, precio, "skibidi", 0);
            }
            else
            {
                MessageBox.Show("Ingrese un Tipo de Producto");
                return;
            }
            */

            inventario.AgregarProducto(productoPrueba);

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ServicioInventario inventario = new ServicioInventario();
            dataGridView1.DataSource = inventario.ObtenerTodoElInventario();

            dataGridView1.Columns["Id"].Visible = false;
            dataGridView1.Columns["rutaImagenPng"].Visible = false;


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ServicioInventario inventario = new ServicioInventario();
            dataGridView1.DataSource = inventario.ObtenerTodoElInventario();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormDePrueba2 nuevoForm = new FormDePrueba2();
            nuevoForm.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

            if (e.RowIndex < 0) { return; }

            Producto producto = (Producto)dataGridView1.Rows[e.RowIndex].DataBoundItem;
            //MessageBox.Show(producto.nombre); si funciona

            if (producto is ProductoPorPeso)
            {
                MessageBox.Show("No se ingresan cantidades de este producto ya que es un producto por peso");
                return;
            }

            FormAgregarStock formStock = new FormAgregarStock(producto);
            formStock.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            RegistroVentasForm form = new RegistroVentasForm();
            form.Show();
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            label5.Text = "Precio " + comboBox1.SelectedItem.ToString();
        }
    }
}
