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
    public partial class CadastrarTipoProfissional : Form
    {
        private TipoProfissionalService tipoProfissionalService;
        public CadastrarTipoProfissional()
        {
            InitializeComponent();
            Utils.Validations.AtribuirValidacoes(this);
            tipoProfissionalService = new TipoProfissionalService(new Utils.Context());

        }

        private void CadastrarTipoProfissional_Load(object sender, EventArgs e)
        {
            
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string descricaoProfissional = txbDescricaoProfissional.Text;
            if(descricaoProfissional == "")
            {
                MessageBox.Show("Preencha o campo!");
                txbDescricaoProfissional.Focus();
                return;
            }
            tipoProfissionalService.CadastrarTipoProfissional(descricaoProfissional);
            txbDescricaoProfissional.Text = "";
        }
    }
}
