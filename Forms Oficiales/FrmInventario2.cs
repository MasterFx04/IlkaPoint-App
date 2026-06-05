using AntdUI;
using IlkaPoint.Forms_Oficiales;
using IlkaPoint.FormsPrueba;
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

        private void AbrirEditarProductoLateral(string idProducto)
        {
            // 1. Fondo oscuro
            Form_FondoOscuro fondo = new Form_FondoOscuro();
            fondo.StartPosition = FormStartPosition.Manual;
            fondo.Bounds = this.Bounds;
            fondo.Show(this);

            // 2. Ventana contenedora a la derecha
            Form ventanaContenedor = new Form();
            ventanaContenedor.FormBorderStyle = FormBorderStyle.None;
            ventanaContenedor.Size = new Size(480, this.Height);
            ventanaContenedor.StartPosition = FormStartPosition.Manual;
            ventanaContenedor.Location = new Point(this.Location.X + this.Width - 480, this.Location.Y);
            ventanaContenedor.ShowInTaskbar = false;

            // 3. Instancia de tu User Control de EDITAR
            ucEditarProducto panelEditar = new ucEditarProducto();
            panelEditar.Dock = DockStyle.Fill;

            // Aquí le pasas el ID al control si tienes un método interno para cargar los datos
            // panelEditar.CargarDatos(idProducto);

            ventanaContenedor.Controls.Add(panelEditar);

            // 4. Mostrar y limpiar
            ventanaContenedor.ShowDialog(fondo);
            fondo.Dispose();
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
            if (e.RowIndex < 0) return;

            // Si hicieron clic en la columna llamada "Editar"
            if (dgvInventario.Columns[e.ColumnIndex].Name == "Editar" || dgvInventario.Columns[e.ColumnIndex].HeaderText == "Editar")
            {
                // Obtenemos el nombre o ID del producto de esa fila
                string idProductoSeleccionado = dgvInventario.Rows[e.RowIndex].Cells["Producto"].Value.ToString();

                // LLAMAMOS AL MÉTODO DE ARRIBA
                AbrirEditarProductoLateral(idProductoSeleccionado);
            }
        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            // 1. Creamos y mostramos el fondo oscuro estirado sobre todo el FrmInventario2
            Form_FondoOscuro fondo = new Form_FondoOscuro();
            fondo.StartPosition = FormStartPosition.Manual;
            fondo.Bounds = this.Bounds;
            fondo.Show(this); // Bloquea visualmente el formulario actual

            // 2. Ventana flotante limpia que contendrá el panel lateral
            Form ventanaContenedor = new Form();
            ventanaContenedor.FormBorderStyle = FormBorderStyle.None;

            // Puedes ajustar el ancho (480) y el alto (this.Height) según necesites
            ventanaContenedor.Size = new Size(480, this.Height);
            ventanaContenedor.StartPosition = FormStartPosition.Manual;

            // --- CORRECCIÓN: ALINEACIÓN DERECHA ---
            // Posición X = Coordenada X del formulario principal + Ancho total del formulario principal - Ancho de la ventana lateral
            ventanaContenedor.Location = new Point(this.Location.X + this.Width - 480, this.Location.Y);
            ventanaContenedor.ShowInTaskbar = false;

            // 3. Instanciamos tu User Control de Agregar Producto
            ucAgregarProducto panelProducto = new ucAgregarProducto();
            panelProducto.Dock = DockStyle.Fill;

            // Añadimos el User Control a la ventana flotante
            ventanaContenedor.Controls.Add(panelProducto);

            // 4. Se muestra como un diálogo modal usando el fondo opaco como "dueño"
            ventanaContenedor.ShowDialog(fondo);

            // 5. Al cerrar la ventana lateral, limpiamos la memoria del fondo oscuro
            fondo.Dispose();

            // Puedes agregar un método para refrescar tu Grid o lista de inventario si lo necesitas:
            // CargarInventario();
        }


    }
}

