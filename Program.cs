using System;
using System.Globalization; // <- ESTA ES LA CLAVE para que reconozca CultureInfo
using System.Threading;     // <- ESTA ES LA CLAVE para que reconozca Thread
using System.Windows.Forms;
using IlkaPoint.FormsPrueba;

namespace IlkaPoint
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("es-ES");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("es-ES");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Creamos el Login en memoria
            FrmLogin login = new FrmLogin();

            // Lo mostramos como un diálogo estricto. El código se detiene aquí temporalmente.
            if (login.ShowDialog() == DialogResult.OK)
            {
                // Si el Login responde OK, pasamos al Dashboard Principal y lo volvemos el dueño de la app
                Application.Run(new FrmDashboardPrincipal());
            }
            // Si cierran el login o fallan, el programa muere aquí limpiamente.

            /*
            // Obliga a toda la aplicación y a AntdUI a usar el formato en español
            Thread.CurrentThread.CurrentCulture = new CultureInfo("es-ES");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("es-ES");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new FormSimulaciónInventario());

            Application.Run(new Form1v2());
            Application.Run(new FrmInventario2());

            //Mostrar el login Primero
            FrmLogin login = new FrmLogin();
            if (login.ShowDialog() == DialogResult.OK )
            {
                //SI TODO SALIO BIEN D:
                FrmDashboardPrincipal dashboard = new FrmDashboardPrincipal();
                //dashboard.WindowState = FormWindowState.Maximized;
                Application.Run(dashboard);
            }*/

        }
    }

    internal class FormSimulaciónInventario : Form
    {
    }
}