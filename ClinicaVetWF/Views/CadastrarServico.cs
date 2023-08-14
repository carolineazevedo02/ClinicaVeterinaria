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
        private TipoProfissionalService tipoProfissionalService;
        private ServicoService servicoService;
        public CadastrarServico()
        {
            InitializeComponent();
            tipoProfissionalService = new TipoProfissionalService(new Utils.Context());
            servicoService = new ServicoService(new Utils.Context());
            maskedTextBoxValor.Mask = "R$ #,##0.00";
            maskedTextBoxValor.TextChanged += MaskedTextBoxValor_TextChanged;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void CadastrarServico_Load(object sender, EventArgs e)
        {
            try
            {
                maskedTextBoxValor.Mask = "$##,###.##";
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
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void MaskedTextBoxValor_TextChanged(object sender, EventArgs e)
        {
            decimal parsedValue = 0;
            string text = maskedTextBoxValor.Text.Replace("R$", "").Replace(",", "").Trim();

            if (!string.IsNullOrEmpty(text) && decimal.TryParse(text, out parsedValue))
            {
                maskedTextBoxValor.Text = parsedValue.ToString("C");
                maskedTextBoxValor.SelectionStart = maskedTextBoxValor.Text.Length;
            }
        }

       
        private void btnCadastrarServico_Click(object sender, EventArgs e)
        {
            string descricao = txbDescricaoServico.Text;
            decimal valor = decimal.Parse(textBoxValor.Text);

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

            servicoService.CadastrarServico(descricao, valor, idTipoProfissional, medidaReferencia);
            limparCampos();
        }

        public void limparCampos()
        {
            maskedTextBoxValor.Text = "";
            txbDescricaoServico.Text = "";
            textBoxValor.Text = "";
        }
    }
}
