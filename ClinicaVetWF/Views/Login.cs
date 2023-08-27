using ClinicaVetWF.Migrations;
using ClinicaVetWF.Models;
using ClinicaVetWF.Services;
using ClinicaVetWF.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ClinicaVetWF.Views
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            Utils.Validations.AtribuirValidacoes(this);
            btnLogin.KeyPress += new KeyPressEventHandler(btnLogin_KeyPress);
            txbUsuario.KeyDown += TxbUsuario_KeyPress;
            txbSenha.KeyDown += TxbSenha_KeyPress;

        }

        private void TxbSenha_KeyPress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void TxbUsuario_KeyPress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txbSenha.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void Logar()
        {
            try
            {
                using (var dbContext = new Utils.Context())
                {
                    var funcionarioService = new FuncionarioService(dbContext);
                    string login = txbUsuario.Text;
                    string senha = txbSenha.Text;

                    progressBar1.Maximum = 100;
                    progressBar1.Value += 20;
                    progressBar1.Value += 20;
                    progressBar1.Value += 20;

                    int idFuncionario = funcionarioService.ValidarLogin(login, senha);
                    progressBar1.Value += 20;
                    progressBar1.Value += 20;
                    if (idFuncionario != 0)
                    {
                        UserSession.LoggedUserId = idFuncionario;
                        TelaPrincipal telaPrincipal = new TelaPrincipal();
                        this.Hide();
                        telaPrincipal.ShowDialog();
                    }
                    else
                    {
                        progressBar1.Value = 0;
                        MessageBox.Show("Usuário não encontrado");
                        progressBar1.Value = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro", ex.Message);
            }
            finally
            {
                progressBar1.Value = progressBar1.Maximum;
            }
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            Logar();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txbUsuario.Focus();
            txbSenha.UseSystemPasswordChar = true;
        }

        private void btnNovoFuncionario_Click(object sender, EventArgs e)
        {
            txbUsuario.Validating += null;
            txbSenha.Validating += null;
        }

        private void btnLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Logar();
            }

        }

        private void campoUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void campoSenha_KeyDown(object sender, KeyEventArgs e)
        {
            
        }
    }
}
