using AntdUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IlkaPoint
{
    public partial class FrmInventario2 : Form
    {
        public FrmInventario2()
        {
            InitializeComponent();
            this.Load += FrmInventario_Load;
        }

        private void FrmInventario_Load(object sender, EventArgs e)
        {
            dgvInventario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvInventario.Dock = DockStyle.Fill;
            dgvInventario.EnableHeadersVisualStyles = false;
            CargarDatos();
        }


        private void CargarDatos()
        {
            dgvInventario.Rows.Clear();

            dgvInventario.Rows.Add("Abarrotes", "Arroz Gold Special 5lb", 120, "Abundante");
            dgvInventario.Rows.Add("Abarrotes", "Aceite Vegetal Gourmet 1L", 45, "Abundante");
            dgvInventario.Rows.Add("Abarrotes", "Porotos Chícharos 400g", 85, "Abundante");
            dgvInventario.Rows.Add("Abarrotes", "Harina de Trigo", 60, "Abundante");
            dgvInventario.Rows.Add("Abarrotes", "Café Durán Tradicional", 8, "Bajo Stock");

            dgvInventario.Rows.Add("Lácteos", "Leche Entera Estrella 1L", 140, "Abundante");
            dgvInventario.Rows.Add("Lácteos", "Queso Amarillo Kraft", 22, "Abundante");
            dgvInventario.Rows.Add("Lácteos", "Yogurt Griego", 15, "Agotado");
            dgvInventario.Rows.Add("Lácteos", "Mantequilla Dos Pinos", 5, "Bajo Stock");

            dgvInventario.Rows.Add("Bebidas", "Coca Cola Original 2L", 95, "Abundante");
            dgvInventario.Rows.Add("Bebidas", "Jugo Estrella de Naranja", 34, "Abundante");
            dgvInventario.Rows.Add("Bebidas", "Agua Purificada Cristal", 200, "Agotado");

            dgvInventario.Rows.Add("Limpieza", "Cloro Max", 50, "Agotado");
            dgvInventario.Rows.Add("Limpieza", "Detergente en Polvo", 40, "Abundante");
            dgvInventario.Rows.Add("Limpieza", "Desinfectante", 3, "Bajo Stock");
        }

        private void dgvInventario_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                string estado = e.Value?.ToString();

                if (estado == "Abundante")
                {
                    e.CellStyle.BackColor = Color.LightGreen;
                }

                if (estado == "Bajo Stock")
                {
                    e.CellStyle.BackColor = Color.Khaki;
                }

                if (estado == "Agotado")
                {
                    e.CellStyle.BackColor = Color.LightCoral;
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow fila in dgvInventario.Rows)
            {
                fila.Visible = fila.Cells[1]
                    .Value.ToString()
                    .ToLower()
                    .Contains(txtBuscarProducto.Text.ToLower());
            }
        }



        private void dgvInventario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // evita clic en el header

            if (dgvInventario.Columns[e.ColumnIndex].Name == "colEditar")
            {
                MessageBox.Show("Editar producto");
                // aquí va tu lógica de editar
            }

            if (dgvInventario.Columns[e.ColumnIndex].Name == "colEliminar")
            {
                DialogResult respuesta = MessageBox.Show(
                    "¿Desea eliminar este producto?",
                    "Confirmar",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {
                    dgvInventario.Rows.RemoveAt(e.RowIndex);
                }
            }
        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

