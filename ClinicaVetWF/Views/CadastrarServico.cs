using ClinicaVetWF.Models;
using ClinicaVetWF.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaVetWF.Views
{
    public partial class CadastrarServico : Form
    {
        private List<TiposProfissionais> listaTiposProfissionais;
        private List<funcionario> listaFuncionarios;
        private TipoProfissionalService tipoProfissionalService;
        private ServicoService servicoService;
        private FuncionarioService funcionarioService;
        public CadastrarServico()
        {
            InitializeComponent();
            tipoProfissionalService = new TipoProfissionalService(new Utils.Context());
            funcionarioService = new FuncionarioService(new Utils.Context());
            servicoService = new ServicoService(new Utils.Context());
            maskedTextBoxValor.KeyPress += MaskedTextBoxValor_KeyPress;
        }

        private void MaskedTextBoxValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true; 
                return;
            }

            if (e.KeyChar == '.' && maskedTextBoxValor.Text.Contains("."))
            {
                e.Handled = true; 
                return;
            }

            if (e.KeyChar == '.' && !maskedTextBoxValor.Text.Contains("."))
            {
                maskedTextBoxValor.Text += ".";
                maskedTextBoxValor.Text = decimal.Parse(maskedTextBoxValor.Text).ToString("0.00");
                maskedTextBoxValor.SelectionStart = maskedTextBoxValor.Text.Length;
                e.Handled = true; 
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void CadastrarServico_Load(object sender, EventArgs e)
        {
            try
            {
                //maskedTextBoxValor.Mask = "$##,###.##";
                txbDescricaoServico.Validating += Utils.Validations.CampoVazioTextBox_Validating;
                cbbMedidaReferencia.Validating += Utils.Validations.CampoVazioComboBox_Validating;
                cbbTipoResponsavel.Validating += Utils.Validations.CampoVazioComboBox_Validating;

                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("Id", typeof(int));
                dataTable.Columns.Add("Nome", typeof(string));

                listaTiposProfissionais = tipoProfissionalService.BuscarTipoProfissional();

                foreach (var tipo in listaTiposProfissionais)
                {
                    dataTable.Rows.Add(tipo.ID, tipo.Nome);
                }

                cbbTipoResponsavel.DataSource = dataTable;
                cbbTipoResponsavel.DisplayMember = "Nome";

                cbbTipoResponsavel.SelectedIndex = 0;

                List<string> medidas = new List<string>
                {
                    "Hora",
                    "Minuto",
                    "Segundo",
                    "Dia",
                    "Semana",
                    "Mês",
                    "Ano",
                    "Gramas",
                    "Quilogramas",
                    "Miligramas",
                    "Litros",
                    "Mililitros",
                    "Unidade",
                    "Dose",
                };

                foreach (var tipo in medidas)
                {
                    cbbMedidaReferencia.Items.Add(tipo);
                }

                cbbMedidaReferencia.SelectedIndex = 0;

                DataTable dataTableFun = new DataTable();
                dataTableFun.Columns.Add("Id", typeof(int));
                dataTableFun.Columns.Add("Nome", typeof(string));

                listaFuncionarios = funcionarioService.BuscarFuncionarios();

                foreach (var funcionario in listaFuncionarios)
                {
                    dataTableFun.Rows.Add(funcionario.id, funcionario.nome);
                }

                cbbColaborador.DataSource = dataTableFun;
                cbbColaborador.DisplayMember = "Nome";

                cbbColaborador.SelectedIndex = 0;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void btnCadastrarServico_Click(object sender, EventArgs e)
        {
            string descricao = txbDescricaoServico.Text;
            decimal valor = decimal.Parse(maskedTextBoxValor.Text);

            int idTipoProfissional = 0;
            if (cbbTipoResponsavel.SelectedItem != null)
            {
                DataRowView rowView = (DataRowView)cbbTipoResponsavel.SelectedItem;
                idTipoProfissional = (int)rowView["Id"];
            }

            string medidaReferencia = "";
            if (cbbMedidaReferencia.SelectedItem != null)
            {
                medidaReferencia = cbbMedidaReferencia.SelectedItem.ToString();
            }

            int idColaborador = 0;
            if (cbbColaborador.SelectedItem != null)
            {
                DataRowView rowView = (DataRowView)cbbColaborador.SelectedItem;
                idColaborador = (int)rowView["Id"];
            }

            servicoService.CadastrarServico(descricao, valor, idTipoProfissional, medidaReferencia, idColaborador);
            limparCampos();
        }

        public void limparCampos()
        {
           Utils.Validations.LimparCampos(this);
        }

        private void maskedTextBoxValor_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
