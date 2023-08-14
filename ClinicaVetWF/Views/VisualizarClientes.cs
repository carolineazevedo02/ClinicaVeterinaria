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
    public partial class VisualizarClientes : Form
    {
        private ClienteService clienteService;
        public VisualizarClientes()
        {
            InitializeComponent();
            clienteService = new ClienteService(new Utils.Context());
            dataGridViewClientes.CellClick += DataGridView_CellClick;
        }

        private void VisualizarClientes_Load(object sender, EventArgs e)
        {
            List<cliente> clientes = new List<cliente>();

            clientes = clienteService.BuscarTutores();

            dataGridViewClientes.ReadOnly = true;
            dataGridViewClientes.Dock = DockStyle.Fill;
            dataGridViewClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewClientes
                .MultiSelect = false;


            DataGridViewButtonColumn buttonColumnExcluir = new DataGridViewButtonColumn();
            buttonColumnExcluir.HeaderText = "Excluir";
            buttonColumnExcluir.Name = "ColExcluir";
            buttonColumnExcluir.Text = "Excluir";
            buttonColumnExcluir.UseColumnTextForButtonValue = true;
            buttonColumnExcluir.Width = 50;

            buttonColumnExcluir.DefaultCellStyle.BackColor = Color.Red; 
            buttonColumnExcluir.DefaultCellStyle.ForeColor = Color.White; 
            buttonColumnExcluir.DefaultCellStyle.Font = new Font(dataGridViewClientes.DefaultCellStyle.Font, FontStyle.Bold); // Estilo da fonte do botão
            buttonColumnExcluir.DefaultCellStyle.SelectionBackColor = buttonColumnExcluir.DefaultCellStyle.BackColor; // Cor de fundo quando selecionado

            DataGridViewButtonColumn buttonColumnEditar = new DataGridViewButtonColumn();
            buttonColumnEditar.HeaderText = "Editar";
            buttonColumnEditar.Name = "ColEditar";
            buttonColumnEditar.Text = "Editar";
            buttonColumnEditar.UseColumnTextForButtonValue = true;

            buttonColumnEditar.DefaultCellStyle.BackColor = Color.Green; 
            buttonColumnEditar.DefaultCellStyle.ForeColor = Color.White; 
            buttonColumnEditar.DefaultCellStyle.Font = new Font(dataGridViewClientes.DefaultCellStyle.Font, FontStyle.Bold); // Estilo da fonte do botão
            buttonColumnEditar.DefaultCellStyle.SelectionBackColor = buttonColumnEditar.DefaultCellStyle.BackColor; // Cor de fundo quando selecionado


            dataGridViewClientes.AutoGenerateColumns = false;
            dataGridViewClientes.Columns.Add("ColClienteNome", "Nome");
            dataGridViewClientes.Columns.Add("ColClienteTelefone", "Telefone");
            dataGridViewClientes.Columns.Add("ColClienteEmail", "Email");
            dataGridViewClientes.Columns.Add("ColClienteCPF", "CPF");
            dataGridViewClientes.Columns.Add("ColIdCliente", "Id");
            dataGridViewClientes.Columns["ColIdCliente"].Visible = false;

            dataGridViewClientes.Columns.Add(buttonColumnExcluir);
            dataGridViewClientes.Columns.Add(buttonColumnEditar);

            foreach (var cliente in clientes)
            {
                dataGridViewClientes.Rows.Add(cliente.nome, cliente.telefone, cliente.email, cliente.cpf,cliente.id);
            }
        }

        private void DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dataGridViewClientes.Columns["ColExcluir"].Index)
                {
                    DataGridViewRow selectedRow = dataGridViewClientes.Rows[e.RowIndex];
                    int idCliente = Convert.ToInt32(selectedRow.Cells["ColIdCliente"].Value);

                    string id = idCliente.ToString();
                    clienteService.ExcluirCliente(idCliente);

                    dataGridViewClientes.Rows.RemoveAt(e.RowIndex);
                }
                else if (e.ColumnIndex == dataGridViewClientes.Columns["ColEditar"].Index)
                {
                    DataGridViewRow selectedRow = dataGridViewClientes.Rows[e.RowIndex];
                    int idCliente = Convert.ToInt32(selectedRow.Cells["ColIdCliente"].Value);

                    CadastroCliente cadastrarCliente = new CadastroCliente(true, idCliente);
                    cadastrarCliente.ShowDialog();
                    dataGridViewClientes.Refresh();
                }
            }
        }

        private void btnCadastrarCliente_Click(object sender, EventArgs e)
        {
            CadastroCliente cadastroCliente = new CadastroCliente();
            cadastroCliente.ShowDialog();
        }
    }
}
