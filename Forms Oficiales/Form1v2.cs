using FontAwesome.Sharp;
using IlkaPoint.Clases;
using IlkaPoint.Data.Modelos;
using IlkaPoint.Forms_Oficiales;
using IlkaPoint.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization; // Necesario para formato de fecha XX-XX-XXXX
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IlkaPoint
{
    public partial class Form1v2 : Form
    {
        // Paleta de Colores Estética
        public static readonly Color AzulFondo = ColorTranslator.FromHtml("#1A3560");         // Fondo de la pantalla principal
        public static readonly Color AzulClaroTarjetas = ColorTranslator.FromHtml("#3059B6"); // Botones "Ver Factura"
        public static readonly Color BlancoTexto = ColorTranslator.FromHtml("#FFFFFF");       // Textos legibles
        public static readonly Color AzulMenu = ColorTranslator.FromHtml("#08243B");          // Menú lateral izquierdo

        public class ItemVendido
        {
            public string Nombre { get; set; }
            public int Cantidad { get; set; }
            public decimal Precio { get; set; }
            public decimal Subtotal => Cantidad * Precio;
        }

        /*
        public class RegistroVenta
        {
            public string IdVenta { get; set; }
            public string MetodoPago { get; set; }
            public string Fecha { get; set; }
            public List<ItemVendido> Productos { get; set; } = new List<ItemVendido>();
            public int TotalArticulos { get; set; }
            public decimal MontoTotal { get; set; }
        }
        */

        // Base de datos Simulada
        //public static List<RegistroVenta> BaseDatosVentas = new List<RegistroVenta>();
        // Base de Datos REAL
        public static List<TransaccionService> BaseDatosVentas = new List<TransaccionService>();
        

        public void CargarHistorialVentas()
        {
            TransaccionService serviceTransaccion = new TransaccionService();
            List<Transaccion> Transacciones = serviceTransaccion.ObtenerTodasLasTransacciones();

            if (panelContenido == null) return;

            panelContenido.Controls.Clear();

            // Recorre lista central para crear tarjetas de ventas
            foreach (Transaccion venta in Transacciones)
            {
                // Instancia de tarjeta de ventas real
                Tarjeta_de_Ventas tarjeta = new Tarjeta_de_Ventas();

                // Método para rellenar los textos de la tarjeta
                tarjeta.CargarDatos(venta.idTransaccion.ToString("D4"), venta.Fecha.ToString("dd-MM-yyyy"), venta.MetodoPago, (double)venta.Total);

                tarjeta.btnVerFactura.Click += (sender, e) => {

                    // Convertimos los productos de la venta al formato dinámico que espera el control 'VerFactura'
                    //List<dynamic> listaDynamic = new List<dynamic>();
                    List<DetallesTransaccion> detalles = venta.Detalles ?? new List<DetallesTransaccion>();

                    Form_FondoOscuro fondo = new Form_FondoOscuro();
                    fondo.StartPosition = FormStartPosition.Manual;
                    fondo.Bounds = this.Bounds;
                    fondo.Show(this);

                    Form ventanaContenedor = new Form();
                    ventanaContenedor.FormBorderStyle = FormBorderStyle.None;
                    ventanaContenedor.Size = new Size(480, 1024);
                    ventanaContenedor.StartPosition = FormStartPosition.Manual;
                    ventanaContenedor.Location = new Point(this.Location.X + this.Width - 480, this.Location.Y);
                    ventanaContenedor.ShowInTaskbar = false;

                    VerFactura ucFactura = new VerFactura();
                    ucFactura.Dock = DockStyle.Fill;
                    ucFactura.CargarDatosFactura(
                        "T" + venta.idTransaccion.ToString("D4"),
                        venta.MetodoPago,
                        venta.Fecha.ToString("dd-MM-yyyy"),
                        detalles,
                        detalles.Count,
                        venta.Total
                            );

                    // Inserta el diseño dentro de la ventana y lo muestra como un diálogo modal
                    ventanaContenedor.Controls.Add(ucFactura);
                    ventanaContenedor.ShowDialog(fondo);

                    // Al cerrar la ventana, limpiamos la memoria del fondo oscuro
                    fondo.Dispose();
                };

                // Agregamos la tarjeta estructurada a tu panel
                panelContenido.Controls.Add(tarjeta);
            }
        }

        public Form1v2()
        {
            InitializeComponent();
            ApplyTheme();
        }

        private void ApplyTheme()
        {
            // Fondo general del formulario
            this.BackColor = AzulFondo;
            this.ForeColor = BlancoTexto;

            // Fondos de los contenedores principales
            if (panelMenu != null) panelMenu.BackColor = AzulMenu;
            if (panelEncabezado != null) panelEncabezado.BackColor = AzulFondo;

            // Estilo por defecto transparente para los botones del menú lateral
            if (btnInicio != null) StyleMenuButton(btnInicio);
            if (btnInventario != null) StyleMenuButton(btnInventario);
            if (btnVentas != null) StyleMenuButton(btnVentas);
            if (btnAyuda != null) StyleMenuButton(btnAyuda);
            if (btnCerrarsesion != null) StyleMenuButton(btnCerrarsesion);

            // Recorrer y estilizar dinámicamente los controles hijos
            ApplyThemeRec(this);
        }

        private void StyleMenuButton(Button b)
        {
            if (b == null) return;

            // Configuración básica de botones
            b.UseVisualStyleBackColor = false;
            b.FlatStyle = FlatStyle.Flat;
            b.FlatAppearance.BorderSize = 0;
            b.ForeColor = BlancoTexto;

            if (b == btnCerrarsesion || b.Name.ToLower().Contains("cerrar"))
            {
                b.BackColor = Color.Transparent;
            }
            else
            {
                b.BackColor = Color.Transparent;
            }

            // Alineación 
            b.ImageAlign = ContentAlignment.MiddleLeft;
            b.TextAlign = ContentAlignment.MiddleLeft;
            b.TextImageRelation = TextImageRelation.ImageBeforeText;
            b.Padding = new Padding(15, 0, 0, 0);

            // Apagamos el vector por si acaso
            if (b is FontAwesome.Sharp.IconButton iconBtn)
            {
                iconBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            }

            Image RedimensionarImagen(Image img, int ancho, int alto)
            {
                if (img == null) return null;
                return new Bitmap(img, new Size(ancho, alto));
            }

            int tamanoIcono = 32;

            // Asignación imágenes a botones del menú
            if (b == btnInicio)
            {
                b.Image = RedimensionarImagen(Properties.Resources.homeimg, tamanoIcono, tamanoIcono);
            }
            else if (b == btnInventario)
            {
                b.Image = RedimensionarImagen(Properties.Resources.inventoryimg, tamanoIcono, tamanoIcono);
            }
            else if (b == btnVentas)
            {
                b.Image = RedimensionarImagen(Properties.Resources.salesimg, tamanoIcono, tamanoIcono);
            }
            else if (b == btnAyuda)
            {
                b.Image = RedimensionarImagen(Properties.Resources.helpimg, tamanoIcono, tamanoIcono);
            }
            else if (b == btnCerrarsesion)
            {
                b.Image = RedimensionarImagen(Properties.Resources.logoutimg, tamanoIcono, tamanoIcono);
            }
        }

        private void ApplyThemeRec(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                // No modificar
                if (c.Name == "flpListaProductos" || c is InfoProducto || parent is InfoProducto)
                {
                    continue;
                }

                if (c == avatarLogo || c.Name == "avatarLogo")
                {
                    if (c.HasChildren) ApplyThemeRec(c);
                    continue;
                }

                if (c is Button btn)
                {
                    btn.UseVisualStyleBackColor = false;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;

                    if (btn != btnInicio && btn != btnInventario && btn != btnVentas && btn != btnAyuda && !btn.Name.ToLower().Contains("cerrar"))
                    {
                        btn.BackColor = AzulClaroTarjetas;
                    }
                    btn.ForeColor = BlancoTexto;
                }
                else if (c is Label || c is LinkLabel)
                {
                    c.ForeColor = BlancoTexto;
                }
                else if (c is TextBox tb)
                {
                    tb.BackColor = AzulFondo;
                    tb.ForeColor = BlancoTexto;
                }
                else
                {
                    c.ForeColor = BlancoTexto;
                }

                if (c.HasChildren) ApplyThemeRec(c);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Logo redondo siempre al frente y visible
            if (avatarLogo != null) avatarLogo.BringToFront();
            ActualizarMenuActivo(btnVentas);
            if (btnNuevaVenta != null)
                btnNuevaVenta.BackColor = AzulClaroTarjetas;

            CargarHistorialVentas();
        }

        // Lógica de Navegación de Pestañas
        private void ActualizarMenuActivo(Button botonSeleccionado)
        {
            if (botonSeleccionado == null) return;

            // Botones del color del panel menú
            if (btnInicio != null) btnInicio.BackColor = Color.Transparent;
            if (btnInventario != null) btnInventario.BackColor = Color.Transparent;
            if (btnVentas != null) btnVentas.BackColor = Color.Transparent;
            if (btnAyuda != null) btnAyuda.BackColor = Color.Transparent;

            // Botón seleccionado igual al fondo
            botonSeleccionado.BackColor = AzulFondo;
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            ActualizarMenuActivo(btnInicio);

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
            ActualizarMenuActivo(btnInventario);

            //Ir a Inventario
            FrmInventario2 frmInventario;
            if (!Application.OpenForms.OfType<FrmInventario2>().Any())
            {
                frmInventario = new FrmInventario2();
            }
            else
            {
                frmInventario = Application.OpenForms.OfType<FrmInventario2>().FirstOrDefault();
            }
            this.Hide();
            frmInventario.Show();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            ActualizarMenuActivo(btnVentas);

        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            ActualizarMenuActivo(btnAyuda);
            // Construimos la ruta dinámica uniendo la ubicación del .exe con la carpeta del PDF
            // Usamos Application.StartupPath para que funcione en cualquier computadora donde se instale
            string rutaLocalPdf = System.IO.Path.Combine(Application.StartupPath, "Resources", "Guia_de_Usuario_IlcaPoint_con_capturas.pdf");

            // Validamos si el archivo realmente existe físicamente en esa ruta
            if (System.IO.File.Exists(rutaLocalPdf))
            {
                try
                {
                    //le decimos a sistemaoperativo del usuario que use su visor predeterminado para ver el archivo 
                    System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                    {
                        FileName = rutaLocalPdf,
                        UseShellExecute = true // para asocial los archivos predeterminada (Edge, Chrome, Adobe, lalalala)
                    });
                }
                catch (Exception ex)
                {
                    // Filtro de error si el sistema operativo no tiene ningún lector de PDF asignado
                    MessageBox.Show("Ocurrió un problema al intentar abrir el visor de PDF de su sistema.",
                                    "Error de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Alerta controlada si por alguna razón el archivo fue borrado de la carpeta
                MessageBox.Show("El archivo de la guía de usuario no se encuentra en la carpeta de la aplicación.",
                                "Archivo No Encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void avatar1_Click(object sender, EventArgs e) { }
        private void panelMenu_Paint(object sender, PaintEventArgs e) { }
        private void panelEncabezado_Paint(object sender, PaintEventArgs e) { }
        private void txtBuscar_TextChanged(object sender, EventArgs e) { }
        private void button1_Click(object sender, EventArgs e) { }
        private void datePicker1_ValueChanged(object sender, AntdUI.DateTimeNEventArgs e) { }

        private void btnNuevaVenta_Click(object sender, EventArgs e)
        {
            // Creamos y mostramos el fondo oscuro estirado sobre todo el Form1
            Form_FondoOscuro fondo = new Form_FondoOscuro(); 
            fondo.StartPosition = FormStartPosition.Manual;
            fondo.Bounds = this.Bounds;
            fondo.Show(this);

            // Ventana flotante limpia que contendrá tu panel lateral
            Form ventanaContenedor = new Form();
            ventanaContenedor.FormBorderStyle = FormBorderStyle.None;
            ventanaContenedor.Size = new Size(480, 1024);
            ventanaContenedor.StartPosition = FormStartPosition.Manual;

            // Posición del botón
            ventanaContenedor.Location = new Point(this.Location.X + this.Width - 480, this.Location.Y);
            ventanaContenedor.ShowInTaskbar = false;

            AgregarVenta panelVenta = new AgregarVenta();
            panelVenta.Dock = DockStyle.Fill;
            ventanaContenedor.Controls.Add(panelVenta);

            ventanaContenedor.ShowDialog(fondo);

            fondo.Dispose();

            // Refresca el historial para mostrar la nueva venta
            CargarHistorialVentas();
        }

        private void btnCerrarsesion_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        public void ExportarVentasAExcel()
        {
            TransaccionService service = new TransaccionService();
            List<Transaccion> transacciones = service.ObtenerTodasLasTransacciones();

            var workbook = new ClosedXML.Excel.XLWorkbook();
            var hoja = workbook.Worksheets.Add("Historial de Ventas");

            // Encabezados
            hoja.Cell(1, 1).Value = "ID Transacción";
            hoja.Cell(1, 2).Value = "Nombre Producto";
            hoja.Cell(1, 3).Value = "Fecha";
            hoja.Cell(1, 4).Value = "Categoría";
            hoja.Cell(1, 5).Value = "Total";

            // Estilo de encabezados
            var encabezados = hoja.Range("A1:E1");
            encabezados.Style.Font.Bold = true;
            encabezados.Style.Fill.BackgroundColor = ClosedXML.Excel.XLColor.FromHtml("#1A3560");
            encabezados.Style.Font.FontColor = ClosedXML.Excel.XLColor.White;
            encabezados.Style.Alignment.Horizontal = ClosedXML.Excel.XLAlignmentHorizontalValues.Center;

            int fila = 2;
            foreach (Transaccion transaccion in transacciones)
            {
                if (transaccion.Detalles == null) continue;

                foreach (DetallesTransaccion detalle in transaccion.Detalles)
                {
                    ServicioInventario servicio = new ServicioInventario();
                    Producto producto = servicio.BuscarProductoPorId(detalle.ProductoId);

                    hoja.Cell(fila, 1).Value = "T" + transaccion.idTransaccion.ToString("D4");
                    hoja.Cell(fila, 2).Value = detalle.ProductoNombre;
                    hoja.Cell(fila, 3).Value = transaccion.Fecha.ToString("dd/MM/yyyy HH:mm");
                    hoja.Cell(fila, 4).Value = producto?.categoria ?? "Sin categoría";
                    hoja.Cell(fila, 5).Value = transaccion.Total;
                    hoja.Cell(fila, 5).Style.NumberFormat.Format = "$#,##0.00";

                    // Color alterno por fila
                    if (fila % 2 == 0)
                        hoja.Row(fila).Style.Fill.BackgroundColor = ClosedXML.Excel.XLColor.FromHtml("#EBF0FA");

                    fila++;
                }
            }

            // Ajusta el ancho de las columnas automáticamente
            hoja.Columns().AdjustToContents();

            // Borde a toda la tabla
            var tabla = hoja.Range(1, 1, fila - 1, 5);
            tabla.Style.Border.OutsideBorder = ClosedXML.Excel.XLBorderStyleValues.Thin;
            tabla.Style.Border.InsideBorder = ClosedXML.Excel.XLBorderStyleValues.Thin;

            // Guardar con dialogo para que el usuario elija dónde
            SaveFileDialog dialogo = new SaveFileDialog();
            dialogo.Filter = "Excel|*.xlsx";
            dialogo.FileName = "Ventas_IlkaPoint_" + DateTime.Now.ToString("yyyyMMdd");

            if (dialogo.ShowDialog() == DialogResult.OK)
            {
                workbook.SaveAs(dialogo.FileName);
                System.Windows.Forms.MessageBox.Show("Archivo exportado correctamente.", "IlkaPoint",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnexcel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se exportaran todas sus ventas a un archivo .xlsx");
            ExportarVentasAExcel();
        }
    }
}