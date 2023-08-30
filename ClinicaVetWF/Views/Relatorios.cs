using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicaVetWF.Services;
using ClinicaVetWF.Models;
using static ClinicaVetWF.Services.RelatoriosService;

namespace ClinicaVetWF.Views
{
    public partial class Relatorios : Form
    {

        private RelatoriosService relatoriosService;
        public Relatorios()
        {
            InitializeComponent();
            maskedTextBoxDataInicial.TextChanged += new EventHandler(maskedTextBox1_TextChanged);

            maskedTextBoxDataFinal.TextChanged += new EventHandler(maskedTextBox2_TextChanged);

            relatoriosService = new RelatoriosService(new Utils.Context());
        }

        private void btnRelFornecedores_Click(object sender, EventArgs e)
        {
            List<fornecedor> listaFornecedores = new List<fornecedor>();
            listaFornecedores = relatoriosService.GerarRelatorioFornecedor(maskedTextBoxDataInicial.Text, maskedTextBoxDataFinal.Text);

            if (listaFornecedores.Count == 0)
            {
                MessageBox.Show("Sem dados para o período informado");
                return;
            }

            string outputPath = @"C:\relatorios\relatorio.pdf";

            try
            {
                Document doc = new Document();
                PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(outputPath, FileMode.Create));

                doc.Open();

                Paragraph title = new Paragraph("Relatório de Cadastro de Fornecedores no intervalo de " + maskedTextBoxDataInicial.Text + " até " + maskedTextBoxDataFinal.Text);
                title.Alignment = Element.ALIGN_CENTER;
                doc.Add(title);

                doc.Add(new Paragraph("\n"));

                Paragraph informacaoLimpo = new Paragraph();
                informacaoLimpo.Font = FontFactory.GetFont("Arial", 12, BaseColor.BLUE);
                informacaoLimpo.Alignment = Element.ALIGN_LEFT;

                PdfPTable table = new PdfPTable(5);

                table.AddCell("ID");
                table.AddCell("Nome");
                table.AddCell("E-mail");
                table.AddCell("CNPJ");
                table.AddCell("Telefone");

                foreach (var fornecedor in listaFornecedores)
                {
                    table.AddCell(new PdfPCell(new Phrase(fornecedor.Id.ToString())));
                    table.AddCell(new PdfPCell(new Phrase(fornecedor.Nome)));
                    table.AddCell(new PdfPCell(new Phrase(fornecedor.Email)));
                    table.AddCell(new PdfPCell(new Phrase(fornecedor.CNPJ)));
                    table.AddCell(new PdfPCell(new Phrase(fornecedor.Telefone)));
                }

                doc.Add(table);

                doc.Close();

                OpenFileDialog file = new OpenFileDialog();
                file.FileName = "C:\\relatorios\\relatorio.pdf";

                axAcroPDF1.LoadFile(file.FileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao imprimir o PDF: {ex.Message}");
            }
        }

