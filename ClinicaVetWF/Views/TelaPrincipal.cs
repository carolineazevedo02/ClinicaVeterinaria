using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaVetWF.Views
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }


        private void TelaPrincipal_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }


        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cadastrarPetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*CadastrarAnimal cadastrarAnimal = new CadastrarAnimal();    
            cadastrarAnimal.ShowDialog();*/

            VisualizarAnimais visualizarAnimais = new VisualizarAnimais();
            visualizarAnimais.ShowDialog();
        }

        private void cadastrarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroCliente cadastroCliente = new CadastroCliente();
            cadastroCliente.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
