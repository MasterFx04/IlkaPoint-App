using FontAwesome.Sharp;
using IlkaPoint.Clases;
using IlkaPoint.Forms_Oficiales;
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

        public class RegistroVenta
        {
            public string IdVenta { get; set; }
            public string MetodoPago { get; set; }
            public string Fecha { get; set; }
            public List<ItemVendido> Productos { get; set; } = new List<ItemVendido>();
            public int TotalArticulos { get; set; }
            public decimal MontoTotal { get; set; }
        }

        // Base de datos Simulada
        public static List<RegistroVenta> BaseDatosVentas = new List<RegistroVenta>();

        public void CargarHistorialVentas()
        {
            if (panelContenido == null) return;

            panelContenido.Controls.Clear();

            // Recorre lista central para crear tarjetas de ventas
            foreach (var venta in BaseDatosVentas)
            {
                // Instancia de tarjeta de ventas real
                Tarjeta_de_Ventas tarjeta = new Tarjeta_de_Ventas();

                // Método para rellenar los textos de la tarjeta
                tarjeta.CargarDatos(venta.IdVenta, venta.Fecha, venta.MetodoPago, (double)venta.MontoTotal);

                tarjeta.btnVerFactura.Click += (sender, e) => {

                    // Convertimos los productos de la venta al formato dinámico que espera el control 'VerFactura'
                    List<dynamic> listaDynamic = new List<dynamic>();
                    foreach (var p in venta.Productos)
                    {
                        listaDynamic.Add(new { Nombre = p.Nombre, Cantidad = p.Cantidad, Precio = p.Precio, Subtotal = p.Subtotal });
                    }

                    // Colocación del fondo oscuro
                    Form_FondoOscuro fondo = new Form_FondoOscuro();
                    fondo.StartPosition = FormStartPosition.Manual;
                    fondo.Bounds = this.Bounds;
                    fondo.Show(this);

                    // Ventana para contener factura
                    Form ventanaContenedor = new Form();
                    ventanaContenedor.FormBorderStyle = FormBorderStyle.None;
                    ventanaContenedor.Size = new Size(480, 1024);
                    ventanaContenedor.StartPosition = FormStartPosition.Manual;
                    ventanaContenedor.Location = new Point(this.Location.X + this.Width - 480, this.Location.Y);
                    ventanaContenedor.ShowInTaskbar = false;

                    // Instancia control de factura real
                    VerFactura ucFactura = new VerFactura();
                    ucFactura.Dock = DockStyle.Fill;

                    // Cargamos los datos dinámicos directo en la instancia del control
                    ucFactura.CargarDatosFactura(
                        venta.IdVenta,
                        venta.MetodoPago,
                        venta.Fecha,
                        listaDynamic,
                        venta.TotalArticulos,
                        venta.MontoTotal
                    );

                    // Ins3erta el diseño dentro de la ventana y lo muestra como un diálogo modal
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
            {
                btnNuevaVenta.BackColor = AzulClaroTarjetas;
            }

            // Al inciar el programa, La pantalla principal de ventas esta vacia. Con este se agrega una tarjeta por default.
            if (BaseDatosVentas.Count == 0)
            {
                var ventaDemo = new RegistroVenta()
                {
                    IdVenta = "0001",
                    MetodoPago = "Efectivo", 
                    Fecha = "27-05-2026",  
                    TotalArticulos = 4,
                    MontoTotal = 5.05m
                };
                ventaDemo.Productos.Add(new ItemVendido { Nombre = "Coca Cola 2 ltrs", Cantidad = 1, Precio = 2.10m });
                ventaDemo.Productos.Add(new ItemVendido { Nombre = "Jabon Corporal Palmolive", Cantidad = 3, Precio = 1.00m });

                BaseDatosVentas.Add(ventaDemo);
            }

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
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            ActualizarMenuActivo(btnInventario);
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            ActualizarMenuActivo(btnVentas);
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            ActualizarMenuActivo(btnAyuda);
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
    }
}