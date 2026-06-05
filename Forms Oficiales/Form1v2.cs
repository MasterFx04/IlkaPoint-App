using FontAwesome.Sharp;
using IlkaPoint.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using FontAwesome.Sharp; // Mantén esta línea arriba para que reconozca el tipo IconButton

namespace IlkaPoint
{
    public partial class Form1v2 : Form
    {
        // Paleta de Colores Estética
        public static readonly Color AzulFondo = ColorTranslator.FromHtml("#1A3560");         // Fondo de la pantalla principal
        public static readonly Color AzulClaroTarjetas = ColorTranslator.FromHtml("#3059B6"); // Botones "Ver Factura"
        public static readonly Color BlancoTexto = ColorTranslator.FromHtml("#FFFFFF");       // Textos legibles
        public static readonly Color AzulMenu = ColorTranslator.FromHtml("#08243B");          // Menú lateral izquierdo

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
                b.BackColor = Color.Transparent; // Los demás inician transparentes hasta que se les hace click
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
                if (c == avatarLogo || c.Name == "avatarLogo")
                {
                    if (c.HasChildren) ApplyThemeRec(c);
                    continue; // Se salta el logo y sigue con los demás controles
                }

                if (c is Button btn)
                {
                    btn.UseVisualStyleBackColor = false;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;

                    // Filtro para no pintar de azul claro los botones del menú ni el de cerrar sesión
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

            if (btnNuevaVenta != null) // Aseguramos que el botón exista
            {
                btnNuevaVenta.BackColor = AzulClaroTarjetas;
                
            }

            if (panelContenido != null)
            {
                panelContenido.Controls.Clear();
                for (int i = 1; i <= 6; i++)
                {
                    Tarjeta_de_Ventas tarjetaPrueba = new Tarjeta_de_Ventas();
                    tarjetaPrueba.CargarDatos($"000{i}", "27 de mayo 2026", "Cliente de Prueba", 15.50 * i);
                    panelContenido.Controls.Add(tarjetaPrueba);
                }
            }
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

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}