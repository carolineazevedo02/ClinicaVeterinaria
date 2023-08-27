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

namespace ClinicaVetWF.Views
{
    public partial class VisualizarFornecedores : Form
    {
        private FornecedorService fornecedorService;
        public VisualizarFornecedores()
        {
            InitializeComponent();

            fornecedorService = new FornecedorService(new Utils.Context());
        }

        private void btnCadastrarFornecedor_Click(object sender, EventArgs e)
        {
            CadastrarFornecedor cadastrarFornecedor = new CadastrarFornecedor();
            cadastrarFornecedor.ShowDialog();
        }

        public void CarregarInformacoes()
        {
            dataGridView1.DataSource = null;
            dataGridView1.Columns.Clear();

            List<fornecedor> fornecedores = new List<fornecedor>();
            fornecedores = fornecedorService.BuscarFornecedores();
            dataGridView1.AutoGenerateColumns = false;

            dataGridView1.Columns.Add("id", "id");
            dataGridView1.Columns.Add("Descrição", "Descricao");
            dataGridView1.Columns.Add("E-mail", "Email");
            dataGridView1.Columns.Add("CNPJ", "CNPJ");
            dataGridView1.Columns.Add("Telefone", "Telefone");
            dataGridView1.Columns.Add("Endereço", "Endereco");


            DataGridViewButtonColumn buttonColumnEditar = new DataGridViewButtonColumn();
            buttonColumnEditar.HeaderText = "Editar";
            buttonColumnEditar.Name = "ColEditar";
            buttonColumnEditar.Text = "Editar";
            buttonColumnEditar.UseColumnTextForButtonValue = true;

            buttonColumnEditar.DefaultCellStyle.BackColor = Color.Green;
            buttonColumnEditar.DefaultCellStyle.ForeColor = Color.White;
            buttonColumnEditar.DefaultCellStyle.Font = new Font(dataGridView1.DefaultCellStyle.Font, FontStyle.Bold);
            buttonColumnEditar.DefaultCellStyle.SelectionBackColor = buttonColumnEditar.DefaultCellStyle.BackColor;

            dataGridView1.Columns.Add(buttonColumnEditar);

            foreach (var fornecedor in fornecedores)
            {

                dataGridView1.Rows.Add(fornecedor.Id, fornecedor.Nome,
                    fornecedor.Email, fornecedor.CNPJ, fornecedor.Telefone, fornecedor.Endereco);

            }

            dataGridView1.CellClick += dataGridView1_CellClick;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dataGridView1.Columns["ColEditar"].Index)
                {
                    DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                    int id = Convert.ToInt32(selectedRow.Cells["id"].Value);

                    CadastrarFornecedor cadastrarFornecedor = new CadastrarFornecedor(true, id);
                    cadastrarFornecedor.ShowDialog();
                    
                }
            }
            CarregarInformacoes();
        }

        private void VisualizarFornecedores_Load(object sender, EventArgs e)
        {
            CarregarInformacoes();
        }
    }
}
