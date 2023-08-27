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
    public partial class VisualizarCompras : Form
    {
        private CompraService compraService;
        public VisualizarCompras()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            compraService = new CompraService(new Utils.Context());
        }

        private void btnCadastrarCompra_Click(object sender, EventArgs e)
        {
            CadastrarCompra cadastrarCompra = new CadastrarCompra();
            cadastrarCompra.ShowDialog();
        }

        private void VisualizarCompras_Load(object sender, EventArgs e)
        {
            CarregarInformacoes();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dataGridView1.Columns["ColExcluir"].Index)
                {
                    DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                    int id = Convert.ToInt32(selectedRow.Cells["id"].Value);

                    compraService.ExcluirCompra(id);

                    dataGridView1.Rows.RemoveAt(e.RowIndex);

                }
                else if (e.ColumnIndex == dataGridView1.Columns["ColEditar"].Index)
                {
                    DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                    int id = Convert.ToInt32(selectedRow.Cells["id"].Value);

                    CadastrarCompra cadastrarCompra = new CadastrarCompra(true, id);
                    cadastrarCompra.ShowDialog();
                    CarregarInformacoes();
                }
            }
        }

        public void CarregarInformacoes()
        {
            dataGridView1.DataSource = null;
            dataGridView1.Columns.Clear();
            List<compra> compras = new List<compra>();
            compras = compraService.BuscarCompras();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Add("id", "id");
            dataGridView1.Columns.Add("idProduto", "idProduto");
            dataGridView1.Columns.Add("Produto", "Produto");
            dataGridView1.Columns.Add("idFornecedor", "idFornecedor");
            dataGridView1.Columns.Add("Fornecedor", "Fornecedor");
            dataGridView1.Columns.Add("Valor Total", "Valor");
            dataGridView1.Columns.Add("Cancelada", "Cancelada");

            dataGridView1.Columns["idProduto"].Visible = false;
            dataGridView1.Columns["idFornecedor"].Visible = false;
            dataGridView1.Columns["id"].Width = 50;
            dataGridView1.Columns["Produto"].Width = 300;
            dataGridView1.Columns["Fornecedor"].Width = 300;

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

            foreach (var compra in compras)
            {

                dataGridView1.Rows.Add(compra.Id, compra.Produto.id, compra.Produto.nome,
                    compra.Fornecedor.Id, compra.Fornecedor.Nome, compra.ValorTotal.ToString(), compra.Cancelada);

            }

            dataGridView1.CellClick += dataGridView1_CellClick;
        }
    }
}
