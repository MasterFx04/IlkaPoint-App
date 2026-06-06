using IlkaPoint.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace IlkaPoint
{
    public partial class FrmLogin : Form
    {
        private int txtClick = 0;

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
        private void txtContraseña_TextClick(object sender, EventArgs e) //Al tocar el txt de Contraseña
        {
            
            if (txtClick == 0)
            {
                txtContraseña.Clear();
                txtClick++;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string passSet = txtContraseña.Text;

            using (AppDBContext db = new AppDBContext())
            {
                Administrador admin = db.Admins.FirstOrDefault();

                if (admin == null) //Por si un administrador no existe
                {
                    System.Windows.Forms.MessageBox.Show("Usuario no Encontrado");
                    return;
                }

                string contraDescrifrada = CifradoXOR.Decifrar(admin.PassEncrypted);

                if (contraDescrifrada == passSet)
                {
                    System.Windows.Forms.MessageBox.Show("Bienvenido Al Sistema");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                    //Navegando al Dashboard desde Program.cs
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Contraseña Incorrecta, intente nuevamente");
                }
            }
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
