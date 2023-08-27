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

namespace ClinicaVetWF.Views
{
    public partial class VisualizarProdutos : Form
    {
        private readonly Context _dbContext;
        private ProdutoService produtoService;
        public VisualizarProdutos()
        {
            InitializeComponent();
            _dbContext = new Context();
            produtoService = new ProdutoService(new Utils.Context());
        }

        private void VisualizarProdutos_Load(object sender, EventArgs e)
        {
            List<produto> produtos = new List<produto>();
            produtos = produtoService.BuscarProdutos();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Add("id", "id");
            dataGridView1.Columns.Add("Desricao", "Descrição");
            dataGridView1.Columns.Add("Valor", "Valor");
            dataGridView1.Columns.Add("Custo", "Custo");
            dataGridView1.Columns.Add("Fornecedor", "Fornecedor");
            dataGridView1.Columns.Add("Ativo", "Ativo");

            DataGridViewButtonColumn buttonColumnExcluir = new DataGridViewButtonColumn();
            buttonColumnExcluir.HeaderText = "Excluir";
            buttonColumnExcluir.Name = "ColExcluir";
            buttonColumnExcluir.Text = "Excluir";
            buttonColumnExcluir.UseColumnTextForButtonValue = true;

            buttonColumnExcluir.DefaultCellStyle.BackColor = Color.Red;
            buttonColumnExcluir.DefaultCellStyle.ForeColor = Color.White;
            buttonColumnExcluir.DefaultCellStyle.Font = new Font(dataGridView1.DefaultCellStyle.Font, FontStyle.Bold); 
            buttonColumnExcluir.DefaultCellStyle.SelectionBackColor = buttonColumnExcluir.DefaultCellStyle.BackColor; 

            DataGridViewButtonColumn buttonColumnEditar = new DataGridViewButtonColumn();
            buttonColumnEditar.HeaderText = "Editar";
            buttonColumnEditar.Name = "ColEditar";
            buttonColumnEditar.Text = "Editar";
            buttonColumnEditar.UseColumnTextForButtonValue = true;

            buttonColumnEditar.DefaultCellStyle.BackColor = Color.Green;
            buttonColumnEditar.DefaultCellStyle.ForeColor = Color.White;
            buttonColumnEditar.DefaultCellStyle.Font = new Font(dataGridView1.DefaultCellStyle.Font, FontStyle.Bold); 
            buttonColumnEditar.DefaultCellStyle.SelectionBackColor = buttonColumnEditar.DefaultCellStyle.BackColor;

            dataGridView1.Columns.Add(buttonColumnExcluir);
            dataGridView1.Columns.Add(buttonColumnEditar);

            foreach (var prod in produtos)
            {

                dataGridView1.Rows.Add(prod.id, prod.nome, prod.preco, prod.preco_custo, prod.fornecedor.Nome, prod.status);

            }

            dataGridView1.CellClick += dataGridView1_CellClick;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dataGridView1.Columns["ColExcluir"].Index)
                {
                    DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                    int id = Convert.ToInt32(selectedRow.Cells["id"].Value);

                    produtoService.ExcluirProduto(id);

                    dataGridView1.Rows.RemoveAt(e.RowIndex);

                }
                else if (e.ColumnIndex == dataGridView1.Columns["ColEditar"].Index)
                {
                    DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                    int id = Convert.ToInt32(selectedRow.Cells["id"].Value);

                    CadastrarProduto cadastrarProduto = new CadastrarProduto(true, id);
                    cadastrarProduto.ShowDialog();
                }
            }
        }

        private void btnCadastrarProduto_Click(object sender, EventArgs e)
        {
            CadastrarProduto cadastrarProduto = new CadastrarProduto();
            cadastrarProduto.ShowDialog();

        }
    }
}
