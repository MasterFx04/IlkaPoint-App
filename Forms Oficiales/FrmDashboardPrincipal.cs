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
using System.Windows.Media;

namespace IlkaPoint
{
    public partial class FrmDashboardPrincipal : Form
    {
        //DISEÑO CÓDIGO (LÍNEA 17)
        // Paleta de colores para la sombra del menú
        public static readonly System.Drawing.Color AzulFondo = System.Drawing.ColorTranslator.FromHtml("#1A3560");
        public FrmDashboardPrincipal()
        {
            InitializeComponent();
        }

        private void FrmDashboardPrincipal_Load(object sender, EventArgs e)
        {
            // Llamamos al método para aplicar los íconos a los botones de este formulario
            InicializarIconosMenu();

            try
            {
                //DISEÑO CÓDIGO (LÍNEA 26 a 39)

                // Forzar que los títulos estén al frente
                /*
                lblNumTotalArt.SendToBack();
                lblNumArtAgotados.SendToBack();
                label3.SendToBack();
                */
                /*
                lblTotalDeArticulos.BringToFront();
                lblNumArtAgotados.BringToFront();
                label3.BringToFront();
                */

                lblNumTotalArt.BringToFront();
                lblNumArtAgotados.BringToFront();

                /*
                // === 1. GRÁFICA DE TENDENCIA (Barras Horizontales) ===
                chartTendencia.Series.Clear();
                chartTendencia.Titles.Clear();
                */

                // 1. Esquinas redondeadas para la gráfica de Tendencia
                chartTendencia.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Raised;
                // Opcional: Cambia el color de la pequeña línea del borde para que sea sutil
                chartTendencia.BorderSkin.PageColor = System.Drawing.Color.Transparent;
                chartTendencia.BorderSkin.BackColor = System.Drawing.ColorTranslator.FromHtml("#1A3560");

                /*
                // Añadimos el título oficial directamente en el componente para que no necesites Labels flojos
                chartTendencia.Titles.Add("Tendencia de Stock por Producto");

                var serieBarras = chartTendencia.Series.Add("Cantidad");
                serieBarras.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;


                //CÓDIGO DATO DE PRUEBA, EN TU CASO AQUÍ DEBERÍAS CONECTAR A TU BASE DE DATOS
                //Y OBTENER LOS VALORES REALES PARA CADA PRODUCTO
                //(LÍNEA 46 A 50)

                // Inyectamos los datos duros de prueba
                serieBarras.Points.AddXY("Jabón Palmolive", 900);
                serieBarras.Points.AddXY("Agua Cristal 1.5L", 180);
                serieBarras.Points.AddXY("Coca-Cola 2L", 100);
                serieBarras.Points.AddXY("Leche Estrella 1L", 150);
                serieBarras.Points.AddXY("Arroz Gold 5lb", 120);


                //DISEÑO CÓDIGO (LÍNEA 54 A 61)

                // === 2. GRÁFICA DE CATEGORÍAS (Dona) ===
                chartCategorias.Series.Clear();
                chartCategorias.Titles.Clear();
                */

                // 2. Esquinas redondeadas para la gráfica de Categorías (Dona)
                chartCategorias.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Raised;
                chartCategorias.BorderSkin.PageColor = System.Drawing.Color.Transparent;
                chartCategorias.BorderSkin.BackColor = System.Drawing.ColorTranslator.FromHtml("#1A3560");

                /*
                chartCategorias.Titles.Add("Distribución por Categorías");

                var serieDona = chartCategorias.Series.Add("Categorias");
                serieDona.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;


                //CÓDIGO DATO DE PRUEBA, EN TU CASO AQUÍ DEBERÍAS CONECTAR A TU BASE DE DATOS
                //Y OBTENER LOS VALORES REALES PARA CADA CATEGORÍA
                //(LÍNEA 67 A 70)
                serieDona.Points.AddXY("Abarrotería (34%)", 34);
                serieDona.Points.AddXY("Lácteos (10%)", 10);
                serieDona.Points.AddXY("Bebidas (36%)", 36);
                serieDona.Points.AddXY("Limpieza (20%)", 20);


                //DISEÑO CÓDIGO (LÍNEA 74 A 77)

                // === EL TRUCO MAGISTRAL ===
                // Esto obliga a Windows Forms a redibujar los controles con los nuevos datos en
                // el segundo uno. Sin esto, a veces no se actualizan correctamente al cargar el
                // formulario.
                //Igual pueden ver si necesitan modificarlo pero si funciona bien, es mejor
                //dejarlo así para evitar problemas de actualización visual.
                chartTendencia.DataBind();
                chartCategorias.DataBind();

                // === 3. TABLA DE INVENTARIO RÁPIDO (Datos de Prueba) ===
                // Creamos la estructura de la tabla con las columnas de tu Figma
                DataTable dt = new DataTable();
                dt.Columns.Add("Código", typeof(string));
                dt.Columns.Add("Producto", typeof(string));
                dt.Columns.Add("Categoría", typeof(string));
                dt.Columns.Add("Precio Venta", typeof(string));
                dt.Columns.Add("Existencia", typeof(int));
                dt.Columns.Add("Estado", typeof(string));


                //DATO DE PRUEBA, EN TU CASO AQUÍ DEBERÍAS CONECTAR A TU BASE DE DATOS
                // Y OBTENER LOS VALORES REALES PARA CADA PRODUCTO CON STOCK BAJO O CRÍTICO
                // (LÍNEA 94 A 99)

                // Agregamos filas de simulación con stock bajo o crítico
                dt.Rows.Add("P001", "Jabón Palmolive", "Limpieza", "$1.25", 5, "Crítico");
                dt.Rows.Add("P002", "Agua Cristal 1.5L", "Bebidas", "$0.80", 12, "Bajo Stock");
                dt.Rows.Add("P003", "Coca-Cola 2L", "Bebidas", "$2.10", 3, "Crítico");
                dt.Rows.Add("P004", "Leche Estrella 1L", "Lácteos", "$1.50", 8, "Bajo Stock");
                dt.Rows.Add("P005", "Arroz Gold 5lb", "Abarrotería", "$4.25", 15, "Bajo Stock");


                //DISEÑO CÓDIGO (LÍNEA 109 A 115)
                //Este conecta los datos a tu DataGridView, y automáticamente se encarga
                //de mostrar las filas con su formato correspondiente.
                //Ustedes solo necesitan asegurarse de que el DataGridView tenga las columnas configuradas
                //con los mismos nombres que las del DataTable para que se muestren correctamente.

                // Conectamos los datos al control visual
                dgvInventarioRapido.DataSource = dt;
                */

                //CONECTANDO A LA BASE DE DATOS:
                RefrescarDashBoard(); //Refrescamos la info nueva :D
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un detalle al cargar las gráficas: " + ex.Message);
            }
        }


