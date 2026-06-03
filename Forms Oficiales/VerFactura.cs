using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IlkaPoint.Forms_Oficiales
{
    public partial class VerFactura : UserControl
    {
        public VerFactura()
        {
            InitializeComponent();

            this.BackColor = ColorTranslator.FromHtml("#1A3560");

            avatarLogo.Anchor = AnchorStyles.Top;
            lblTituloIlca.Anchor = AnchorStyles.Top;
            lblNumVenta.Anchor = AnchorStyles.Top;

            lblFecha.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            lblFechaFactura.Anchor = AnchorStyles.Top | AnchorStyles.Right;

            // Enganche del evento Layout que se activa CADA VEZ que el panel se dibuja o cambia
            flpProductosFactura.Layout += ComponentesFactura_Layout;
        }

        /// <summary>
        /// Carga los datos de la venta seleccionada en la interfaz estética de la factura.
        /// </summary>
        /// <param name="metodoPago">El método de pago utilizado (ej: Efectivo, Yappy)</param>
        public void CargarDatosFactura(string idVenta, string metodoPago, string fecha, List<dynamic> productos, int totalArticulos, decimal montoTotal)
        {
            // Encabezado
            lblNumVenta.Text = $"Factura #{idVenta}";
            lblFechaFactura.Text = fecha; 

            flpProductosFactura.Controls.Clear();

            // Suspende temporalmente el diseño para cargar rápido en memoria
            flpProductosFactura.SuspendLayout();

            foreach (var prod in productos)
            {
                // Molde ItemProducto
                ItemProducto renglon = new ItemProducto();

                renglon.ConfigurarRenglon(
                    prod.Nombre,
                    (int)prod.Cantidad,
                    (decimal)prod.Precio,
                    (decimal)prod.Subtotal
                );

                // Propiedades para cada renglon
                renglon.MaximumSize = new Size(0, 0);
                renglon.MinimumSize = new Size(200, 51);
                renglon.Height = 51;
                renglon.Margin = new Padding(0, 0, 0, 6);

                flpProductosFactura.Controls.Add(renglon);
            }

            // Obliga a recalcular el diseño para ajustar los anchos de los renglones
            flpProductosFactura.ResumeLayout();
            AjustarAnchoHijos();

            // Datos de totales o precios
            lblTotalProductos.Text = totalArticulos.ToString();
            lblTotalPrecio.Text = $"${montoTotal:F2}";
        }

        // Favor NO TOCAR :| Se crashea el diseño Gracias!
        private void AjustarAnchoHijos()
        {
            if (panelArriba == null) return; // Parche de seguridad

            int centroPanel = panelArriba.Width / 2;

            // Centrado del Logo
            if (avatarLogo != null) avatarLogo.Left = centroPanel - (avatarLogo.Width / 2);

            // Centrado del titulo
            if (lblTituloIlca != null)
            {
                lblTituloIlca.AutoSize = false;
                lblTituloIlca.Width = 350;
                lblTituloIlca.TextAlign = ContentAlignment.TopCenter;
                lblTituloIlca.Left = centroPanel - (lblTituloIlca.Width / 2);
            }

            // Numero de venta centrado
            if (lblNumVenta != null)
            {
                lblNumVenta.AutoSize = false;
                lblNumVenta.Width = 250;
                lblNumVenta.TextAlign = ContentAlignment.TopCenter;
                lblNumVenta.Left = centroPanel - (lblNumVenta.Width / 2);
            }

            if (lblFecha != null) lblFecha.Left = 20;

            if (lblFechaFactura != null)
            {
                lblFechaFactura.AutoSize = true;
                lblFechaFactura.Left = panelArriba.Width - lblFechaFactura.Width - 20;
            }

            // Estiramiento de tarjetas
            if (flpProductosFactura == null || flpProductosFactura.Controls.Count == 0) return;

            int anchoDisponible = flpProductosFactura.ClientSize.Width - 6;

            foreach (Control ctrl in flpProductosFactura.Controls)
            {
                if (ctrl is ItemProducto renglon)
                {
                    renglon.Width = anchoDisponible;
                }
            }
        }

        // Cuidado con este evento
        private void ComponentesFactura_Layout(object sender, LayoutEventArgs e)
        {
            AjustarAnchoHijos();
        }

        private void VerFactura_Load(object sender, EventArgs e)
        {
        }

        private void btnCerrarPanel_Click(object sender, EventArgs e)
        {
            this.FindForm()?.Close();
        }

        private void lblNumVenta_Click(object sender, EventArgs e)
        {
        }
    }
}