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
          

            VisualizarClientes visualizarClientes = new VisualizarClientes();   
            visualizarClientes.ShowDialog();   
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void agendarExameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*Agendamento agendarExame = new Agendamento();
            agendarExame.ShowDialog();*/
            VisualizarConsultas visualizarConsultas = new VisualizarConsultas();    
            visualizarConsultas.ShowDialog();   

        }

        private void cadastrarProfissionalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastrarTipoProfissional cadastrarTipoProfissional = new CadastrarTipoProfissional();
            cadastrarTipoProfissional.ShowDialog();
        }

        private void cadastrarNovoServiçoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastrarServico cadastrarServico = new CadastrarServico();
            cadastrarServico.ShowDialog();
        }

        private void agendarConsultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*Agendamento agendamento = new Agendamento();
            agendamento.ShowDialog();*/
            VisualizarConsultas visualizarConsultas = new VisualizarConsultas();
            visualizarConsultas.ShowDialog();   
        }
    }
}