        //DISEÑO CÓDIGO (LÍNEA 129 A 175)
        // Este método se encarga de asignar tus íconos personalizados a los botones del menú lateral.
        private void InicializarIconosMenu()
        {
            int tamanoIcono = 32;

            // Función interna para redimensionar las imágenes de tus recursos
            Image RedimensionarImagen(Image img, int ancho, int alto)
            {
                if (img == null) return null;
                return new Bitmap(img, new Size(ancho, alto));
            }

            // Lista de los botones de tu menú en el Dashboard
            // (Asegúrate de que estos nombres coincidan con los Name de tus botones de diseño)
            Button[] botonesMenu = { btnInicio, btnInventario, btnVentas, btnAyuda, btnCerrarsesion };

            foreach (Button b in botonesMenu)
            {
                if (b == null) continue;

                // Configuración estética de alineación (Texto al lado del ícono)
                b.UseVisualStyleBackColor = false;
                b.FlatStyle = FlatStyle.Flat;
                b.FlatAppearance.BorderSize = 0;
                b.ImageAlign = ContentAlignment.MiddleLeft;
                b.TextAlign = ContentAlignment.MiddleLeft;
                b.TextImageRelation = TextImageRelation.ImageBeforeText;
                b.Padding = new Padding(15, 0, 0, 0);

                // Si por error se usó un IconButton de FontAwesome, apagamos el vector para usar tu PNG
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

        //DISEÑO CÓDIGO (LÍNEA 186 A 222)
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
       

        private void btnInventario_Click(object sender, EventArgs e)
        {
            FrmInventario2 pantallaInventario = new FrmInventario2();
            pantallaInventario.Show();
            this.Hide();

            /* ActualizarMenuActivo(btnInventario);
             // Tu código para abrir FrmInventario2 si estás en otra pantalla...
             //ACA ES TEMPORAL, CUANDO PUEDAN VISUAL CAMBIENLO <<<<<<IMPORTANTE>>>>>>>>
             this.Hide();
             FrmInventario2 inventario = new FrmInventario2();
             inventario.Show();*/


        }

        private void btnVentas_Click_1(object sender, EventArgs e)
        {
            Form1v2 pantallaVentas = new Form1v2();
            pantallaVentas.Show();
            this.Hide();
        }



        private void btnAyuda_Click(object sender, EventArgs e)
        {
            ActualizarMenuActivo(btnAyuda);
        }

        
            
        

        private void FrmDashboardPrincipal_VisibleChanged(object sender, EventArgs e) //CADA QUE SE ABRA EL FORMS SE REFREZCA EL DASHBOARD
        {
            if (this.Visible)
            {
                RefrescarDashBoard();
            }
        }
        /*
        private void lblTituloMenuDp_Click(object sender, EventArgs e)
        {

        }
        */

        public void RefrescarDashBoard() //CADA VEZ QUE ALGUIEN HAGA UN CAMBIO O ALGO LLAMARA A ESTA FUNCION
        {
            //REFERENCIA A LA DB
            ServicioInventario servicio = new ServicioInventario();
            List<Stock> stocks = servicio.ObtenerElStockActual();

            // === 1. GRÁFICA DE TENDENCIA (Barras Horizontales) ===
            chartTendencia.Series.Clear();
            chartTendencia.Titles.Clear();

            // Añadimos el título oficial directamente en el componente para que no necesites Labels flojos
            chartTendencia.Titles.Add("Tendencia de Stock por Producto");
            var serieBarras = chartTendencia.Series.Add("Cantidad");
            serieBarras.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;

            

            /* Inyectamos los datos duros de prueba <<<<<<ANTES>>>>>>>
            serieBarras.Points.AddXY("Jabón Palmolive", 900);
            serieBarras.Points.AddXY("Agua Cristal 1.5L", 180);
            serieBarras.Points.AddXY("Coca-Cola 2L", 100);
            serieBarras.Points.AddXY("Leche Estrella 1L", 150);
            serieBarras.Points.AddXY("Arroz Gold 5lb", 120);
            */

            // <<<<<AHORA>>>>>>
            foreach (Stock stock in stocks)
            {
                serieBarras.Points.AddXY(stock.productoNombre, stock.Cantidad);
            }


            // === 2. GRÁFICA DE CATEGORÍAS (Dona) ===
            chartCategorias.Series.Clear();
            chartCategorias.Titles.Clear();
            chartCategorias.Titles.Add("Distribución por Categorías");

            var serieDona = chartCategorias.Series.Add("Categorias");
            serieDona.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;

            /* <<<<<<ANTES>>>>>>>>>>
            serieDona.Points.AddXY("Abarrotería (34%)", 34);
            serieDona.Points.AddXY("Lácteos (10%)", 10);
            serieDona.Points.AddXY("Bebidas (36%)", 36);
            serieDona.Points.AddXY("Limpieza (20%)", 20);
            */
            //<<<<<<<AHORA>>>>>>>>
            Dictionary<string, int> categorias = servicio.ObtenerProductosPorCategoria();
            int totalProductos = categorias.Values.Sum();

            foreach (var categoria in categorias)
            {
                int porcentaje = (int)Math.Round(((double)categoria.Value / totalProductos) * 100);
                serieDona.Points.AddXY($"{categoria.Key} ({porcentaje}%)", categoria.Value);

            }

            // === EL TRUCO MAGISTRAL ===
            // Esto obliga a Windows Forms a redibujar los controles con los nuevos datos en el segundo uno
            chartTendencia.DataBind();
            chartCategorias.DataBind();

            // === 3. TABLA DE INVENTARIO RÁPIDO (Datos de Prueba) ===
            // Creamos la estructura de la tabla con las columnas de tu Figma
            DataTable dt = new DataTable();
            dt.Columns.Add("Código", typeof(string));
            dt.Columns.Add("Producto", typeof(string));
            dt.Columns.Add("Categoría", typeof(string));
            dt.Columns.Add("Precio Venta", typeof(string));
            dt.Columns.Add("Existencia", typeof(int));
            dt.Columns.Add("Estado", typeof(string));

            /* Agregamos filas de simulación con stock bajo o crítico <<<<<<ANTES>>>>>>>>>>
            dt.Rows.Add("P001", "Jabón Palmolive", "Limpieza", "$1.25", 5, "Crítico");
            dt.Rows.Add("P002", "Agua Cristal 1.5L", "Bebidas", "$0.80", 12, "Bajo Stock");
            dt.Rows.Add("P003", "Coca-Cola 2L", "Bebidas", "$2.10", 3, "Crítico");
            dt.Rows.Add("P004", "Leche Estrella 1L", "Lácteos", "$1.50", 8, "Bajo Stock");
            dt.Rows.Add("P005", "Arroz Gold 5lb", "Abarrotería", "$4.25", 15, "Bajo Stock");
            */

            //<<<<AHORA>>>>>>>>
            foreach (Stock stock  in stocks)
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
                    estado = "Stock Estable";
                }
                else
                {
                    estado = "No definido";
                }

                //Agregamos los Datos a la tabla
                dt.Rows.Add(
                    stock.Id.ToString("D4"),
                    stock.productoNombre,
                    producto.categoria,
                    "$" + producto.precio.ToString("F2"),
                    stock.Cantidad,
                    estado
                    );
            }

            // Conectamos los datos al control visual
            dgvInventarioRapido.DataSource = dt;

            //Ahora los textos de la parte de Arriba
            lblNumTotalArt.Text = servicio.ObtenerTotalArticulos().ToString();
            lblNumArtAgotados.Text = servicio.ObtenerStocksAgotados().ToString();
            label3.Text = servicio.ObtenerStocksBajos().ToString();
        }



        private void panelFondoDP_Click(object sender, EventArgs e)
        {

        }

        
       

        private void chartTendencia_Click(object sender, EventArgs e)
        {

        }

       
    }
}
