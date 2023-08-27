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
    public partial class CadastroFuncionario : Form
    {
        private FuncionarioService funcionarioService;
        private List<cargo> listaCargos;
        public CadastroFuncionario()
        {
            InitializeComponent();
            funcionarioService = new FuncionarioService(new Utils.Context());
        }

        private void btnConfirmarCadastroUsuario_Click(object sender, EventArgs e)
        {
            int idSelecionado = 0; 
            if (cbCargos.SelectedItem != null)
            {
                DataRowView rowView = (DataRowView)cbCargos.SelectedItem;
                idSelecionado = (int)rowView["Id"];
            }

            int idCargo = idSelecionado;
            string nome = txbNomeCadastroFuncionario.Text;
            string email = txbEmailCadastroFuncionario.Text;
            string login = txbLoginCadastro.Text;
            string senha = txbSenhaCadastro.Text;
            DateTime dataCriacao = DateTime.Now;

            if (!Utils.Validations.ValidarEmail(email))
            {
                MessageBox.Show("E-mail inválido", "Atenção");
                return;
            }

            int idFuncionaro = funcionarioService.CadastrarFuncionario(idCargo, nome, email, login, senha, dataCriacao);

            bool MenuCliente = false;
            bool MenuClinica = false;
            bool MenuFornecedor = false;
            bool MenuProdutos = false;
            bool MenuRelatorio = false;
            bool MenuFuncionario = false;
            foreach (object item in checkedListBox1.CheckedItems)
            {
                string itemSelecionado = item.ToString();

                switch (itemSelecionado)
                {
                    case "Menu Clientes":
                        MenuCliente = true;
                        break;
                    case "Menu Clínica ":
                        MenuClinica = true;
                        break;
                    case "Menu Produtos":
                        MenuProdutos = true;
                        break;
                    case "Menu Fornecedor":
                        MenuFornecedor = true;
                        break;
                    case "Menu Relatórios":
                        MenuRelatorio = true;
                        break;
                    case "Menu Funcionários":
                        MenuFuncionario = true;
                        break;
                    default:
                        Console.WriteLine("Opção não reconhecida.");
                        break;
                }
            }

            funcionarioService.CadastrarPermissoes(idFuncionaro, MenuCliente, MenuClinica, MenuFornecedor, MenuProdutos, MenuRelatorio, MenuFuncionario);
            Utils.Validations.LimparCampos(this);
        }

        private void CadastroFuncionario_Load(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Id", typeof(int));
            dataTable.Columns.Add("Cargo", typeof(string));

            listaCargos = funcionarioService.BuscarCargos();

            foreach(var cargo in listaCargos)
            {
                dataTable.Rows.Add(cargo.id, cargo.nome);
            }
            
            cbCargos.DataSource = dataTable;
            cbCargos.DisplayMember = "Cargo"; 

            cbCargos.SelectedIndex = 0;

            txbSenhaCadastro.UseSystemPasswordChar = true;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbCargos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
