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

            // Criação e exibição da splash screen
            var splashScreen = new SplashScreen();
            splashScreen.Show();
            Application.DoEvents();

            // Simulação de inicialização do aplicativo
            Thread.Sleep(3000); // Espera de 3 segundos (apenas para fins de demonstração)

            // Fechar a splash screen após a inicialização
            splashScreen.Close();

            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}
