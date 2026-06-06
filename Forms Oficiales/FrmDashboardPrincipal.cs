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

namespace IlkaPoint
{
    public partial class FrmDashboardPrincipal : Form
    {
        public FrmDashboardPrincipal()
        {
            InitializeComponent();
        }

        private void FrmDashboardPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                // Forzar que los títulos estén al frente
                lblNumTotalArt.SendToBack();
                lblNumArtAgotados.SendToBack();
                label3.SendToBack();

                RefrescarDashBoard(); //Refrescamos la info nueva :D

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un detalle al cargar las gráficas: " + ex.Message);
            }
        }

        private void FrmDashboardPrincipal_VisibleChanged(object sender, EventArgs e) //CADA QUE SE ABRA EL FORMS SE REFREZCA EL DASHBOARD
        {
            if (this.Visible)
            {
                RefrescarDashBoard();
            }
        }
        private void lblTituloMenuDp_Click(object sender, EventArgs e)
        {

        }

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

        private void menuLateral_SelectChanged(object sender, AntdUI.MenuSelectEventArgs e)
        {

        }

        private void btnInicioMenu_Click(object sender, EventArgs e)
        {

        }

        private void panelTotalArticulos_Click(object sender, EventArgs e)
        {

        }

        private void lblNumTotalArt_Click(object sender, EventArgs e)
        {

        }

        private void lblArticulosAgotados_Click(object sender, EventArgs e)
        {

        }

        private void flopTarjetasTop_Click(object sender, EventArgs e)
        {

        }

        private void panelFondoDP_Click(object sender, EventArgs e)
        {

        }

        private void btnInventarioMenu_Click(object sender, EventArgs e)
        {

        }

        private void btnVentasMenu_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrarSesionMenu_Click(object sender, EventArgs e)
        {

        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            //ACA ES TEMPORAL, CUANDO PUEDAN VISUAL CAMBIENLO <<<<<<IMPORTANTE>>>>>>>>
            this.Hide();
            FrmInventario2 inventario = new FrmInventario2();
            inventario.Show();
        }
    }
}
