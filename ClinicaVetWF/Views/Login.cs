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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
     

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Instancia o contexto do banco de dados
            using (var dbContext = new db_clinicaEntities1())
            {
                var funcionarioService = new FuncionarioService(dbContext);

                string login = txbUsuario.Text;
                string senha = txbSenha.Text;

                if(login == "" || senha == "")
                {
                    MessageBox.Show("Preencha todos os campos!", "Atenção!");
                    return;
                }
                bool loginValido = funcionarioService.ValidarLogin(login, senha);

                if (loginValido)
                {
                    
                    TelaPrincipal telaPrincipal = new TelaPrincipal();
                    telaPrincipal.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Usuário não encontrado");
                }
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            // Configurar o TextBox de senha para exibir asteriscos em vez dos caracteres digitados.
            txbSenha.UseSystemPasswordChar = true;
        }

        private void btnNovoFuncionario_Click(object sender, EventArgs e)
        {
            CadastroFuncionario cadastrarFuncionario = new CadastroFuncionario();
            cadastrarFuncionario.ShowDialog();  
        }
    }
}
