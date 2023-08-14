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
            Utils.Validations.AtribuirValidacoes(this);
        }
     

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Instancia o contexto do banco de dados
            using (var dbContext = new Utils.Context())
            {
                var funcionarioService = new FuncionarioService(dbContext);

                string login = txbUsuario.Text;
                string senha = txbSenha.Text;

              /*  if(login == "" || senha == "")
                {
                    MessageBox.Show("Preencha todos os campos!", "Atenção!");
                    return;
                }*/
                int idFuncionario = funcionarioService.ValidarLogin(login, senha);

                if (idFuncionario != 0)
                {
                    UserSession.LoggedUserId = idFuncionario;
                    TelaPrincipal telaPrincipal = new TelaPrincipal();
                    telaPrincipal.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Usuário não encontrado");
                }
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txbUsuario.Focus();
            txbSenha.UseSystemPasswordChar = true;
        }

        private void btnNovoFuncionario_Click(object sender, EventArgs e)
        {
            CadastroFuncionario cadastrarFuncionario = new CadastroFuncionario();
            cadastrarFuncionario.ShowDialog();  
        }
    }
}
