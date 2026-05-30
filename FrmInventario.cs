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
    public partial class FrmInventario : Form
    {
        public FrmInventario()
        {
            InitializeComponent();
            // 1. Limpiar columnas por si acaso
            tableInventario.Columns.Clear();

            // 2. Agregar las columnas basándonos en tu Figma
            tableInventario.Columns.Add(new AntdUI.Column("Categoria", "Categoría") { Width = "15%" });
            tableInventario.Columns.Add(new AntdUI.Column("Producto", "Producto") { Width = "40%" });
            tableInventario.Columns.Add(new AntdUI.Column("Stock", "Stock") { Width = "15%" });
            tableInventario.Columns.Add(new AntdUI.Column("EstadoStock", "Estado de Stock") { Width = "15%" });
            tableInventario.Columns.Add(new AntdUI.Column("Accion", "Acción") { Width = "15%" });



            // 2. Obligar a las columnas a ocupar el 100% del espacio disponible
            tableInventario.RowHeight = 40; // Le da un aire limpio a las filas como tu Figma

            // 3. Forzar el redibujado inmediato al cambiar el tamaño de la pantalla
            this.SizeChanged += (s, e) => {
                tableInventario.Width = panelCentralTabla.Width;
                tableInventario.Invalidate();
            };

            //LLenar la tabla con datos de ejemplo (Mockup)
            // 1. Crear la lista con los productos reales de tu diseño
            var listaProductos = new List<ProductoInventario>
{
    new ProductoInventario("Abarrotes", "Arroz Gold Special 5lb", 120, "Abundante"),
    new ProductoInventario("Abarrotes", "Aceite Vegetal Gourmet 1L", 45, "Abundante"),
    new ProductoInventario("Abarrotes", "Porotos Chiricanos 400g", 85, "Abundante"),
    new ProductoInventario("Abarrotes", "Café Durán Tradicional 425g", 8, "Bajo Stock"),
    new ProductoInventario("Abarrotes", "Azúcar Sulfitada 2kg", 0, "Agotado"),
    new ProductoInventario("Lácteos", "Leche Entera Estrella 1L", 140, "Abundante")
};

            // 2. Asignar la lista a la tabla (En AntdUI se usa DataSource)
            tableInventario.DataSource = listaProductos;

           
        }

        private void inputBuscador_TextChanged(object sender, EventArgs e)
        {

        }


        //Datos de ejemplo para poblar la tabla (Mockup)
        public class ProductoInventario
        {
            public string Categoria { get; set; }
            public string Producto { get; set; }
            public int Stock { get; set; }
            public string EstadoStock { get; set; }
            public string Accion { get; set; } // Esto reservará el espacio para los iconos

            public ProductoInventario(string cat, string prod, int stock, string estado)
            {
                Categoria = cat;
                Producto = prod;
                Stock = stock;
                EstadoStock = estado;
                Accion = "";
            }
        }
    }
}