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
using IlkaPoint.Data;
using IlkaPoint.Data.Modelos;
using IlkaPoint.Servicios;

namespace IlkaPoint.FormsPrueba
{

    public partial class RegistroVentasForm : Form
    {
        private Producto productoAComprar;
        private decimal totalDeCompra = 0;
        private string metodoPago;
        private Transaccion transaccion = new Transaccion(false);

        public RegistroVentasForm()
        {
            InitializeComponent();
        }

        private void RegistroVentasForm_Load(object sender, EventArgs e)
        {
            ServicioInventario inventario = new ServicioInventario();
            dataGridView1.DataSource = inventario.ObtenerElStockActual();
            dataGridView1.Columns["Id"].Visible = false;
            //dataGridView1.Columns["productoId"].Visible = false;

            
            dataGridView2.Columns.Add("Nombre", "Nombre");
            dataGridView2.Columns.Add("Precio", "Precio Unitario");
            dataGridView2.Columns.Add("Cantidad", "Cantidad");
            dataGridView2.Columns.Add("Total", "Total");
            
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //productoAComprar = (Producto)dataGridView1.Rows[e.RowIndex].DataBoundItem;

            if (e.RowIndex < 0) { return; }

            Stock stockSeleccionado = (Stock)dataGridView1.Rows[e.RowIndex].DataBoundItem;

            //Buscando el producto para usarlo despues :D
            ServicioInventario inventario = new ServicioInventario();
            Producto producto = inventario.
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string nombreProducto = textBox1.Text;
            ServicioInventario inventario = new ServicioInventario();
            dataGridView1.DataSource = inventario.BuscarProductoPorNombre(nombreProducto);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int cantidad = int.Parse(textBox2.Text);
            decimal total = productoAComprar.precio * cantidad;
            TransaccionService transaccionService = new TransaccionService();

            if (textBox2.Text != null)
            {
                DetallesTransaccion detalle = transaccionService.CrearDetalle(productoAComprar.id, cantidad);

                transaccion.Detalles.Add(detalle);

                //dataGridView2.Rows.Add(detalle);
                
                dataGridView2.Rows.Add(
                    detalle.Producto.nombre,
                    detalle.Producto.precio,
                    cantidad,
                    total
                    );
                


                totalDeCompra += total;
                label3.Text = "Total: B/: " + totalDeCompra;
            }
            else
            {
                return;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SeleccionMetodoPago("Yappy");
        }

        private void SeleccionMetodoPago(string metodoDePago)
        {
            MessageBox.Show("Metodo de Pago Seleccionado: " + metodoDePago);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Para llevar la transaccion al form de Transacciones
        }
    }
}
