using ClinicaVetWF.Models;
using ClinicaVetWF.Services;
using ClinicaVetWF.Utils;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using static ClinicaVetWF.Services.AnimalService;
using static ClinicaVetWF.Services.ConsultaService;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ClinicaVetWF.Views
{
    public partial class TelaPrincipal : Form
    {
        private ProdutoService produtoService;
        private VendaService vendaService;
        private ConsultaService consultaService;
        private ItemVendaService itemVendaService;
        private FuncionarioService funcionarioService;
        public TelaPrincipal()
        {
            InitializeComponent();
            txbFiltro.KeyPress += new KeyPressEventHandler(textBoxFiltro_KeyPress);
            funcionarioService = new FuncionarioService(new Context());
        }

        private void textBoxFiltro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                bool id = false;
                bool descricao = false;
                bool codigo = false;
                if (checkBoxCodigo.Checked)
                {
                    codigo = true;
                }

                if (checkBoxDescricao.Checked)
                {
                    descricao = true;
                }
                if (checkBoxId.Checked)
                {
                    id = true;
                }
                string texto = txbFiltro.Text;

                if (txbFiltro.Text.Length == 0)
                {
                    MontarListViewProdutos();
                }
                else
                {
                    MontarListViewProdutosFiltrados(produtoService.ProdutosFiltrados(codigo, id, descricao, texto));
                    txbFiltro.Clear();
                }
                e.Handled = true;
            }
        }

        private void TelaPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void TelaPrincipal_Load(object sender, EventArgs e)
        {
            List<FuncionarioPermissao> funcionarioPermissoes = new List<FuncionarioPermissao>();

            funcionarioPermissoes = funcionarioService.BuscarPermissoes(Utils.UserSession.LoggedUserId);
            foreach (var permissao in funcionarioPermissoes)
            {
                clienteToolStripMenuItem.Visible = permissao.PodeAcessarCliente; 
                clínicaToolStripMenuItem.Visible = permissao.PodeAcessarClinica; 
                produtosToolStripMenuItem.Visible = permissao.PodeAcessarProdutos; 
                fornecedoresToolStripMenuItem.Visible = permissao.PodeAcessarFornecedores; 
                funcionáriosToolStripMenuItem.Visible = permissao.PodeAcessarFuncionarios; 
                relatóriosToolStripMenuItem.Visible = permissao.PodeAcessarRelatorios; 
            }
            produtoService = new ProdutoService(new Utils.Context());
            vendaService = new VendaService(new Utils.Context());
            consultaService = new ConsultaService(new Utils.Context());
            itemVendaService = new ItemVendaService(new Utils.Context());

            this.WindowState = FormWindowState.Maximized;

            MontarListViewProdutos();

            MontarListViewConsultas();
        }

        public void MontarListViewProdutos()
        {
            listViewProdutos.Clear();
            listViewProdutos.AllowColumnReorder = false;
            listViewProdutosLancados.AllowColumnReorder = false;
            listViewProdutos.ItemActivate += ListViewProdutos_ItemActivate;
            listViewProdutosLancados.MouseDoubleClick += ListViewProdutosLancados_MouseDoubleClick1;

            List<produto> produtos = new List<produto>();

            listViewProdutos.Columns.Add("Id", 50);
            listViewProdutos.Columns.Add("Nome", 150);
            listViewProdutos.Columns.Add("Valor", 50);
            listViewProdutos.Columns.Add("Código", 100);

            produtos = produtoService.BuscarProdutos();

            foreach (var produto in produtos)
            {
                ListViewItem item = new ListViewItem(produto.id.ToString());
                item.SubItems.Add(produto.nome);
                item.SubItems.Add(produto.preco.ToString());
                item.SubItems.Add(produto.codigo.ToString());
                listViewProdutos.Items.Add(item);
            }
        }

        public void MontarListViewProdutosFiltrados(List<produto> produtos)
        {
            listViewProdutos.Clear();
            listViewProdutos.AllowColumnReorder = false;
            listViewProdutosLancados.AllowColumnReorder = false;
            listViewProdutos.ItemActivate += ListViewProdutos_ItemActivate;
            listViewProdutosLancados.MouseDoubleClick += ListViewProdutosLancados_MouseDoubleClick1;

            listViewProdutos.Columns.Add("Id", 50);
            listViewProdutos.Columns.Add("Nome", 150);
            listViewProdutos.Columns.Add("Valor", 50);
            listViewProdutos.Columns.Add("Código", 100);

            foreach (var produto in produtos)
            {
                ListViewItem item = new ListViewItem(produto.id.ToString());
                item.SubItems.Add(produto.nome);
                item.SubItems.Add(produto.preco.ToString());
                item.SubItems.Add(produto.codigo.ToString());
                listViewProdutos.Items.Add(item);
            }
        }

        private void ListViewProdutosLancados_MouseDoubleClick1(object sender, MouseEventArgs e)
        {
            try
            {
                ListViewItem clickedItem = listViewProdutosLancados.GetItemAt(e.X, e.Y);

                if (clickedItem != null)
                {

                    DialogResult resultado = MessageBox.Show("Deseja remover o produto?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (resultado == DialogResult.Yes)
                    {
                        string valorTexto = clickedItem.SubItems[2].Text;

                        if (decimal.TryParse(valorTexto, out decimal valor))
                        {
                            total -= valor;

                            lblTotalVenda.Text = "Total: " + total.ToString("C");
                        }
                        listViewProdutosLancados.Items.Remove(clickedItem);
                    }
                    else
                    {

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cadastrarPetToolStripMenuItem_Click(object sender, EventArgs e)
        {

            VisualizarAnimais visualizarAnimais = new VisualizarAnimais();
            visualizarAnimais.ShowDialog();
        }

        private void cadastrarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {


            VisualizarClientes visualizarClientes = new VisualizarClientes();
            visualizarClientes.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void agendarExameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisualizarConsultas visualizarConsultas = new VisualizarConsultas();
            visualizarConsultas.ShowDialog();

        }

        private void cadastrarProfissionalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastrarTipoProfissional cadastrarTipoProfissional = new CadastrarTipoProfissional();
            cadastrarTipoProfissional.ShowDialog();
        }

        private void cadastrarNovoServiçoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastrarServico cadastrarServico = new CadastrarServico();
            cadastrarServico.ShowDialog();
        }

        private void agendarConsultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Agendamento agendamento = new Agendamento(false);
            agendamento.ShowDialog();
            listViewAtivDia.Clear();
            MontarListViewConsultas();

        }

        private void cadastrarFornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisualizarFornecedores visualizarFornecedores = new VisualizarFornecedores();
            visualizarFornecedores.ShowDialog();
        }

        private void visualizarProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisualizarProdutos visualizarProdutos = new VisualizarProdutos();
            visualizarProdutos.ShowDialog();
        }
        private decimal total = 0;
        private void ListViewProdutos_ItemActivate(object sender, EventArgs e)
        {
            if (listViewProdutos.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listViewProdutos.SelectedItems[0];
                if (listViewProdutosLancados.Columns.Count == 0)
                {
                    listViewProdutosLancados.Columns.Add("Id", 50);
                    listViewProdutosLancados.Columns.Add("Nome", 150);
                    listViewProdutosLancados.Columns.Add("Valor", 70);
                    listViewProdutosLancados.Columns.Add("Código", 100);
                }

                string valorTexto = selectedItem.SubItems[2].Text;

                if (decimal.TryParse(valorTexto, out decimal valor))
                {
                    total += valor;

                    lblTotalVenda.Text = "Total: " + total.ToString("C");
                }

                ListViewItem newItem = new ListViewItem(selectedItem.SubItems[0].Text);

                newItem.SubItems.Add(selectedItem.SubItems[1].Text);
                newItem.SubItems.Add(selectedItem.SubItems[2].Text);
                newItem.SubItems.Add(selectedItem.SubItems[3].Text);

                listViewProdutosLancados.Items.Add(newItem);
                //listViewProdutos.Items.Remove(selectedItem);

            }
        }

        private void ListViewProdutos_MouseClick(object sender, MouseEventArgs e)
        {
            ListViewItem clickedItem = listViewProdutos.GetItemAt(e.X, e.Y);

            if (clickedItem != null)
            {
                string valorTexto = clickedItem.SubItems[2].Text;

                if (decimal.TryParse(valorTexto, out decimal valor))
                {
                    total += valor;
                    lblTotalVenda.Text = "Total: " + total.ToString("C");
                }

                ListViewItem newItem = new ListViewItem(clickedItem.SubItems[0].Text);

                for (int i = 1; i < clickedItem.SubItems.Count; i++)
                {
                    newItem.SubItems.Add(clickedItem.SubItems[i].Text);
                }

                listViewProdutosLancados.Items.Add(newItem);
            }
        }


        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewProdutos.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listViewProdutos.SelectedItems[0];
                if (listViewProdutosLancados.Columns.Count == 0)
                {
                    listViewProdutosLancados.Columns.Add("Id", 50);
                    listViewProdutosLancados.Columns.Add("Nome", 150);
                    listViewProdutosLancados.Columns.Add("Valor", 70);
                    listViewProdutosLancados.Columns.Add("Código", 100);
                }

                string valorTexto = selectedItem.SubItems[2].Text;

                if (decimal.TryParse(valorTexto, out decimal valor))
                {
                    total += valor;

                    lblTotalVenda.Text = "Total: " + total.ToString("C");
                }

                ListViewItem newItem = new ListViewItem(selectedItem.SubItems[0].Text);

                newItem.SubItems.Add(selectedItem.SubItems[1].Text);
                newItem.SubItems.Add(selectedItem.SubItems[2].Text);
                newItem.SubItems.Add(selectedItem.SubItems[3].Text);

                listViewProdutosLancados.Items.Add(newItem);
            }
        }

        private void btnFinalizarVenda_Click(object sender, EventArgs e)
        {
            venda venda = new venda();
            venda.data_venda = DateTime.Now;
            venda.valor_total = total;
            venda.id_funcionario = Utils.UserSession.LoggedUserId;
            venda.desconto = 0;
            //int idVenda = vendaService.CadastrarVenda(venda);

            List<item_venda> itensVenda = new List<item_venda>();
            foreach (ListViewItem item in listViewProdutosLancados.Items)
            {
                int idProduto = 0;
                if (int.TryParse(item.SubItems[0].Text, out int idProd))
                {
                    idProduto = idProd;
                }
                var novoItemVenda = new item_venda
                {
                    id_produto = idProduto,
                    quantidade = 1,
                };
                itensVenda.Add(novoItemVenda);
                //itemVendaService.CadastrarItemVenda(novoItemVenda);
            }
            venda.item_venda = itensVenda;

            Pagamento pagamentos = new Pagamento(venda);
            pagamentos.ShowDialog();
            listViewProdutosLancados.Items.Clear();
            lblTotalVenda.Text = "";
            total = 0;
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ListViewConsultas_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                ListViewItem clickedItem = listViewAtivDia.GetItemAt(e.X, e.Y);

                if (clickedItem != null)
                {
                    bool pago = bool.Parse(clickedItem.SubItems[8].Text);

                    DialogResult resultado = MessageBox.Show("Você deseja cancelar a consulta?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (resultado == DialogResult.Yes)
                    {
                        consultaService.ExcluirConsulta(int.Parse(clickedItem.SubItems[0].Text));
                        listViewAtivDia.Clear();
                        MontarListViewConsultas();
                    }
                    else
                    {
                        if (!pago)
                        {
                            DialogResult resultado2 = MessageBox.Show("Você deseja realizar o pagamento da consuta?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (resultado2 == DialogResult.Yes)
                            {
                                FinalizarVenda(sender, e);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void MontarListViewConsultas()
        {
            listViewAtivDia.AllowColumnReorder = false;
            listViewAtivDia.MouseClick += ListViewConsultas_MouseDoubleClick;

            List<ConsultaInfo> consultasDoDia = new List<ConsultaInfo>();

            listViewAtivDia.Columns.Add("Id", 50);
            listViewAtivDia.Columns.Add("Tutor", 150);
            listViewAtivDia.Columns.Add("Animal", 150);
            listViewAtivDia.Columns.Add("Data e Hora", 130);
            listViewAtivDia.Columns.Add("Observacao", 160);
            listViewAtivDia.Columns.Add("Agendado por:", 150);
            listViewAtivDia.Columns.Add("Valor", 150);
            listViewAtivDia.Columns.Add("Serviço", 150);
            listViewAtivDia.Columns.Add("Pago", 15).Width = 0;
            listViewAtivDia.Columns.Add("IdTutor", 15).Width = 0;
            listViewAtivDia.Columns.Add("IdTutor", 15).Width = 0;

            consultasDoDia = consultaService.BuscarConsultasDoDia();

            foreach (var consulta in consultasDoDia)
            {
                ListViewItem item = new ListViewItem(consulta.IdConsulta.ToString());
                item.SubItems.Add(consulta.TutorNome);
                item.SubItems.Add(consulta.AnimalNome);
                item.SubItems.Add(consulta.DataConsulta.ToString());
                item.SubItems.Add(consulta.Observacoes);
                item.SubItems.Add(consulta.FuncionarioNome);
                if (consulta.pago)
                {
                    item.ForeColor = Color.Green;
                }
                if (consulta.Valor == 0)
                {
                    item.SubItems.Add("");
                }
                else
                {
                    item.SubItems.Add(consulta.Valor.ToString());
                }

                item.SubItems.Add(consulta.DescricaoServico);
                item.SubItems.Add(consulta.pago.ToString());
                item.SubItems.Add(consulta.IdTutor.ToString());
                item.SubItems.Add(consulta.IdAnimal.ToString());

                listViewAtivDia.Items.Add(item);
            }
        }


        public void FinalizarVenda(object sender = null, MouseEventArgs e = null)
        {
            string cliente = "";
            double valor = 0.00;
            ListViewItem clickedItem = listViewAtivDia.GetItemAt(e.X, e.Y);
            consulta consulta = new consulta();

            if (clickedItem != null)
            {
                int id = int.Parse(clickedItem.SubItems[0].Text);
                valor = double.Parse(clickedItem.SubItems[6].Text);
                consulta = consultaService.BuscarConsulta(id);
            }
            else
            {
                valor = double.Parse(lblTotalVenda.Text);
            }

            venda venda = new venda();
            venda.data_venda = DateTime.Now;
            venda.valor_total = (decimal)valor;
            venda.id_funcionario = Utils.UserSession.LoggedUserId;
            venda.desconto = 0;

            Pagamento pagamentos = new Pagamento(venda, consulta);
            pagamentos.ShowDialog();
            listViewAtivDia.Clear();
            MontarListViewConsultas();
            lblTotalVenda.Text = "";

        }

        private void relatóriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Relatorios relatorios = new Relatorios();
            relatorios.ShowDialog();
        }

        private void cadastrarCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisualizarCompras visualizarCompras = new VisualizarCompras();
            visualizarCompras.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void visualizarFuncionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroFuncionario cadastrarFuncionario = new CadastroFuncionario();
            cadastrarFuncionario.ShowDialog();
        }
    }
}
