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

                // === 1. GRÁFICA DE TENDENCIA (Barras Horizontales) ===
                chartTendencia.Series.Clear();
                chartTendencia.Titles.Clear();

                // Añadimos el título oficial directamente en el componente para que no necesites Labels flojos
                chartTendencia.Titles.Add("Tendencia de Stock por Producto");

                var serieBarras = chartTendencia.Series.Add("Cantidad");
                serieBarras.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;

                // Inyectamos los datos duros de prueba
                serieBarras.Points.AddXY("Jabón Palmolive", 900);
                serieBarras.Points.AddXY("Agua Cristal 1.5L", 180);
                serieBarras.Points.AddXY("Coca-Cola 2L", 100);
                serieBarras.Points.AddXY("Leche Estrella 1L", 150);
                serieBarras.Points.AddXY("Arroz Gold 5lb", 120);

                // === 2. GRÁFICA DE CATEGORÍAS (Dona) ===
                chartCategorias.Series.Clear();
                chartCategorias.Titles.Clear();

                chartCategorias.Titles.Add("Distribución por Categorías");

                var serieDona = chartCategorias.Series.Add("Categorias");
                serieDona.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;

                serieDona.Points.AddXY("Abarrotería (34%)", 34);
                serieDona.Points.AddXY("Lácteos (10%)", 10);
                serieDona.Points.AddXY("Bebidas (36%)", 36);
                serieDona.Points.AddXY("Limpieza (20%)", 20);

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

                // Agregamos filas de simulación con stock bajo o crítico
                dt.Rows.Add("P001", "Jabón Palmolive", "Limpieza", "$1.25", 5, "Crítico");
                dt.Rows.Add("P002", "Agua Cristal 1.5L", "Bebidas", "$0.80", 12, "Bajo Stock");
                dt.Rows.Add("P003", "Coca-Cola 2L", "Bebidas", "$2.10", 3, "Crítico");
                dt.Rows.Add("P004", "Leche Estrella 1L", "Lácteos", "$1.50", 8, "Bajo Stock");
                dt.Rows.Add("P005", "Arroz Gold 5lb", "Abarrotería", "$4.25", 15, "Bajo Stock");

                // Conectamos los datos al control visual
                dgvInventarioRapido.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un detalle al cargar las gráficas: " + ex.Message);
            }
        }
        private void lblTituloMenuDp_Click(object sender, EventArgs e)
        {

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
    }
}
