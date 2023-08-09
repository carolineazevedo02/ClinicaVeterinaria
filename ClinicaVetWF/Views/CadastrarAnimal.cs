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

namespace ClinicaVetWF.Views
{
    public partial class CadastrarAnimal : Form

    {
        private List<cliente> listaTutores;
        private List<especie> listaEspecies;
        private ClienteService clienteService;
        private AnimalService animalService;
        private bool edicao;
        public CadastrarAnimal(bool edicao = false, int idAnimal = 0)
        {
            InitializeComponent();
            this.edicao = edicao;

            clienteService = new ClienteService(new Utils.db_clinicaEntities1());
            animalService = new AnimalService(new Utils.db_clinicaEntities1());

            txbNomeAnimal.Validating += Utils.Validations.CampoVazioTextBox_Validating;
            txbCorAnimal.Validating += Utils.Validations.CampoVazioTextBox_Validating;
            cbbEspecie.Validating += Utils.Validations.CampoVazioComboBox_Validating;
            cbbTutor.Validating += Utils.Validations.CampoVazioComboBox_Validating;
            maskedTextBoxNumeroIdent.Validating += Utils.Validations.CampoVazioMaskedTextBox_Validating; ;
            maskedTextBoxDataNasc.Validating += Utils.Validations.CampoVazioMaskedTextBox_Validating;

            txbObs.Multiline = true;
            txbObs.ScrollBars = ScrollBars.Both; 
            txbObs.AcceptsReturn = true;

            if(edicao)
            {
                List<AnimalInfo> animalInfo = new List<AnimalInfo>();
                animalInfo = animalService.BuscarAnimal(idAnimal);

                foreach(var animal in animalInfo)
                {
                    txbNomeAnimal.Text = animal.AnimalNome;
                    txbCorAnimal.Text = animal.Cor;
                    txbObs.Text = animal.Observacoes;
                }
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnSelecionarCor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                // A cor escolhida pelo usuário está armazenada em colorDialog.Color
                Color chosenColor = colorDialog.Color;

                txbCorAnimal.Text = chosenColor.Name;
            }
        }

        private void CadastrarAnimal_Load(object sender, EventArgs e)
        {
            ConfigurarCampos();
        }

        private void maskedTextBoxNumeroIdent_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
        private void MaskedTextBoxIntegerOnly_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Bloqueia a entrada de caracteres não numéricos.
            }
        }

        private void btnConfirmarCadastroAnimal_Click(object sender, EventArgs e)
        {
            if (edicao)
            {

            }
            else
            {
                string nome = txbNomeAnimal.Text;
                string cor = txbCorAnimal.Text;

                int idTutor = 0;
                if (cbbTutor.SelectedItem != null)
                {
                    DataRowView rowView = (DataRowView)cbbTutor.SelectedItem;
                    idTutor = (int)rowView["Id"];
                }

                int idEspecie = 0;
                if (cbbEspecie.SelectedItem != null)
                {
                    DataRowView rowView = (DataRowView)cbbEspecie.SelectedItem;
                    idEspecie = (int)rowView["Id"];
                }

                string dateString = maskedTextBoxDataNasc.Text;

                DateTime.TryParse(dateString, out DateTime dataFormatoDateTime);

                string numeroIdentificacao = maskedTextBoxNumeroIdent.Text;

                string observacoes = txbObs.Text;

                animalService.CadastrarAnimal(idTutor, idEspecie, nome, cor, numeroIdentificacao, dataFormatoDateTime, observacoes);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ConfigurarCampos(int id = 0)
        {
            maskedTextBoxDataNasc.Mask = "00/00/0000";
            maskedTextBoxNumeroIdent.Mask = "999999999999999"; 
            maskedTextBoxNumeroIdent.KeyPress += MaskedTextBoxIntegerOnly_KeyPress;

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Id", typeof(int));
            dataTable.Columns.Add("Nome", typeof(string));

            listaTutores = clienteService.BuscarTutores();

            foreach (var tutor in listaTutores)
            {
                dataTable.Rows.Add(tutor.id, tutor.nome);
            }

            cbbTutor.DataSource = dataTable;
            cbbTutor.DisplayMember = "Nome";

            cbbTutor.SelectedIndex = 0;

            DataTable dataTableEspecie = new DataTable();
            dataTableEspecie.Columns.Add("Id", typeof(int));
            dataTableEspecie.Columns.Add("Especie", typeof(string));

            listaEspecies = animalService.BuscarEspecies();

            foreach (var especie in listaEspecies)
            {
                dataTableEspecie.Rows.Add(especie.id, especie.nome);
            }

            cbbEspecie.DataSource = dataTableEspecie;
            cbbEspecie.DisplayMember = "Especie";

        }

    }
}
