using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaVetWF.Utils
{
    internal class Validations
    {
        public static bool ValidarEmail(string email)
        {
            string emailValidar = email.Trim();

            // Define a expressão regular para validar o formato do e-mail.
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            // Realiza a validação utilizando a expressão regular.
            if (Regex.IsMatch(emailValidar, pattern))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool ValidarCPF(string cpf)
        {
            return cpf.Length == 11;
        }

        public static void CampoVazioTextBox_Validating(object sender, CancelEventArgs e)
        {
            ErrorProvider errorProvider = new ErrorProvider();

            TextBox textBox = (TextBox)sender;
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(textBox, "Este campo não pode ser vazio.");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(textBox, ""); // Limpar mensagem de erro, se houver.
            }
        }

        public static void CampoVazioComboBox_Validating(object sender, CancelEventArgs e)
        {
            ErrorProvider errorProvider = new ErrorProvider();
            ComboBox comboBox = (ComboBox)sender;
            if (comboBox.SelectedIndex == -1) // Verifica se nenhum item foi selecionado
            {
                e.Cancel = true;
                errorProvider.SetError(comboBox, "Selecione um item válido."); // Exibe a mensagem de erro
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(comboBox, ""); // Limpa a mensagem de erro, se houver
            }
        }

        public static void CampoVazioMaskedTextBox_Validating(object sender, CancelEventArgs e)
        {
            ErrorProvider errorProvider = new ErrorProvider();
            MaskedTextBox maskedTextBox = (MaskedTextBox)sender;
            if (maskedTextBox.MaskCompleted) // Verifica se a máscara foi totalmente preenchida
            {
                e.Cancel = false;
                errorProvider.SetError(maskedTextBox, ""); // Limpa a mensagem de erro, se houver
            }
            else
            {
                e.Cancel = true;
                errorProvider.SetError(maskedTextBox, "Preencha o campo corretamente."); // Exibe a mensagem de erro
            }
        }

    }
}
