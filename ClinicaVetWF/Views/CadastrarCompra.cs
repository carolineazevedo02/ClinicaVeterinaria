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
    public partial class CadastrarCompra : Form
    {
        private List<fornecedor> listaFornecedores;
        private List<produto> listaProdutos;
        private FornecedorService fornecedorService;
        private ProdutoService produtoService;
        private CompraService compraService;
        private bool edicao;
        private int idCompra;
        public CadastrarCompra(bool edicao = false, int idCompra = 0)
        {
            InitializeComponent();
            fornecedorService = new FornecedorService(new Utils.Context());
            produtoService = new ProdutoService(new Utils.Context());
            compraService = new CompraService(new Utils.Context());
            cbbProdsFornecedor.SelectedIndexChanged += new EventHandler(cbbProdsFornecedor_SelectedIndexChanged);
            maskedTextBoxQtd.TextChanged += new EventHandler(maskedTextBox1_TextChanged);
            this.edicao = edicao;
            this.idCompra = idCompra;

        }

        private void CadastrarCompra_Load(object sender, EventArgs e)
        {
            if (edicao)
            {
                CarregarInformacoes();
                List<compra> compras = new List<compra>();
                compras = compraService.BuscarCompra(idCompra);
                foreach (var compra in compras)
                {
                    Utils.Validations.SelecionarItemPorNome(cbbFornecedor, compra.Fornecedor.Nome);
                    Utils.Validations.SelecionarItemPorNome(cbbProdsFornecedor, compra.Produto.nome);
                    lblTotal.Text = compra.ValorTotal.ToString();
                    maskedTextBoxQtd.Text = compra.Quantidade.ToString();
                }
            }
            else
            {
                CarregarInformacoes();
            }

        }
        public void CarregarInformacoes()
        {
            maskedTextBoxQtd.Text = "1";
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Id", typeof(int));
            dataTable.Columns.Add("Nome", typeof(string));

            listaFornecedores = fornecedorService.BuscarFornecedores();

            foreach (var fornecedor in listaFornecedores)
            {
                dataTable.Rows.Add(fornecedor.Id, fornecedor.Nome);
            }

            cbbFornecedor.DataSource = dataTable;
            cbbFornecedor.DisplayMember = "Nome";
            cbbFornecedor.SelectedIndex = -1;
            /**************************************/

            DataTable dataTableProd = new DataTable();
            dataTableProd.Columns.Add("Id", typeof(int));
            dataTableProd.Columns.Add("Nome", typeof(string));
            dataTableProd.Columns.Add("Valor", typeof(decimal));

            listaProdutos = produtoService.BuscarProdutos();

            foreach (var produto in listaProdutos)
            {
                dataTableProd.Rows.Add(produto.id, produto.nome, produto.preco);
            }

            cbbProdsFornecedor.DataSource = dataTableProd;
            cbbProdsFornecedor.DisplayMember = "Nome";
            cbbProdsFornecedor.SelectedIndex = -1;
        }
        private void cbbProdsFornecedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbProdsFornecedor.SelectedIndex != -1)
            {
                DataRowView selectedRow = (DataRowView)cbbProdsFornecedor.SelectedItem;

                if (selectedRow != null)
                {
                    if (decimal.TryParse(maskedTextBoxQtd.Text, out decimal valor))
                    {
                        decimal valorProduto = (decimal)selectedRow["valor"];
                        lblTotal.Text = (valorProduto * valor).ToString();
                    }
                }
            }
            else
            {
                lblTotal.Text = "Nenhum produto selecionado";
            }
        }

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (cbbProdsFornecedor.SelectedIndex != -1)
            {
                DataRowView selectedRow = (DataRowView)cbbProdsFornecedor.SelectedItem;

                if (selectedRow != null)
                {
                    if (decimal.TryParse(maskedTextBoxQtd.Text, out decimal valor))
                    {
                        decimal valorProduto = (decimal)selectedRow["valor"];
                        lblTotal.Text = (valorProduto * valor).ToString();
                    }
                }
            }
            else
            {
                lblTotal.Text = "Nenhum produto selecionado";
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            compra compra = new compra();
            int idFornecedor = 0;
            if (cbbFornecedor.SelectedItem != null)
            {
                DataRowView rowView = (DataRowView)cbbFornecedor.SelectedItem;
                idFornecedor = (int)rowView["Id"];
            }

            int idProduto = 0;
            if (cbbProdsFornecedor.SelectedItem != null)
            {
                DataRowView rowView = (DataRowView)cbbProdsFornecedor.SelectedItem;
                idProduto = (int)rowView["Id"];
            }

            compra.IdFornecedor = idFornecedor;
            compra.IdProduto = idProduto;
            compra.ValorTotal = decimal.Parse(lblTotal.Text);
            compra.Quantidade = int.Parse(maskedTextBoxQtd.Text);
            compra.Cancelada = false;
            compra.DataCompra = DateTime.Now;
            if (edicao)
            {
                compra.Id = idCompra;
                compraService.EditarCompra(compra);
                this.Close();
            }
            else
            {
                compraService.AdicionarCompra(compra);
            }
            Utils.Validations.LimparCampos(this);
        }
    }
}
