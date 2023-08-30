namespace ClinicaVetWF.Views
{
    partial class TelaPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarPetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clínicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agendarConsultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarNovoServiçoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agendarExameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarProfissionalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarFornecedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarCompraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizarProdutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizarFuncionáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotalVenda = new System.Windows.Forms.Label();
            this.listViewProdutosLancados = new System.Windows.Forms.ListView();
            this.btnFinalizarVenda = new System.Windows.Forms.Button();
            this.txbFiltro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listViewProdutos = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.listViewAtivDia = new System.Windows.Forms.ListView();
            this.checkBoxDescricao = new System.Windows.Forms.CheckBox();
            this.checkBoxCodigo = new System.Windows.Forms.CheckBox();
            this.checkBoxId = new System.Windows.Forms.CheckBox();
            this.vendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosGeraisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem,
            this.clínicaToolStripMenuItem,
            this.fornecedoresToolStripMenuItem,
            this.produtosToolStripMenuItem,
            this.relatóriosToolStripMenuItem,
            this.funcionáriosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1350, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarClienteToolStripMenuItem,
            this.cadastrarPetToolStripMenuItem});
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.clienteToolStripMenuItem.Text = "Cliente";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // cadastrarClienteToolStripMenuItem
            // 
            this.cadastrarClienteToolStripMenuItem.Name = "cadastrarClienteToolStripMenuItem";
            this.cadastrarClienteToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.cadastrarClienteToolStripMenuItem.Text = "Cadastrar Cliente";
            this.cadastrarClienteToolStripMenuItem.Click += new System.EventHandler(this.cadastrarClienteToolStripMenuItem_Click);
            // 
            // cadastrarPetToolStripMenuItem
            // 
            this.cadastrarPetToolStripMenuItem.Name = "cadastrarPetToolStripMenuItem";
            this.cadastrarPetToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.cadastrarPetToolStripMenuItem.Text = "Pets";
            this.cadastrarPetToolStripMenuItem.Click += new System.EventHandler(this.cadastrarPetToolStripMenuItem_Click);
            // 
            // clínicaToolStripMenuItem
            // 
            this.clínicaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agendarConsultaToolStripMenuItem,
            this.cadastrarNovoServiçoToolStripMenuItem,
            this.agendarExameToolStripMenuItem,
            this.cadastrarProfissionalToolStripMenuItem});
            this.clínicaToolStripMenuItem.Name = "clínicaToolStripMenuItem";
            this.clínicaToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.clínicaToolStripMenuItem.Text = "Clínica";
            // 
            // agendarConsultaToolStripMenuItem
            // 
            this.agendarConsultaToolStripMenuItem.Name = "agendarConsultaToolStripMenuItem";
            this.agendarConsultaToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.agendarConsultaToolStripMenuItem.Text = "Realizar Agendamento";
            this.agendarConsultaToolStripMenuItem.Click += new System.EventHandler(this.agendarConsultaToolStripMenuItem_Click);
            // 
            // cadastrarNovoServiçoToolStripMenuItem
            // 
            this.cadastrarNovoServiçoToolStripMenuItem.Name = "cadastrarNovoServiçoToolStripMenuItem";
            this.cadastrarNovoServiçoToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.cadastrarNovoServiçoToolStripMenuItem.Text = "Cadastrar Novo Serviço";
            this.cadastrarNovoServiçoToolStripMenuItem.Click += new System.EventHandler(this.cadastrarNovoServiçoToolStripMenuItem_Click);
            // 
            // agendarExameToolStripMenuItem
            // 
            this.agendarExameToolStripMenuItem.Name = "agendarExameToolStripMenuItem";
            this.agendarExameToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.agendarExameToolStripMenuItem.Text = "Visualizar Agendamentos";
            this.agendarExameToolStripMenuItem.Click += new System.EventHandler(this.agendarExameToolStripMenuItem_Click);
            // 
            // cadastrarProfissionalToolStripMenuItem
            // 
            this.cadastrarProfissionalToolStripMenuItem.Name = "cadastrarProfissionalToolStripMenuItem";
            this.cadastrarProfissionalToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.cadastrarProfissionalToolStripMenuItem.Text = "Cadastrar Profissional";
            this.cadastrarProfissionalToolStripMenuItem.Click += new System.EventHandler(this.cadastrarProfissionalToolStripMenuItem_Click);
            // 
            // fornecedoresToolStripMenuItem
            // 
            this.fornecedoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarFornecedorToolStripMenuItem,
            this.cadastrarCompraToolStripMenuItem});
            this.fornecedoresToolStripMenuItem.Name = "fornecedoresToolStripMenuItem";
            this.fornecedoresToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.fornecedoresToolStripMenuItem.Text = "Fornecedores";
            // 
            // cadastrarFornecedorToolStripMenuItem
            // 
            this.cadastrarFornecedorToolStripMenuItem.Name = "cadastrarFornecedorToolStripMenuItem";
            this.cadastrarFornecedorToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.cadastrarFornecedorToolStripMenuItem.Text = "Visualizar Fornecedor ";
            this.cadastrarFornecedorToolStripMenuItem.Click += new System.EventHandler(this.cadastrarFornecedorToolStripMenuItem_Click);
            // 
            // cadastrarCompraToolStripMenuItem
            // 
            this.cadastrarCompraToolStripMenuItem.Name = "cadastrarCompraToolStripMenuItem";
            this.cadastrarCompraToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.cadastrarCompraToolStripMenuItem.Text = "Visualizar Compras";
            this.cadastrarCompraToolStripMenuItem.Click += new System.EventHandler(this.cadastrarCompraToolStripMenuItem_Click);
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visualizarProdutosToolStripMenuItem});
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.produtosToolStripMenuItem.Text = "Produtos";
            // 
            // visualizarProdutosToolStripMenuItem
            // 
            this.visualizarProdutosToolStripMenuItem.Name = "visualizarProdutosToolStripMenuItem";
            this.visualizarProdutosToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.visualizarProdutosToolStripMenuItem.Text = "Visualizar Produtos";
            this.visualizarProdutosToolStripMenuItem.Click += new System.EventHandler(this.visualizarProdutosToolStripMenuItem_Click);
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vendasToolStripMenuItem,
            this.relatóriosGeraisToolStripMenuItem});
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.relatóriosToolStripMenuItem.Text = "Relatórios";
            this.relatóriosToolStripMenuItem.Click += new System.EventHandler(this.relatóriosToolStripMenuItem_Click);
            // 
            // funcionáriosToolStripMenuItem
            // 
            this.funcionáriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visualizarFuncionáriosToolStripMenuItem});
            this.funcionáriosToolStripMenuItem.Name = "funcionáriosToolStripMenuItem";
            this.funcionáriosToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.funcionáriosToolStripMenuItem.Text = "Funcionários";
            // 
            // visualizarFuncionáriosToolStripMenuItem
            // 
            this.visualizarFuncionáriosToolStripMenuItem.Name = "visualizarFuncionáriosToolStripMenuItem";
            this.visualizarFuncionáriosToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.visualizarFuncionáriosToolStripMenuItem.Text = "Visualizar Funcionários";
            this.visualizarFuncionáriosToolStripMenuItem.Click += new System.EventHandler(this.visualizarFuncionáriosToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 25.75F, System.Drawing.FontStyle.Italic);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(102)))), ((int)(((byte)(105)))));
            this.label1.Location = new System.Drawing.Point(102, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 43);
            this.label1.TabIndex = 9;
            this.label1.Text = "Felinos da Montanha";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblTotalVenda);
            this.panel1.Controls.Add(this.listViewProdutosLancados);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnFinalizarVenda);
            this.panel1.Location = new System.Drawing.Point(879, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(477, 703);
            this.panel1.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Produtos Selecionados";
            // 
            // lblTotalVenda
            // 
            this.lblTotalVenda.AutoSize = true;
            this.lblTotalVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalVenda.Location = new System.Drawing.Point(19, 445);
            this.lblTotalVenda.Name = "lblTotalVenda";
            this.lblTotalVenda.Size = new System.Drawing.Size(0, 24);
            this.lblTotalVenda.TabIndex = 17;
            // 
            // listViewProdutosLancados
            // 
            this.listViewProdutosLancados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewProdutosLancados.FullRowSelect = true;
            this.listViewProdutosLancados.GridLines = true;
            this.listViewProdutosLancados.HideSelection = false;
            this.listViewProdutosLancados.Location = new System.Drawing.Point(7, 134);
            this.listViewProdutosLancados.Name = "listViewProdutosLancados";
            this.listViewProdutosLancados.Size = new System.Drawing.Size(452, 285);
            this.listViewProdutosLancados.TabIndex = 10;
            this.listViewProdutosLancados.UseCompatibleStateImageBehavior = false;
            this.listViewProdutosLancados.View = System.Windows.Forms.View.Details;
            // 
            // btnFinalizarVenda
            // 
            this.btnFinalizarVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizarVenda.Location = new System.Drawing.Point(316, 547);
            this.btnFinalizarVenda.Name = "btnFinalizarVenda";
            this.btnFinalizarVenda.Size = new System.Drawing.Size(126, 67);
            this.btnFinalizarVenda.TabIndex = 15;
            this.btnFinalizarVenda.Text = "Finalizar Venda";
            this.btnFinalizarVenda.UseVisualStyleBackColor = true;
            this.btnFinalizarVenda.Click += new System.EventHandler(this.btnFinalizarVenda_Click);
            // 
            // txbFiltro
            // 
            this.txbFiltro.Location = new System.Drawing.Point(37, 353);
            this.txbFiltro.Name = "txbFiltro";
            this.txbFiltro.Size = new System.Drawing.Size(180, 20);
            this.txbFiltro.TabIndex = 11;
            this.txbFiltro.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 335);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Produto";
            // 
            // listViewProdutos
            // 
            this.listViewProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewProdutos.FullRowSelect = true;
            this.listViewProdutos.GridLines = true;
            this.listViewProdutos.HideSelection = false;
            this.listViewProdutos.Location = new System.Drawing.Point(37, 406);
            this.listViewProdutos.Name = "listViewProdutos";
            this.listViewProdutos.Size = new System.Drawing.Size(789, 235);
            this.listViewProdutos.TabIndex = 14;
            this.listViewProdutos.UseCompatibleStateImageBehavior = false;
            this.listViewProdutos.View = System.Windows.Forms.View.Details;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Consultas do dia";
            // 
            // listViewAtivDia
            // 
            this.listViewAtivDia.FullRowSelect = true;
            this.listViewAtivDia.GridLines = true;
            this.listViewAtivDia.HideSelection = false;
            this.listViewAtivDia.Location = new System.Drawing.Point(37, 88);
            this.listViewAtivDia.Name = "listViewAtivDia";
            this.listViewAtivDia.Size = new System.Drawing.Size(789, 230);
            this.listViewAtivDia.TabIndex = 17;
            this.listViewAtivDia.UseCompatibleStateImageBehavior = false;
            this.listViewAtivDia.View = System.Windows.Forms.View.Details;
            // 
            // checkBoxDescricao
            // 
            this.checkBoxDescricao.AutoSize = true;
            this.checkBoxDescricao.Location = new System.Drawing.Point(251, 356);
            this.checkBoxDescricao.Name = "checkBoxDescricao";
            this.checkBoxDescricao.Size = new System.Drawing.Size(74, 17);
            this.checkBoxDescricao.TabIndex = 18;
            this.checkBoxDescricao.Text = "Descrição";
            this.checkBoxDescricao.UseVisualStyleBackColor = true;
            // 
            // checkBoxCodigo
            // 
            this.checkBoxCodigo.AutoSize = true;
            this.checkBoxCodigo.Location = new System.Drawing.Point(355, 356);
            this.checkBoxCodigo.Name = "checkBoxCodigo";
            this.checkBoxCodigo.Size = new System.Drawing.Size(59, 17);
            this.checkBoxCodigo.TabIndex = 19;
            this.checkBoxCodigo.Text = "Código";
            this.checkBoxCodigo.UseVisualStyleBackColor = true;
            // 
            // checkBoxId
            // 
            this.checkBoxId.AutoSize = true;
            this.checkBoxId.Location = new System.Drawing.Point(454, 356);
            this.checkBoxId.Name = "checkBoxId";
            this.checkBoxId.Size = new System.Drawing.Size(37, 17);
            this.checkBoxId.TabIndex = 20;
            this.checkBoxId.Text = "ID";
            this.checkBoxId.UseVisualStyleBackColor = true;
            // 
            // vendasToolStripMenuItem
            // 
            this.vendasToolStripMenuItem.Name = "vendasToolStripMenuItem";
            this.vendasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.vendasToolStripMenuItem.Text = "Vendas";
            this.vendasToolStripMenuItem.Click += new System.EventHandler(this.vendasToolStripMenuItem_Click);
            // 
            // relatóriosGeraisToolStripMenuItem
            // 
            this.relatóriosGeraisToolStripMenuItem.Name = "relatóriosGeraisToolStripMenuItem";
            this.relatóriosGeraisToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.relatóriosGeraisToolStripMenuItem.Text = "Relatórios Gerais";
            this.relatóriosGeraisToolStripMenuItem.Click += new System.EventHandler(this.relatóriosGeraisToolStripMenuItem_Click);
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.checkBoxId);
            this.Controls.Add(this.checkBoxCodigo);
            this.Controls.Add(this.checkBoxDescricao);
            this.Controls.Add(this.listViewAtivDia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listViewProdutos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbFiltro);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "TelaPrincipal";
            this.Text = "TelaPrincipal";
            this.Load += new System.EventHandler(this.TelaPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarPetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clínicaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agendarConsultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarNovoServiçoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agendarExameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fornecedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarFornecedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem funcionáriosToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem cadastrarProfissionalToolStripMenuItem;
        private System.Windows.Forms.TextBox txbFiltro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listViewProdutos;
        private System.Windows.Forms.Button btnFinalizarVenda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listViewAtivDia;
        private System.Windows.Forms.ToolStripMenuItem visualizarProdutosToolStripMenuItem;
        private System.Windows.Forms.ListView listViewProdutosLancados;
        private System.Windows.Forms.Label lblTotalVenda;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem cadastrarCompraToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkBoxDescricao;
        private System.Windows.Forms.CheckBox checkBoxCodigo;
        private System.Windows.Forms.CheckBox checkBoxId;
        private System.Windows.Forms.ToolStripMenuItem visualizarFuncionáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatóriosGeraisToolStripMenuItem;
    }
}