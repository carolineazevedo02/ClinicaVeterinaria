using ClinicaVetWF.Models;
using ClinicaVetWF.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ClinicaVetWF.Services.AnimalService;
using static ClinicaVetWF.Services.ClienteService;
using static ClinicaVetWF.Services.EnderecoService;

namespace ClinicaVetWF.Views
{
    public partial class CadastroCliente : Form
    {
        private ClienteService clienteService;
        private EnderecoService enderecoService;
        private bool edicao;
        private int idCliente;
        public CadastroCliente(bool edicao = false, int idACliente = 0)
        {
            InitializeComponent();
            clienteService = new ClienteService(new Utils.Context());
            enderecoService = new EnderecoService(new Utils.Context());

            this.edicao = edicao;
            this.idCliente = idACliente;


            if (edicao)
            {
                ConfigurarCampos();
                List<ClienteInfo> clientes = new List<ClienteInfo>();
                clientes = clienteService.BuscarCliente(idCliente);
                foreach (var cliente in clientes)
                {
                    txbNomeCliente.Text = cliente.ClienteNome;
                    txbEmailCliente.Text = cliente.ClienteEmail;
                    txbRgCliente.Text = cliente.ClienteRg;
                    maskedTextBoxCPF.Text = cliente.ClienteCPF;
                    maskedTextBoxTelefone.Text = cliente.ClienteTelefone;
                    SelecionarItemPorNome(cbbEstados, cliente.ClienteEstado);
                    txbEndereco.Text = cliente.ClienteRua;
                    txbCEPEndereco.Text = cliente.ClienteCEP;
                    txbCidadeEndereco.Text = cliente.ClienteCidade;
                    txbReferenciaEndereco.Text = cliente.ClienteReferencia;

                }
            }
            else
            {
                ConfigurarCampos();
            }
        }

        public void ConfigurarCampos()
        {
            txbCEPEndereco.Validating += Utils.Validations.CampoVazioTextBox_Validating;
            txbCidadeEndereco.Validating += Utils.Validations.CampoVazioTextBox_Validating;
            txbEmailCliente.Validating += Utils.Validations.CampoVazioTextBox_Validating;
            txbEndereco.Validating += Utils.Validations.CampoVazioTextBox_Validating;
            txbNomeCliente.Validating += Utils.Validations.CampoVazioTextBox_Validating;
            txbRgCliente.Validating += Utils.Validations.CampoVazioTextBox_Validating;

            maskedTextBoxCPF.Validating += Utils.Validations.CampoVazioMaskedTextBox_Validating; ;
            maskedTextBoxTelefone.Validating += Utils.Validations.CampoVazioMaskedTextBox_Validating;
            cbbEstados.Validating += Utils.Validations.CampoVazioComboBox_Validating;
        }
        private void SelecionarItemPorNome(ComboBox comboBox, string nome)
        {
            for (int i = 0; i < comboBox.Items.Count; i++)
            {
                DataRowView item = comboBox.Items[i] as DataRowView;
                if (item != null && item.Row["Nome"].ToString() == nome)
                {
                    comboBox.SelectedIndex = i;
                    break;
                }
            }
        }
        private void CadastroCliente_Load(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Nome", typeof(string));
            dataTable.Columns.Add("Sigla", typeof(string));

            List<Estado> estados = new List<Estado>();
            estados = enderecoService.GetEstadosList();

            foreach (Estado estado in estados)
            {
                dataTable.Rows.Add(estado.Nome, estado.Sigla);
            }

            cbbEstados.DataSource = dataTable;
            cbbEstados.DisplayMember = "Nome";

            cbbEstados.SelectedIndex = 0;

            maskedTextBoxTelefone.Mask = "(00) 00000-0000";
            maskedTextBoxCPF.Mask = "999.999.999-99";
        }

        private void btnCadastrarCliente_Click(object sender, EventArgs e)
        {

            string estadoSelecionado = "";
            if (cbbEstados.SelectedItem != null)
            {
                DataRowView rowView = (DataRowView)cbbEstados.SelectedItem;
                estadoSelecionado = (string)rowView["Nome"];
            }
            string rua = txbEndereco.Text;
            string cidade = txbCidadeEndereco.Text;
            string estado = cbbEstados.Text;
            string cep = txbCEPEndereco.Text;
            string referencia = txbReferenciaEndereco.Text;
            int idEnd = enderecoService.CadastrarEndereco(rua, cidade, cep, referencia, estado);

            string nome = txbNomeCliente.Text;
            string email = txbEmailCliente.Text;
            string cpf = maskedTextBoxCPF.Text;
            string rg = txbRgCliente.Text;
            string telefone = maskedTextBoxTelefone.Text;

            DateTime dataCriacao = DateTime.Now;

            if (!Utils.Validations.ValidarEmail(email))
            {
                MessageBox.Show("E-mail inválido", "Atenção");
                return;
            }
            if (edicao)
            {
               clienteService.EditarCliente(this.idCliente, idEnd, nome, telefone, email, cpf, rg);
            }
            else 
            { 
                clienteService.CadastrarCliente(idEnd, nome, telefone, email, cpf, rg, dataCriacao); 
            }
        }
    }
}
