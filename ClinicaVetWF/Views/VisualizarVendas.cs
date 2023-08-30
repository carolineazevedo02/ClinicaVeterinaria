using ClinicaVetWF.Models;
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
using static ClinicaVetWF.Services.RelatoriosService;
using static ClinicaVetWF.Services.VendaService;

namespace ClinicaVetWF.Views
{
    public partial class VisualizarVendas : Form
    {
        private readonly Context _dbContext;
        private VendaService vendaService;
        private RelatoriosService relatoriosService;
        public VisualizarVendas()
        {
            InitializeComponent();
            vendaService = new VendaService(new Context());
            relatoriosService = new RelatoriosService(new Utils.Context());
            maskedTextBoxDataFinal.KeyDown += maskedTextBoxDataFinal_KeyDown;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private List<VendaRelatorio> VerificarCamposData()
        {
            if (IsDataValida(maskedTextBoxDataInicial.Text) && IsDataValida(maskedTextBoxDataFinal.Text))
            {
                return relatoriosService.GerarRelatorioVendas
                     (maskedTextBoxDataInicial.Text, maskedTextBoxDataFinal.Text, false, true);
                  
            }
            return null;
        }
        private bool IsDataValida(string data)
        {
            DateTime result;
            return DateTime.TryParse(data, out result);
        }

        private void VisualizarVendas_Load(object sender, EventArgs e)
        {
            CarregarVendas(false);
        }
        public void CarregarVendas(bool filtro)
        {
            List<VendaRelatorio> Vendas;
            if (filtro)
            {
               Vendas = VerificarCamposData();
            }
            else
            {
                DateTime agora = DateTime.Now;
                DateTime inicioDoDia = new DateTime(agora.Year, agora.Month, agora.Day, 0, 0, 0);
                DateTime fimDoDia = new DateTime(agora.Year, agora.Month, agora.Day, 23, 59, 59);
                Vendas = relatoriosService.GerarRelatorioVendas(inicioDoDia.ToString(), fimDoDia.ToString(), false, true);

            }
            PopularListView(Vendas);

        }
        public void PopularListView(List<VendaRelatorio> Vendas)
        {
            listViewVendas.Items.Clear();
            foreach (var v in Vendas)
            {
                ListViewItem item = new ListViewItem(v.Id.ToString());
                item.SubItems.Add(v.DataVenda.ToString());
                item.SubItems.Add(v.Valor.ToString());
                item.SubItems.Add(v.FuncionarioNome);

                if (!v.Status)
                {
                    item.BackColor = System.Drawing.Color.Red;
                }

                listViewVendas.Items.Add(item);
            }
        }
        private void btnCancelarVenda_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente cancelar a venda?", " ", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
               int.TryParse(listViewVendas.SelectedItems[0].SubItems[0].Text, out int idVenda);
                vendaService.ExcluirVenda(idVenda);
                CarregarVendas(false);
                //listViewVendas.Items.Clear();
            }
        }

        private void maskedTextBoxDataFinal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CarregarVendas(true);
            }      
        }
    }
}
