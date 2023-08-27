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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace ClinicaVetWF.Views
{
    public partial class CadastrarProduto : Form
    {
        private List<fornecedor> listaFornecedores;
        private ProdutoService produtoService;
        private FornecedorService fornecedorService;
        private bool edicao;
        private int idProduto;
        public CadastrarProduto(bool edicao = false, int idProduto = 0)
        {
            InitializeComponent();
            Utils.Validations.AtribuirValidacoes(this);
            produtoService = new ProdutoService(new Utils.Context());
            fornecedorService = new FornecedorService(new Utils.Context());
            this.edicao = edicao;
            this.idProduto = idProduto;
        }

        private void CadastrarProduto_Load(object sender, EventArgs e)
        {
            if (edicao)
            {
                CarregarInformacoes();
                List<produto> produtos = new List<produto>();
                produtos = produtoService.BuscarProduto(idProduto);
                foreach (var pro in produtos)
                {
                    txbDescricao.Text = pro.nome;
                    Utils.Validations.SelecionarItemPorNome(cbbFornecedor, pro.fornecedor.Nome);
                    maskedTextBoxCodigo.Text = pro.codigo;
                    maskedTextBoxValorCusto.Text = pro.preco_custo.ToString();
                    maskedTextBoxValorVenda.Text = pro.preco.ToString();
                    radioButtonAtivo.Checked = pro.status;
                    
                }
            }
            else
            {
                CarregarInformacoes();
            }

        }

        public void CarregarInformacoes()
        {
            radioButtonAtivo.CheckedChanged += RadioButton_CheckedChanged;
            radioButtonAtivo.CheckedChanged += RadioButton_CheckedChanged;
            radioButtonAtivo.Checked = true;

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

            //cbbFornecedor.SelectedIndex = 0;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            int idFornecedor = 0;
            if (cbbFornecedor.SelectedItem != null)
            {
                DataRowView rowView = (DataRowView)cbbFornecedor.SelectedItem;
                idFornecedor = (int)rowView["Id"];
            }
            produto produto = new produto();
            produto.nome = txbDescricao.Text;
            produto.codigo = maskedTextBoxCodigo.Text;
            produto.preco_custo = decimal.Parse(maskedTextBoxValorCusto.Text);
            produto.preco = decimal.Parse(maskedTextBoxValorVenda.Text);
            produto.fornecedorId = idFornecedor;
            produto.status = radioButtonAtivo.Checked;
            if (edicao)
            {
                produtoService.EditarProduto(produto);
            }
            else
            {
                produtoService.CadastrarProduto(produto);
            }
            
            Utils.Validations.LimparCampos(this);
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonAtivo.Checked)
            {
                radioButtonInativo.Checked = false;
            }
            else if (radioButtonInativo.Checked)
            {
                radioButtonAtivo.Checked = false;
            }
        }
    }
}
