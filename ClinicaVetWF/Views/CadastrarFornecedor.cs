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
using static ClinicaVetWF.Services.EnderecoService;

namespace ClinicaVetWF.Views
{
    public partial class CadastrarFornecedor : Form
    {
        FornecedorService fornecedorService;
        private EnderecoService enderecoService;
        private bool edicao;
        private int idFornecedor;
        public CadastrarFornecedor(bool edicao = false, int idFornecedor = 0)
        {
            InitializeComponent();
            Utils.Validations.AtribuirValidacoes(this);
            maskedTextBoxTelefone.Mask = "(00) 00000-0000";
            maskedTextBoxCNPJ.Mask = "999.999.999-99";
            fornecedorService = new FornecedorService(new Utils.Context());
            enderecoService = new EnderecoService(new Utils.Context());
            this.edicao = edicao;
            this.idFornecedor = idFornecedor;
        }

        private void CadastrarFornecedor_Load(object sender, EventArgs e)
        {
            if (edicao)
            {
                List<fornecedor> fornecedores = new List<fornecedor>();
                fornecedores = fornecedorService.BuscarFornecedor(idFornecedor);
                foreach (var fornecedor in fornecedores)
                {
                    txbNomeFornecedor.Text = fornecedor.Nome;
                    txbEmail.Text = fornecedor.Email;
                    txbEndereco.Text = fornecedor.Endereco;
                    maskedTextBoxCNPJ.Text = fornecedor.CNPJ;
                    maskedTextBoxTelefone.Text = fornecedor.Telefone;
                }
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (!Utils.Validations.ValidarEmail(txbEmail.Text))
            {
                MessageBox.Show("E-mail inválido!", "Erro");
            }
            fornecedor fornecedor = new fornecedor();
            fornecedor.Nome = txbNomeFornecedor.Text;
            fornecedor.Telefone = maskedTextBoxTelefone.Text;
            fornecedor.Email = txbEmail.Text;
            fornecedor.CNPJ = maskedTextBoxCNPJ.Text;
            fornecedor.Endereco = txbEndereco.Text;
            fornecedor.dataCadastro = DateTime.Now;
            if (edicao)
            {
                fornecedor.Id = idFornecedor;
                fornecedorService.EditarFornecedor(fornecedor);
                Utils.Validations.LimparCampos(this);
            }
            else
            {
                fornecedorService.CadastrarFornecedor(fornecedor);
                Utils.Validations.LimparCampos(this);
            }
        }
    }
}
