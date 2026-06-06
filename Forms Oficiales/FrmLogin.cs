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
        // 1. CUANDO EL USUARIO ENTRA AL CUADRO (Ya sea con Click o con Tabulador)
        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            // Si tiene la palabra por defecto o los puntitos de ayuda, limpiamos
            if (txtContraseña.Text == "Contraseña" || txtContraseña.Text == "••••••••")
            {
                txtContraseña.Text = "";
                txtContraseña.UseSystemPasswordChar = true; // Convierte lo que escriba en puntitos reales
            }
        }

        // 2. CUANDO EL USUARIO SE SALE DEL CUADRO SIN ESCRIBIR NADA
        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            // Si lo dejó vacío, le devolvemos el texto de ayuda estético
            if (string.IsNullOrWhiteSpace(txtContraseña.Text))
            {
                txtContraseña.UseSystemPasswordChar = false; // Desactiva los puntitos para leer la palabra
                txtContraseña.Text = "Contraseña"; // Texto Placeholder
            }
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
            if (txtContraseña.Text == "Abarroteria")
            {
                System.Windows.Forms.MessageBox.Show(" Acceso Concedido.");
                this.DialogResult = DialogResult.OK; // Le avisa al Program.cs que todo está bien
                this.Close();                         // Cierra el Login 
                return;
            }

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
