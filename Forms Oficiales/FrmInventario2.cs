using AntdUI;
using IlkaPoint.Clases;
using IlkaPoint.Data.Modelos;
using IlkaPoint.Forms_Oficiales;
using IlkaPoint.FormsPrueba;
using IlkaPoint.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IlkaPoint
{
    public partial class FrmInventario2 : Form
    {
        

        //DISEÑO CÓDIGO (LÍNEA 21)
        // Paleta de colores para la sombra del menú
        public static readonly System.Drawing.Color AzulFondo = System.Drawing.ColorTranslator.FromHtml("#1A3560");
        public static readonly Color BlancoTexto = ColorTranslator.FromHtml("#FFFFFF"); // Texto
        public static readonly Color AzulMenu = ColorTranslator.FromHtml("#08243B");   // Color del menú izquierdo
        public static readonly Color AzulClaroTarjetas = ColorTranslator.FromHtml("#3059B6");
        public FrmInventario2()
        {
            InitializeComponent();
            this.ClientSize = new System.Drawing.Size(1440, 1024);

            // === CONGELAR EL TAMAÑO ESTÁNDAR ===
            this.Size = new Size(1440, 1024); // Pon aquí los pixeles exactos de tu Figma
            this.MinimumSize = new Size(1024, 768); // Evita que la hagan más chica

            // Asociamos el evento Load del formulario a nuestro método personalizado
            // Esto asegura que cuando el formulario se cargue,
            // se ejecute el código dentro de FrmInventario_Load
            this.Load += FrmInventario_Load;
        }
        


        private void FrmInventario_Load(object sender, EventArgs e)
        {
            //DISEÑO CÓDIGO (LÍNEA 32 a 35)
            dgvInventario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvInventario.Dock = DockStyle.Fill;
            dgvInventario.EnableHeadersVisualStyles = false;
            //Para que se muestre el color y los datos lleguen a la columna completa.
            CargarDatos();
            // Llamamos al método para aplicar los íconos a los botones de esta pantalla
            InicializarIconosMenu();
            ActualizarMenuActivo(btnInventario);
        }

        //DATOS DE PRUEBA
        //Creado con Datos de Prueba, en tu caso aquí deberías conectar a tu base de datos
        //(Línea 42 a 64)
        //<<<< CONECTANDO LA BASE DE DATOS....>>>>>>>
        private void CargarDatos()
        {
            ServicioInventario servicio = new ServicioInventario();
            List<Stock> stocks = servicio.ObtenerElStockActual();

            dgvInventario.Rows.Clear();

            /*
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
            */


            foreach (Stock stock in stocks)
            {
                Producto producto = servicio.BuscarProductoPorId(stock.ProductoId);

                //Describimos el estado del producto
                string estado;
                if (stock.Cantidad <= 5 && stock.Cantidad > 0)
                {
                    estado = "Critico";
                }
                else if (stock.Cantidad > 5 && stock.Cantidad <= 15)
                {
                    estado = "Bajo Stock";
                }
                else if (stock.Cantidad > 15)
                {
                    estado = "Abundante";
                }
                else
                {
                    estado = "No definido";
                }

                // 1. Agregamos los datos visuales y guardamos el índice de la fila que se acaba de crear
                int indiceFila = dgvInventario.Rows.Add(
                    producto.categoria,
                    producto.nombre,
                    stock.Cantidad,
                    estado
                );

                // 2. Metemos el objeto 'stock' completito en el "bolsillo" (Tag) de esa fila
                dgvInventario.Rows[indiceFila].Tag = stock;
            }
        }

        //DISEÑO CÓDIGO
        // Este método se encarga de abrir la ventana lateral para editar un producto específico.
        //(LÍNEA 70 A 98)
        private void AbrirEditarProductoLateral(Stock stock)
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
            ucEditarProducto panelEditar = new ucEditarProducto(stock);
            panelEditar.Dock = DockStyle.Fill;

            // Aquí le pasas el ID al control si tienes un método interno para cargar los datos
            // panelEditar.CargarDatos(idProducto);

            ventanaContenedor.Controls.Add(panelEditar);

            // 4. Mostrar y limpiar
            ventanaContenedor.ShowDialog(fondo);
            fondo.Dispose();
            CargarDatos();
        }

        //DISEÑO CÓDIGO (LÍNEA 105 A 126)
        // Este método se encarga de colorear las filas del DataGridView según el estado del producto.
        //En caso de modificarlo deben asegurarse de que el índice de la columna "Estado"
        //siga siendo el 3, o cambiarlo por el índice correcto.
        //Mi recomedación es que lo dejen así sin modificar el código de la tabla, solo conectar los datos,
        //pero si necesitan modificarlo,solo asegúrense de actualizar el número del índice.
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

        //DATOS DE PRUEBA
        //Aquí se implementa la función de búsqueda para filtrar los productos en el DataGridView..
        //Conectenlo como ustedes cinsideren, pero lo importante es que el TextBox txtBuscarProducto
        //tenga el evento Click asociado a este método.

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            /* <<<<<ANTES>>>>>>
            foreach (DataGridViewRow fila in dgvInventario.Rows)
            {
                fila.Visible = fila.Cells[1]
                    .Value.ToString()
                    .ToLower()
                    .Contains(txtBuscarProducto.Text.ToLower());
            }
            <<<<<<<<<<<<<<<<<<<<<<<<<<<<<BUSCAR LA FUNCION TXTBUSCARPRODUCTOCHANGED>>>>>>>>>>>>>>>>>>>>>>>> 
            */

        }


        //DISEÑO CÓDIGO (LÍNEA 155 A 189)
        // Este método se encarga de manejar los clics en las celdas del DataGridView,
        // específicamente para las acciones de editar y eliminar.
        //Asegúrense de que las columnas de editar y eliminar tengan los nombres
        //"colEditar" y "colEliminar" respectivamente, en caso de que necesiten modificarlo.
        //En el caso de editar, se llama al método AbrirEditarProductoLateral para mostrar la ventana lateral de edición.
        //Si llegan a modificar en nombre de las columnas, asegúrense de actualizarlo también en el
        //método AbrirEditarProductoLateral para que se muestre la ventana lateral al hacer clic en editar.
        //Mi recomendación es que no toquen esos nombres para evitar problemas de conexión entre los métodos
        //ni que modifiquen el código de la tabla, solo conectar los datos.
        private void dgvInventario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // evita clic en el header

            if (dgvInventario.Columns[e.ColumnIndex].Name == "colEditar")
            {
                MessageBox.Show("Ingrese los datos actuales del producto a editar");
                // aquí va tu lógica de editarId);
                CargarDatos();
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
                    //dgvInventario.Rows.RemoveAt(e.RowIndex); <<<<<<<<<<<<<<ELIMINANDO EL STOCK EN LA DB>>>>>>>>>>>
                    Stock stockSeleccionado = (Stock)dgvInventario.Rows[e.RowIndex].Tag;
                    ServicioInventario inventario = new ServicioInventario();
                    inventario.EliminarProducto(stockSeleccionado.ProductoId);
                    CargarDatos();

                }
            }
            if (e.RowIndex < 0) return;

            // Si hicieron clic en la columna llamada "Editar"
            if (dgvInventario.Columns[e.ColumnIndex].Name == "Editar" || dgvInventario.Columns[e.ColumnIndex].HeaderText == "Editar")
            {
                // Obtenemos el nombre o ID del producto de esa fila
                string idProductoSeleccionado = dgvInventario.Rows[e.RowIndex].Cells["Producto"].Value.ToString();

                // LLAMAMOS AL MÉTODO DE ARRIBA
                ServicioInventario servicio = new ServicioInventario();
                Stock stockSeleccionado = (Stock)dgvInventario.Rows[e.RowIndex].Tag;
                AbrirEditarProductoLateral(stockSeleccionado);
            }
        }

        //Este evento se abrió por error mientras diseñaba el formulario,
        //pueden borrarlo porque no se utiliza.
        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        //DISEÑO CÓDIGO (LÍNEA 202 A 238)
        // Este método se encarga de abrir la ventana lateral para agregar un nuevo producto.
        //No lo toquen porque aquí se genera el fondo opaco y la ventana lateral
        //con el User Control de agregar producto.
        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            btnAgregarProducto.BackColor = AzulClaroTarjetas;
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
            CargarDatos();
        }


        private void InicializarIconosMenu()
        {
            int tamanoIcono = 32;

            Image RedimensionarImagen(Image img, int ancho, int alto)
            {
                if (img == null) return null;
                return new Bitmap(img, new Size(ancho, alto));
            }

            // --- SOLUCIÓNaquí: Especificamos explícitamente System.Windows.Forms.Button ---
            System.Windows.Forms.Button[] botonesMenu = { btnInicio, btnInventario, btnVentas, btnAyuda, btnCerrarsesion };

            foreach (System.Windows.Forms.Button b in botonesMenu)
            {
                if (b == null) continue;

                // Alineación estética
                b.UseVisualStyleBackColor = false;
                b.FlatStyle = FlatStyle.Flat;
                b.FlatAppearance.BorderSize = 0;
                b.ImageAlign = ContentAlignment.MiddleLeft;
                b.TextAlign = ContentAlignment.MiddleLeft;
                b.TextImageRelation = TextImageRelation.ImageBeforeText;
                b.Padding = new Padding(15, 0, 0, 0);

                if (b is FontAwesome.Sharp.IconButton iconBtn)
                {
                    iconBtn.IconChar = FontAwesome.Sharp.IconChar.None;
                }

                // Asignación de tus imágenes desde Properties.Resources
                if (b == btnInicio)
                    b.Image = RedimensionarImagen(Properties.Resources.homeimg, tamanoIcono, tamanoIcono);
                else if (b == btnInventario)
                    b.Image = RedimensionarImagen(Properties.Resources.inventoryimg, tamanoIcono, tamanoIcono);
                else if (b == btnVentas)
                    b.Image = RedimensionarImagen(Properties.Resources.salesimg, tamanoIcono, tamanoIcono);
                else if (b == btnAyuda)
                    b.Image = RedimensionarImagen(Properties.Resources.helpimg, tamanoIcono, tamanoIcono);
                else if (b == btnCerrarsesion)
                    b.Image = RedimensionarImagen(Properties.Resources.logoutimg, tamanoIcono, tamanoIcono);
            }
        }

        //DISEÑO CÓDIGO (LÍNEA 297 A 322)
        // Este método se encarga de actualizar el estado visual del menú lateral para reflejar
        // qué sección está activa.
        //Para generar como un sombreado de diferenciación en el fondo del botón seleccionado.
        // Lógica de Navegación de Pestañas (Adaptada sin ambigüedad)
        private void ActualizarMenuActivo(System.Windows.Forms.Button botonSeleccionado)
        {
            if (botonSeleccionado == null) return;

            // Ponemos todos los botones con fondo transparente (Apagados)
            if (btnInicio != null) btnInicio.BackColor = System.Drawing.Color.Transparent;
            if (btnInventario != null) btnInventario.BackColor = System.Drawing.Color.Transparent;
            if (btnVentas != null) btnVentas.BackColor = System.Drawing.Color.Transparent;
            if (btnAyuda != null) btnAyuda.BackColor = System.Drawing.Color.Transparent;
            if (btnCerrarsesion != null) btnCerrarsesion.BackColor = System.Drawing.Color.Transparent;
            // Iluminamos el botón seleccionado con el color del fondo
            botonSeleccionado.BackColor = AzulFondo;
        }

        // Eventos de los botones del menú
        private void btnInicio_Click(object sender, EventArgs e)
        {

            //Ir a inicio
            FrmDashboardPrincipal dashboard = new FrmDashboardPrincipal();
            if (!Application.OpenForms.OfType<FrmDashboardPrincipal>().Any())
            {
                dashboard = new FrmDashboardPrincipal();
            }
            else
            {
                dashboard = Application.OpenForms.OfType<FrmDashboardPrincipal>().FirstOrDefault();
            }
            
            this.Hide();
            dashboard.Show();


        }

        private void btnInventario_Click(object sender, EventArgs e)
        {

        }
        
        private void btnVentas_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            string nombreArchivo = "Guia_de_Usuario_IlcaPoint.pdf";

            // 2. Combinamos la ruta de ejecución con el nombre del archivo
            // AppDomain.CurrentDomain.BaseDirectory apunta a la carpeta /bin/Debug o /bin/Release
            string rutaPdf = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, nombreArchivo);

            if (File.Exists(rutaPdf))
            {
                Process.Start(rutaPdf);
            }
            else
            {
                MessageBox.Show("No se encontró el archivo en: " + rutaPdf);
            }
        }
        

        //Este evento se abrió por error mientras diseñaba el formulario, pueden borrarlo
        //porque no se utiliza.
        private void panelEncabezado_Click(object sender, EventArgs e)
        {

        }

        private void txtBuscarProducto_TextChanged(object sender, EventArgs e)
        {
            //<<<<<<<<<<<<AHORA>>>>>>>>>>>>
            ServicioInventario servicio = new ServicioInventario();
            List<Stock> stocks = servicio.BuscarStockPorNombre(txtBuscarProducto.Text);

            dgvInventario.Rows.Clear();

            foreach (Stock stock in stocks)
            {
                Producto producto = servicio.BuscarProductoPorId(stock.ProductoId);

                //Describimos el estado del producto
                string estado;
                if (stock.Cantidad <= 5 && stock.Cantidad > 0)
                {
                    estado = "Critico";
                }
                else if (stock.Cantidad > 5 && stock.Cantidad <= 15)
                {
                    estado = "Bajo Stock";
                }
                else if (stock.Cantidad > 15)
                {
                    estado = "Abundante";
                }
                else
                {
                    estado = "No definido";
                }

                // 1. Agregamos los datos visuales y guardamos el índice de la fila que se acaba de crear
                int indiceFila = dgvInventario.Rows.Add(
                    producto.categoria,
                    producto.nombre,
                    stock.Cantidad,
                    estado
                );

                // 2. Metemos el objeto 'stock' completito en el "bolsillo" (Tag) de esa fila
                dgvInventario.Rows[indiceFila].Tag = stock;
            }
        }

        private void btnInicio_Click_1(object sender, EventArgs e)
        {
            ActualizarMenuActivo(btnInicio);
            FrmDashboardPrincipal dashboard = Application.OpenForms.OfType<FrmDashboardPrincipal>().FirstOrDefault();
            // FrmDashboardPrincipal dashboard = new FrmDashboardPrincipal();
            this.Hide();
            dashboard?.RefrescarDashBoard();
            dashboard?.Show();


        }

        private void btnVentas_Click_1(object sender, EventArgs e)
        {
            ActualizarMenuActivo(btnVentas);
            Form1v2 frmVentas;
            if (!Application.OpenForms.OfType<Form1v2>().Any())
            {
                frmVentas = new Form1v2();
            }
            else
            {
                frmVentas = Application.OpenForms.OfType<Form1v2>().FirstOrDefault();
            }
            this.Hide();
            frmVentas.Show();
        }

        private void btnCerrarsesion_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void panelMenu_Paint_1(object sender, PaintEventArgs e)
        {
            this.BackColor = Color.FromArgb(8, 36, 59);
        }
    }
}

