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
using static ClinicaVetWF.Services.ConsultaService;
using static System.Windows.Forms.ListViewItem;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ClinicaVetWF.Views
{
    public partial class VisualizarConsultas : Form
    {
        private ConsultaService consultaService;
        public VisualizarConsultas()
        {
            InitializeComponent();
            consultaService = new ConsultaService(new Utils.Context());
            dataGridView.CellClick += DataGridView_CellClick;
        }

        private void VisualizarConsultas_Load(object sender, EventArgs e)
        {
            List<ConsultaInfo> consultas = new List<ConsultaInfo>();

            consultas = consultaService.BuscarConsultas();

            dataGridView.ReadOnly = true;
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView
                .MultiSelect = false;


            DataGridViewButtonColumn buttonColumnExcluir = new DataGridViewButtonColumn();
            buttonColumnExcluir.HeaderText = "Excluir";
            buttonColumnExcluir.Name = "ColExcluir";
            buttonColumnExcluir.Text = "Excluir";
            buttonColumnExcluir.UseColumnTextForButtonValue = true;
            buttonColumnExcluir.Width = 50;

            buttonColumnExcluir.DefaultCellStyle.BackColor = Color.Red;
            buttonColumnExcluir.DefaultCellStyle.ForeColor = Color.White;
            buttonColumnExcluir.DefaultCellStyle.Font = new Font(dataGridView.DefaultCellStyle.Font, FontStyle.Bold); // Estilo da fonte do botão
            buttonColumnExcluir.DefaultCellStyle.SelectionBackColor = buttonColumnExcluir.DefaultCellStyle.BackColor; // Cor de fundo quando selecionado

            DataGridViewButtonColumn buttonColumnEditar = new DataGridViewButtonColumn();
            buttonColumnEditar.HeaderText = "Editar";
            buttonColumnEditar.Name = "ColEditar";
            buttonColumnEditar.Text = "Editar";
            buttonColumnEditar.UseColumnTextForButtonValue = true;

            buttonColumnEditar.DefaultCellStyle.BackColor = Color.Green;
            buttonColumnEditar.DefaultCellStyle.ForeColor = Color.White;
            buttonColumnEditar.DefaultCellStyle.Font = new Font(dataGridView.DefaultCellStyle.Font, FontStyle.Bold); // Estilo da fonte do botão
            buttonColumnEditar.DefaultCellStyle.SelectionBackColor = buttonColumnEditar.DefaultCellStyle.BackColor; // Cor de fundo quando selecionado


            dataGridView.AutoGenerateColumns = false;
            dataGridView.Columns.Add("ColClienteNome", "Nome");
            dataGridView.Columns.Add("ColAnimalNome", "Animal");
            dataGridView.Columns.Add("ColData", "Data");
            dataGridView.Columns.Add("ColIdConsulta", "Id");
            dataGridView.Columns["ColIdConsulta"].Visible = false;

            dataGridView.Columns.Add(buttonColumnExcluir);
            dataGridView.Columns.Add(buttonColumnEditar);

            foreach (var consulta in consultas)
            {
                dataGridView.Rows.Add(consulta.TutorNome, consulta.AnimalNome, consulta.DataConsulta, consulta.IdConsulta);
            }

        }

        private void DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dataGridView.Columns["ColExcluir"].Index)
                {
                    DataGridViewRow selectedRow = dataGridView.Rows[e.RowIndex];
                    int idConsulta= Convert.ToInt32(selectedRow.Cells["ColIdConsulta"].Value);

                    consultaService.ExcluirConsulta(idConsulta);

                    dataGridView.Rows.RemoveAt(e.RowIndex);
                }
                else if (e.ColumnIndex == dataGridView.Columns["ColEditar"].Index)
                {
                    
                    DataGridViewRow selectedRow = dataGridView.Rows[e.RowIndex];
                    int idCliente = Convert.ToInt32(selectedRow.Cells["ColIdConsulta"].Value);

                    Agendamento agendamento = new Agendamento(true, idCliente);
                    agendamento.ShowDialog();
                }


            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAgendar_Click(object sender, EventArgs e)
        {
            Agendamento agendarExame = new Agendamento(false);
           agendarExame.ShowDialog();
        }
    }
}
