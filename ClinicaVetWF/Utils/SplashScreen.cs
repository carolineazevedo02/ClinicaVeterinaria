using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaVetWF.Utils
{
    public partial class SplashScreen : Form
    {
        private Timer timer;
        public SplashScreen()
        {
            InitializeComponent();
            // Configurar o temporizador
            timer = new Timer();
            timer.Interval = 3000; 
            timer.Tick += Timer_Tick;
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            this.Close();
        }
    }
}
