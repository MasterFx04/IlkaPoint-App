using System;
using System.Globalization; // <- ESTA ES LA CLAVE para que reconozca CultureInfo
using System.Threading;     // <- ESTA ES LA CLAVE para que reconozca Thread
using System.Windows.Forms;

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
            Application.Run(new FormDePrueba2());
        }
    }
}