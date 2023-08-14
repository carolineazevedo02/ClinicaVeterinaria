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
    public partial class VisualizarAnimais : Form
    {
        private AnimalService animalService;
        public VisualizarAnimais()
        {
            InitializeComponent();

            animalService = new AnimalService(new Utils.Context());
            dataGridViewAnimais.CellClick += DataGridView_CellClick;

        }

        private void VisualizarAnimais_Load(object sender, EventArgs e)
        {
            panelLista.Anchor = AnchorStyles.Bottom;
            panelLista.Dock = DockStyle.Bottom;
            dataGridViewAnimais.Dock = DockStyle.Fill;
            dataGridViewAnimais.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
           
            dataGridViewAnimais.ReadOnly = true;

            dataGridViewAnimais.SelectionMode = DataGridViewSelectionMode.FullRowSelect; 
            dataGridViewAnimais
                .MultiSelect = false; 

            List<AnimalInfo> animais = new List<AnimalInfo>();

            animais = animalService.BuscarAnimais();

            dataGridViewAnimais.AutoGenerateColumns = false;
            dataGridViewAnimais.Columns.Add("ColAnimalNome", "Nome do Animal");
            dataGridViewAnimais.Columns.Add("ColTutorNome", "Nome do Tutor");
            dataGridViewAnimais.Columns.Add("ColDataNasc", "Data Nasc");
            dataGridViewAnimais.Columns.Add("ColEspecieNome", "Espécie");
            dataGridViewAnimais.Columns.Add("ColObservacoes", "Observações");
            dataGridViewAnimais.Columns.Add("ColIdAnimal", "Id");
            dataGridViewAnimais.Columns["ColIdAnimal"].Visible = false;


            DataGridViewButtonColumn buttonColumnExcluir = new DataGridViewButtonColumn();
            buttonColumnExcluir.HeaderText = "Excluir";
            buttonColumnExcluir.Name = "ColExcluir";
            buttonColumnExcluir.Text = "Excluir";
            buttonColumnExcluir.UseColumnTextForButtonValue = true;
            buttonColumnExcluir.Width = 50;

            buttonColumnExcluir.DefaultCellStyle.BackColor = Color.Red; 
            buttonColumnExcluir.DefaultCellStyle.ForeColor = Color.White; 
            buttonColumnExcluir.DefaultCellStyle.Font = new Font(dataGridViewAnimais.DefaultCellStyle.Font, FontStyle.Bold); // Estilo da fonte do botão
            buttonColumnExcluir.DefaultCellStyle.SelectionBackColor = buttonColumnExcluir.DefaultCellStyle.BackColor; // Cor de fundo quando selecionado

            DataGridViewButtonColumn buttonColumnEditar = new DataGridViewButtonColumn();
            buttonColumnEditar.HeaderText = "Editar";
            buttonColumnEditar.Name = "ColEditar";
            buttonColumnEditar.Text = "Editar";
            buttonColumnEditar.UseColumnTextForButtonValue = true;

            buttonColumnEditar.DefaultCellStyle.BackColor = Color.Green; 
            buttonColumnEditar.DefaultCellStyle.ForeColor = Color.White; 
            buttonColumnEditar.DefaultCellStyle.Font = new Font(dataGridViewAnimais.DefaultCellStyle.Font, FontStyle.Bold); // Estilo da fonte do botão
            buttonColumnEditar.DefaultCellStyle.SelectionBackColor = buttonColumnEditar.DefaultCellStyle.BackColor; // Cor de fundo quando selecionado

            dataGridViewAnimais.Columns.Add(buttonColumnExcluir);
            dataGridViewAnimais.Columns.Add(buttonColumnEditar);
           

            foreach (var animal in animais) {

                dataGridViewAnimais.Rows.Add(animal.AnimalNome, animal.TutorNome, animal.DataNascimento.Date, animal.EspecieNome, animal.Observacoes, animal.IdAnimal);

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCadastrarAnimal_Click(object sender, EventArgs e)
        {
            CadastrarAnimal cadastrarAnimal = new CadastrarAnimal(false, 1);
            cadastrarAnimal.ShowDialog();
        }

        private void DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dataGridViewAnimais.Columns["ColExcluir"].Index)
                {
                    DataGridViewRow selectedRow = dataGridViewAnimais.Rows[e.RowIndex];
                    int idAnimal = Convert.ToInt32(selectedRow.Cells["ColIdAnimal"].Value);

                    string id = idAnimal.ToString();
                    animalService.ExcluirAnimal(idAnimal);

                    dataGridViewAnimais.Rows.RemoveAt(e.RowIndex);
                }
                else if (e.ColumnIndex == dataGridViewAnimais.Columns["ColEditar"].Index)
                {
                    DataGridViewRow selectedRow = dataGridViewAnimais.Rows[e.RowIndex];
                    int idAnimal = Convert.ToInt32(selectedRow.Cells["ColIdAnimal"].Value);

                   CadastrarAnimal cadastrarAnimal = new CadastrarAnimal(true, idAnimal);
                   cadastrarAnimal.ShowDialog();
                    dataGridViewAnimais.Refresh(); 
                }
            }
        }

    }
}
