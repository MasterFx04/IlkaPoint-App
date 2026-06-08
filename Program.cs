using System;
using System.Globalization; // <- ESTA ES LA CLAVE para que reconozca CultureInfo
using System.Threading;     // <- ESTA ES LA CLAVE para que reconozca Thread
using System.Windows.Forms;
using IlkaPoint.FormsPrueba;
using IlkaPoint.Forms_Oficiales;

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
            // Obliga a toda la aplicación y a AntdUI a usar el formato en español
            Thread.CurrentThread.CurrentCulture = new CultureInfo("es-ES");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("es-ES");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Mostrar el login Primero
            FrmInventario2 login = new FrmInventario2();
            if (login.ShowDialog() == DialogResult.OK )
            {
                //SI TODO SALIO BIEN D:
                FrmDashboardPrincipal dashboard = new FrmDashboardPrincipal();
                //dashboard.WindowState = FormWindowState.Maximized;
                Application.Run(dashboard);
            }
        }
    }
}