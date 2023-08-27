using ClinicaVetWF.Utils;
using ClinicaVetWF.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaVetWF
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var splashScreen = new SplashScreen();
            splashScreen.Show();
            Application.DoEvents();

            Thread.Sleep(3000); 

            splashScreen.Close();

            Application.Run(new Login());
        }
    }
}
