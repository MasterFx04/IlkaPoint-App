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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            panelCentro.BackColor = Color.Transparent;
           

        }

        

        //Evento Paint para el panelFondo (donde se dibuja el fondo degradado)
        private void panelFondo_Paint(object sender, PaintEventArgs e)
        {
            using (System.Drawing.Drawing2D.LinearGradientBrush brush = new System.Drawing.Drawing2D.LinearGradientBrush(
    panelFondo.ClientRectangle,
    Color.FromArgb(11, 37, 69),   // Color 1 de Mockup Figma 
    Color.FromArgb(3, 10, 20),    // Color 2 de Mockup Figma 
    System.Drawing.Drawing2D.LinearGradientMode.Vertical)) // Dirección: Vertical o Horizontal
            {
                e.Graphics.FillRectangle(brush, panelFondo.ClientRectangle);
            }
        }

        private void lblIniciarSesión_Click(object sender, EventArgs e)
        {

        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void lblBienvenido_Click(object sender, EventArgs e)
        {

        }

        private void lblContraseña_Click(object sender, EventArgs e)
        {

        }
    }
}
