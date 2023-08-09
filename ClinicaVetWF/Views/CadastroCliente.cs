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
using static ClinicaVetWF.Services.EnderecoService;

namespace ClinicaVetWF.Views
{
    public partial class CadastroCliente : Form
    {
        private ClienteService clienteService;
        private EnderecoService enderecoService;
        public CadastroCliente()
        {
            InitializeComponent();
            clienteService = new ClienteService(new Utils.db_clinicaEntities1());
            enderecoService = new EnderecoService(new Utils.db_clinicaEntities1());

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

        private void CadastroCliente_Load(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Nome", typeof(string));
            dataTable.Columns.Add("Sigla", typeof(string));

            List<Estado> estados = new List<Estado>();
            estados = enderecoService.GetEstadosList();
            
            // Preencher a ComboBox com os estados
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
                clienteService.CadastrarCliente(idEnd, nome, telefone, email, cpf, rg, dataCriacao);

            
        }
    }
}