        private void Relatorios_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnRelClientes_Click(object sender, EventArgs e)
        {
            List<cliente> listaClientes = new List<cliente>();
            listaClientes = relatoriosService.GerarRelatorioCliente(maskedTextBoxDataInicial.Text, maskedTextBoxDataFinal.Text);

            if (listaClientes.Count == 0)
            {
                MessageBox.Show("Sem dados para o período informado");
                return;
            }

            string outputPath = @"C:\relatorios\relatorio.pdf";

            try
            {
                Document doc = new Document();
                PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(outputPath, FileMode.Create));

                doc.Open();

                Paragraph title = new Paragraph("Relatório de Cadastro de Clientes no intervalo de " + maskedTextBoxDataInicial.Text + " até " + maskedTextBoxDataFinal.Text);
                title.Alignment = Element.ALIGN_CENTER;
                doc.Add(title);

                doc.Add(new Paragraph("\n"));

                Paragraph informacaoLimpo = new Paragraph();
                informacaoLimpo.Font = FontFactory.GetFont("Arial", 12, BaseColor.BLUE);
                informacaoLimpo.Alignment = Element.ALIGN_LEFT;

                PdfPTable table = new PdfPTable(3);

                table.AddCell("Nome Cliente");
                table.AddCell("CPF");
                table.AddCell("Data de Cadastro");

                foreach (var cliente in listaClientes)
                {
                    table.AddCell(new PdfPCell(new Phrase(cliente.nome)));
                    table.AddCell(new PdfPCell(new Phrase(cliente.cpf)));
                    table.AddCell(new PdfPCell(new Phrase(cliente.dataCadastro.ToString())));
                }

                doc.Add(table);

                doc.Close();

                OpenFileDialog file = new OpenFileDialog();
                file.FileName = "C:\\relatorios\\relatorio.pdf";

                axAcroPDF1.LoadFile(file.FileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao imprimir o PDF: {ex.Message}");
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            VerificarCamposData();
        }

        private void maskedTextBox2_TextChanged(object sender, EventArgs e)
        {
            VerificarCamposData();
        }

        private void VerificarCamposData()
        {
            if (IsDataValida(maskedTextBoxDataInicial.Text) && IsDataValida(maskedTextBoxDataFinal.Text))
            {
                btnRelClientes.Enabled = true;
                btnRelCompras.Enabled = true;
                btnRelFornecedores.Enabled = true;
                btnRelVendas.Enabled = true;
                btnRelServicos.Enabled = true;
                btnRelVendasCanceladas.Enabled = true;
            }
            else
            {

                btnRelClientes.Enabled = false;
                btnRelCompras.Enabled = false;
                btnRelFornecedores.Enabled = false;
                btnRelVendas.Enabled = false;
                btnRelServicos.Enabled = false;
                btnRelVendasCanceladas.Enabled = false;
            }
        }
        private bool IsDataValida(string data)
        {
            DateTime result;
            return DateTime.TryParse(data, out result);
        }

        private void btnRelVendas_Click(object sender, EventArgs e)
        {
            decimal totalVendidoNoPeridodo = 0;

            List<VendaRelatorio> listaVendas = new List<VendaRelatorio>();
            listaVendas = relatoriosService.GerarRelatorioVendas(maskedTextBoxDataInicial.Text, maskedTextBoxDataFinal.Text, false, false);

            if (listaVendas.Count == 0)
            {
                MessageBox.Show("Sem dados para o período informado");
                return;
            }

            string outputPath = "C:\\relatorios\\relatorio.pdf";

            try
            {
                Document doc = new Document();
                PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(outputPath, FileMode.Create));

                doc.Open();

                Paragraph title = new Paragraph("Relatório de Vendas no intervalo de " + maskedTextBoxDataInicial.Text + " até " + maskedTextBoxDataFinal.Text);
                title.Alignment = Element.ALIGN_CENTER;
                doc.Add(title);

                doc.Add(new Paragraph("\n"));

                Paragraph informacaoLimpo = new Paragraph();
                informacaoLimpo.Font = FontFactory.GetFont("Arial", 12, BaseColor.BLUE);
                informacaoLimpo.Alignment = Element.ALIGN_LEFT;

                PdfPTable table = new PdfPTable(5);

                table.AddCell("Id");
                table.AddCell("Funcionario");
                table.AddCell("Data");
                table.AddCell("Tipo de Pagamento");
                table.AddCell("Valor");

                foreach (var venda in listaVendas)
                {
                    table.AddCell(new PdfPCell(new Phrase(venda.Id.ToString())));
                    table.AddCell(new PdfPCell(new Phrase(venda.FuncionarioNome)));
                    table.AddCell(new PdfPCell(new Phrase(venda.DataVenda.ToString())));
                    table.AddCell(new PdfPCell(new Phrase(venda.TipoPagamento.ToString())));
                    table.AddCell(new PdfPCell(new Phrase(venda.Valor.ToString())));
                    if (venda.Status)
                    {
                        totalVendidoNoPeridodo += venda.Valor;
                    }
                }

                doc.Add(table);

                Paragraph total = new Paragraph("\n \nTotal das vendas não canceladas: " + totalVendidoNoPeridodo.ToString());
                title.Alignment = Element.ALIGN_RIGHT;
                doc.Add(total);

                doc.Close();

                OpenFileDialog file = new OpenFileDialog();
                file.FileName = "C:\\relatorios\\relatorio.pdf";

                axAcroPDF1.LoadFile(file.FileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao imprimir o PDF: {ex.Message}");
            }
        }

        private void btnRelServicos_Click(object sender, EventArgs e)
        {
            List<ServicosRelatorio> listaServicos = new List<ServicosRelatorio>();
            listaServicos = relatoriosService.GerarRelatorioServicos(maskedTextBoxDataInicial.Text, maskedTextBoxDataFinal.Text);

            if (listaServicos.Count == 0)
            {
                MessageBox.Show("Sem dados para o período informado");
                return;
            }

            string outputPath = "C:\\relatorios\\relatorio.pdf";

            try
            {
                Document doc = new Document();
                PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(outputPath, FileMode.Create));

                doc.Open();

                Paragraph title = new Paragraph("Relatório de Serviços no intervalo de " + maskedTextBoxDataInicial.Text + " até " + maskedTextBoxDataFinal.Text);
                title.Alignment = Element.ALIGN_CENTER;
                title.Font = FontFactory.GetFont("Arial", 12, BaseColor.DARK_GRAY);
                doc.Add(title);

                doc.Add(new Paragraph("\n"));

                Paragraph informacaoLimpo = new Paragraph();
                informacaoLimpo.Font = FontFactory.GetFont("Arial", 12, BaseColor.BLUE);
                informacaoLimpo.Alignment = Element.ALIGN_LEFT;

                PdfPTable table = new PdfPTable(7);

                float[] columnWidths = new float[] { 5f, 10f, 12f, 10f, 10f, 10f, 10f };

                table.SetWidths(columnWidths);

                table.AddCell("Id");
                table.AddCell("Agendado por:");
                table.AddCell("Profissional responsável");
                table.AddCell("Cliente");
                table.AddCell("Data");
                table.AddCell("Serviço");
                table.AddCell("Cancelada");

                foreach (var servico in listaServicos)
                {
                    table.AddCell(new PdfPCell(new Phrase(servico.Id.ToString())));
                    table.AddCell(new PdfPCell(new Phrase(servico.FuncionarioNomeAgendou)));
                    table.AddCell(new PdfPCell(new Phrase(servico.FuncionarioNomeExecutara)));
                    table.AddCell(new PdfPCell(new Phrase(servico.ClienteNome)));
                    table.AddCell(new PdfPCell(new Phrase(servico.Data.ToString())));
                    table.AddCell(new PdfPCell(new Phrase(servico.DescricaoServico)));
                    string cancelado = "";
                    if (servico.Cancelado)
                    {
                        cancelado = "Cancelado";
                    }
                    table.AddCell(new PdfPCell(new Phrase(cancelado)));
                }

                doc.Add(table);

                doc.Close();

                OpenFileDialog file = new OpenFileDialog();
                file.FileName = "C:\\relatorios\\relatorio.pdf";

                axAcroPDF1.LoadFile(file.FileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao imprimir o PDF: {ex.Message}");
            }

        }

        private void btnRelCompras_Click(object sender, EventArgs e)
        {
            decimal totalComprasNoPeridodo = 0;

            List<compra> listaCompras = new List<compra>();
            listaCompras = relatoriosService.GerarRelatorioCompras(maskedTextBoxDataInicial.Text, maskedTextBoxDataFinal.Text);

            if (listaCompras.Count == 0)
            {
                MessageBox.Show("Sem dados para o período informado");
                return;
            }

            string outputPath = "C:\\relatorios\\relatorio.pdf";

            try
            {
                Document doc = new Document();
                PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(outputPath, FileMode.Create));

                doc.Open();

                Paragraph title = new Paragraph("Relatório de Compras no intervalo de " + maskedTextBoxDataInicial.Text + " até " + maskedTextBoxDataFinal.Text);
                title.Alignment = Element.ALIGN_CENTER;
                doc.Add(title);

                doc.Add(new Paragraph("\n"));

                Paragraph informacaoLimpo = new Paragraph();
                informacaoLimpo.Font = FontFactory.GetFont("Arial", 12, BaseColor.BLUE);
                informacaoLimpo.Alignment = Element.ALIGN_LEFT;

                PdfPTable table = new PdfPTable(5);

                table.AddCell("Id");
                table.AddCell("Fornecedor");
                table.AddCell("Data");
                table.AddCell("Produto");
                table.AddCell("Valor");

                foreach (var compra in listaCompras)
                {
                    table.AddCell(new PdfPCell(new Phrase(compra.Id.ToString())));
                    table.AddCell(new PdfPCell(new Phrase(compra.Fornecedor.Nome)));
                    table.AddCell(new PdfPCell(new Phrase(compra.DataCompra.ToString())));
                    table.AddCell(new PdfPCell(new Phrase(compra.Produto.nome.ToString())));
                    table.AddCell(new PdfPCell(new Phrase(compra.ValorTotal.ToString())));
                    if (!compra.Cancelada)
                    {
                        totalComprasNoPeridodo += compra.ValorTotal;
                    }
                }

                doc.Add(table);

                Paragraph total = new Paragraph("\n \nTotal das compras não canceladas: " + totalComprasNoPeridodo.ToString());
                title.Alignment = Element.ALIGN_RIGHT;
                doc.Add(total);

                doc.Close();

                OpenFileDialog file = new OpenFileDialog();
                file.FileName = "C:\\relatorios\\relatorio.pdf";

                axAcroPDF1.LoadFile(file.FileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao imprimir o PDF: {ex.Message}");
            }

        }

        private void btnRelVendasCanceladas_Click(object sender, EventArgs e)
        {
            decimal totalVendidoNoPeridodo = 0;

            List<VendaRelatorio> listaVendas = new List<VendaRelatorio>();
            listaVendas = relatoriosService.GerarRelatorioVendas(maskedTextBoxDataInicial.Text, maskedTextBoxDataFinal.Text, true, false);

            if (listaVendas.Count == 0)
            {
                MessageBox.Show("Sem dados para o período informado");
                return;
            }

            string outputPath = "C:\\relatorios\\relatorio.pdf";

            try
            {
                Document doc = new Document();
                PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(outputPath, FileMode.Create));

                doc.Open();

                Paragraph title = new Paragraph("Relatório de Vendas canceladas no intervalo de " + maskedTextBoxDataInicial.Text + " até " + maskedTextBoxDataFinal.Text);
                title.Alignment = Element.ALIGN_CENTER;
                doc.Add(title);

                doc.Add(new Paragraph("\n"));

                Paragraph informacaoLimpo = new Paragraph();
                informacaoLimpo.Font = FontFactory.GetFont("Arial", 12, BaseColor.BLUE);
                informacaoLimpo.Alignment = Element.ALIGN_LEFT;

                PdfPTable table = new PdfPTable(5);

                table.AddCell("Id");
                table.AddCell("Funcionario");
                table.AddCell("Data");
                table.AddCell("Tipo de Pagamento");
                table.AddCell("Valor");

                foreach (var venda in listaVendas)
                {
                    table.AddCell(new PdfPCell(new Phrase(venda.Id.ToString())));
                    table.AddCell(new PdfPCell(new Phrase(venda.FuncionarioNome)));
                    table.AddCell(new PdfPCell(new Phrase(venda.DataVenda.ToString())));
                    table.AddCell(new PdfPCell(new Phrase(venda.TipoPagamento.ToString())));
                    table.AddCell(new PdfPCell(new Phrase(venda.Valor.ToString())));

                    totalVendidoNoPeridodo += venda.Valor;

                }

                doc.Add(table);

                Paragraph total = new Paragraph("\n \nTotal das vendas canceladas: " + totalVendidoNoPeridodo.ToString());
                title.Alignment = Element.ALIGN_RIGHT;
                doc.Add(total);

                doc.Close();

                OpenFileDialog file = new OpenFileDialog();
                file.FileName = "C:\\relatorios\\relatorio.pdf";

                axAcroPDF1.LoadFile(file.FileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao imprimir o PDF: {ex.Message}");
            }
        }
    }
}
