using ClinicaVetWF.Models;
using ClinicaVetWF.Services;
using ClinicaVetWF.Utils;
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
    public partial class Agendamento : Form
    {
        private AnimalService animalService;
        private ServicoService servicoService;
        private ConsultaService consultaService;
        public Agendamento()
        {
            InitializeComponent();

            animalService = new AnimalService(new Utils.Context());
            servicoService = new ServicoService(new Utils.Context());
            consultaService = new ConsultaService(new Utils.Context());

            dateTimePicker.Format = DateTimePickerFormat.Custom;
            dateTimePicker.CustomFormat = "dd/MM/yyyy HH:mm";
            cbbAnimal.SelectedIndexChanged += cbbAnimal_SelectedIndexChanged;
            cbbServico.SelectedIndexChanged += cbbTipoServico_SelectedIndexChanged;
            Utils.Validations.AtribuirValidacoes(this);

        }

        private void AgendarExame_Load(object sender, EventArgs e)
        {
          
            DataTable dataTableAnimais = new DataTable();
            dataTableAnimais.Columns.Add("Id", typeof(int));
            dataTableAnimais.Columns.Add("Nome", typeof(string));
            dataTableAnimais.Columns.Add("TutorNome", typeof(string));
            dataTableAnimais.Columns.Add("IdTutor", typeof(int));

            List<AnimalInfo> animalInfo = new List<AnimalInfo>();
            animalInfo = animalService.BuscarAnimais();

            foreach (AnimalInfo info in animalInfo)
            {
                dataTableAnimais.Rows.Add(info.IdAnimal, info.AnimalNome, info.TutorNome, info.IdTutor);
            }

            cbbAnimal.DataSource = dataTableAnimais;
            cbbAnimal.DisplayMember = "Nome";
            cbbAnimal.SelectedIndex = -1;

            DataTable dataTableServicos = new DataTable();
            dataTableServicos.Columns.Add("Id", typeof(int));
            dataTableServicos.Columns.Add("Nome", typeof(string));
            dataTableServicos.Columns.Add("Valor", typeof(double));

            List<Servicos> servicos = new List<Servicos>();
            servicos = servicoService.BuscarServicos();

            foreach (Servicos servico in servicos)
            {
                dataTableServicos.Rows.Add(servico.ID, servico.Descricao, servico.Valor);
            }

            cbbServico.DataSource = dataTableServicos;
            cbbServico.DisplayMember = "Nome";
            cbbServico.SelectedIndex = -1;

        }

        private void cbbAnimal_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView selectedRow = (DataRowView)cbbAnimal.SelectedItem;
            if (selectedRow != null){
                int id = (int)selectedRow["Id"];
                string nome = selectedRow["Nome"].ToString();
                string tutorNome = selectedRow["TutorNome"].ToString();

                lblTutorNome.Text = tutorNome.ToString();
            }
        }

        private void cbbTipoServico_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView selectedRow = (DataRowView)cbbServico.SelectedItem;
            if(selectedRow != null) 
            {
                int id = (int)selectedRow["Id"];
                string nome = selectedRow["Nome"].ToString();
                double valor = (double)selectedRow["Valor"];

                lblValor.Text = valor.ToString();
            }
        }

        private void datePicker_ValueChanged(object sender, EventArgs e)
        {
            string selectedDateTime = dateTimePicker.Value.ToString("dd/MM/yyyy HH:mm");
            lblDataConsulta.Text = selectedDateTime;
        }

        private void lblValor_Click(object sender, EventArgs e)
        {

        }

        private void btnFinalizarAgendamento_Click(object sender, EventArgs e)
        {

            int idTutor = 0;
            int idAnimal = 0;
            int idTipoServico;
            if (cbbAnimal.SelectedItem != null)
            {
                DataRowView rowView = (DataRowView)cbbAnimal.SelectedItem;
                idTutor = (int)rowView["IdTutor"];
                idAnimal = (int)rowView["Id"];
            }

            
            if (cbbServico.SelectedItem != null)
            {
                DataRowView rowView = (DataRowView)cbbServico.SelectedItem;
                idTipoServico = (int)rowView["Id"];
            }

            string dateString = dateTimePicker.Text;

            DateTime.TryParse(dateString, out DateTime dataFormatoDateTime);

            string observacoes = txbObservacoes.Text;
            int idFuncionario = UserSession.LoggedUserId;
            consultaService.CadastrarConsulta(idTutor, idAnimal, 0, idFuncionario, observacoes, dataFormatoDateTime);
            Utils.Validations.LimparCampos(this);
        }
    }
}
