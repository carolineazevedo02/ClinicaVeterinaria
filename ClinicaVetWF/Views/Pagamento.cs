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
    public partial class Pagamento : Form
    {
        public venda venda;
        public consulta consulta;
        private ConsultaService consultaService;
        private VendaService vendaService;
        private PagamentoService pagamentoService;
        private FormasPagamentoService formasPagamentoService;
        public Pagamento(venda vendaCadastrar, consulta consulta = null)
        {
            InitializeComponent();
            this.venda = vendaCadastrar;
            this.consulta = consulta;

            consultaService = new ConsultaService(new Utils.Context());
            vendaService = new VendaService(new Utils.Context());
            pagamentoService = new PagamentoService(new Utils.Context());
            formasPagamentoService = new FormasPagamentoService(new Utils.Context());

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Pagemento_Load(object sender, EventArgs e)
        {
            lblValorReceber.Text = "VALOR A RECEBER: " + this.venda.valor_total.ToString();
            lblTotalVenda.Text = "TOTAL: R$ " + this.venda.valor_total.ToString();
            PreencherFormasPagamento();

        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            int idVenda = vendaService.CadastrarVenda(this.venda);
            if (this.consulta != null)
            {
                if (consulta.id != 0)
                {
                    this.consulta.id_venda = idVenda;
                    consultaService.AtualizarConsulta(this.consulta);
                }
                else
                {
                    this.consulta.id_venda = idVenda;
                    consultaService.CadastrarConsulta(this.consulta);
                }
            }

            DataRowView selectedRow = (DataRowView)cbbFormasPgto.SelectedItem;
            int id = 0;
            if (selectedRow != null)
            {
                id = (int)selectedRow["Id"];
            }

            pagamentos pagamento = new pagamentos();
            pagamento.data_pagamento = DateTime.Now;
            pagamento.id_forma_pagamento = id;
            pagamento.id_venda = idVenda;
            pagamento.status = true;

            pagamentoService.CadastrarPagamento(pagamento);
            MessageBox.Show("Venda cadastrada com sucesso!");
            this.Close();
        }

        public void PreencherFormasPagamento()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Id", typeof(int));
            dataTable.Columns.Add("Nome", typeof(string));

            List<formas_pagamento> formasPagamentos = new List<formas_pagamento>();
            formasPagamentos = formasPagamentoService.BuscarFormasPagamento();

            foreach (formas_pagamento formaPagamento in formasPagamentos)
            {
                dataTable.Rows.Add(formaPagamento.id, formaPagamento.descricao);
            }

            cbbFormasPgto.DataSource = dataTable;
            cbbFormasPgto.DisplayMember = "Nome";
            cbbFormasPgto.SelectedIndex = 0;
        }
    }
}
