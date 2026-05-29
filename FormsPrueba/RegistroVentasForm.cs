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

        private Stock selectedStock;

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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string nombreProducto = textBox1.Text;
            ServicioInventario inventario = new ServicioInventario();
            dataGridView1.DataSource = inventario.BuscarStockPorNombre(nombreProducto);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int cantidad = int.Parse(textBox2.Text);
            if (cantidad > selectedStock.Cantidad)
            {
                MessageBox.Show("La cantidad ingresada sobrepasa el stock de ese producto, intente nuevamente");
                return;
            }

            decimal total = productoAComprar.precio * cantidad;
            TransaccionService transaccionService = new TransaccionService();

            if (textBox2.Text != null)
            {
                DetallesTransaccion detalle = transaccionService.CrearDetalle(productoAComprar.id, cantidad);

                transaccion.Detalles.Add(detalle);

                //dataGridView2.Rows.Add(detalle);
                
                dataGridView2.Rows.Add(
                    productoAComprar.nombre,
                    productoAComprar.precio,
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
            transaccion.MetodoPago = metodoDePago;
            MessageBox.Show("Metodo de Pago Seleccionado: " + metodoDePago);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Para llevar la transaccion al form de Transacciones

            if (transaccion.Detalles.Count == 0)
            {
                MessageBox.Show("No se han agregado");
                return;
            }

            if (transaccion.MetodoPago == null)
            {
                MessageBox.Show("Seleccione un metodo de pago");
                return;
            }
            transaccion.Total = transaccion.CalcularTotal();

            TransaccionService service = new TransaccionService();
            service.RegistrarTransaccion(transaccion);
            //MessageBox.Show("Transaccion Registrada con Exito! Total: B/: " + transaccion.Total);
            /*
            UserControlPrueba muestroDeFactura = new UserControlPrueba(transaccion);
            muestroDeFactura.Show();
            */

            //INVOCAR UN NUEVO FORM PARA LA FACTURA
            Form host = new Form
            {
                StartPosition = FormStartPosition.CenterParent,
                Width = 800,
                Height = 600
            };
            var muestroDeFactura = new UserControlPrueba(transaccion) { Dock = DockStyle.Fill };
            host.Controls.Add(muestroDeFactura);
            host.Show(); // o host.ShowDialog(this);

            transaccion = new Transaccion(false);
            dataGridView2.Rows.Clear();

            ServicioInventario inventario = new ServicioInventario();
            dataGridView1.DataSource = inventario.ObtenerElStockActual();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            //productoAComprar = (Producto)dataGridView1.Rows[e.RowIndex].DataBoundItem;

            if (e.RowIndex < 0) { return; }

            Stock stockSeleccionado = (Stock)dataGridView1.Rows[e.RowIndex].DataBoundItem;

            SeleccionarStock(stockSeleccionado);

            //Buscando el producto para usarlo despues :D
            ServicioInventario inventario = new ServicioInventario();
            productoAComprar = inventario.BuscarProductoPorId(stockSeleccionado.ProductoId);
            if (productoAComprar != null)
            {
                MessageBox.Show("Producto Seleccionado: " + productoAComprar.nombre);
            }
        }

        public void SeleccionarStock(Stock stock)
        {
            selectedStock = stock;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SeleccionMetodoPago("Efectivo");
        }
    }
}
