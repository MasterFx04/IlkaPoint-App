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
using IlkaPoint.FormsPrueba;
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
            //CARGAMOS DATOS
            ServicioInventario inventario = new ServicioInventario();
            dataGridView1.DataSource = inventario.ObtenerElStockActual();

            //Columna Eliminar
            DataGridViewButtonColumn btnEliminar = new DataGridViewButtonColumn();
            btnEliminar.HeaderText = "Accion";
            btnEliminar.Text = "X";
            btnEliminar.UseColumnTextForButtonValue = true;
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Width = 50;
            
            dataGridView1.Columns.Add(btnEliminar);

            //Columna Editar
            DataGridViewButtonColumn btnEditar = new DataGridViewButtonColumn();
            btnEditar.HeaderText = "";
            btnEditar.Text = "Edit";
            btnEditar.UseColumnTextForButtonValue = true;
            btnEditar.Name = "btnEditar";
            btnEditar.Width = 50;

            dataGridView1.Columns.Add(btnEditar);

            dataGridView1.Columns["Id"].Visible = false;
            //dataGridView1.Columns["idProducto"].Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            // el datagridview tiene Stock, no Producto
            Stock stockSeleccionado = (Stock)dataGridView1.Rows[e.RowIndex].DataBoundItem;
            ServicioInventario inventario = new ServicioInventario();

            if (dataGridView1.Columns[e.ColumnIndex].Name == "btnEliminar")
            {
                DialogResult confirm = MessageBox.Show(
                    "¿Eliminar " + stockSeleccionado.productoNombre + "?",
                    "Confirmar",
                    MessageBoxButtons.YesNo
                );

                if (confirm == DialogResult.Yes)
                {
                    inventario.EliminarProducto(stockSeleccionado.ProductoId);
                    dataGridView1.DataSource = inventario.ObtenerElStockActual();
                }
            }
            else if (dataGridView1.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                // busca el producto usando el ProductoId del stock
                Producto producto = inventario.BuscarProductoPorId(stockSeleccionado.ProductoId);

                // refresca después de editar
                
                EditProduct controlEditarProducto = new EditProduct(stockSeleccionado, producto);
                controlEditarProducto.Dock = DockStyle.Right;
                this.Controls.Add(controlEditarProducto);
                controlEditarProducto.BringToFront();
                
                //dataGridView1.DataSource = inventario.ObtenerElStockActual();

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string nombreProducto = textBox1.Text;

            ServicioInventario inventario = new ServicioInventario();
            dataGridView1.DataSource = inventario.BuscarStockPorNombre(nombreProducto);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            AgregarProducto userAgregar = new AgregarProducto();
            userAgregar.Dock = DockStyle.Right;
            this.Controls.Add(userAgregar);
            userAgregar.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            RegistroVentasForm registroVentas = new RegistroVentasForm();
            registroVentas.Show();
        }
    }
}
