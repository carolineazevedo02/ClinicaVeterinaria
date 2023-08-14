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
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listViewProdsLancados = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.listViewAtivDia = new System.Windows.Forms.ListView();
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
            this.agendarConsultaToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.agendarConsultaToolStripMenuItem.Text = "Agendar Consulta";
            this.agendarConsultaToolStripMenuItem.Click += new System.EventHandler(this.agendarConsultaToolStripMenuItem_Click);
            // 
            // cadastrarNovoServiçoToolStripMenuItem
            // 
            this.cadastrarNovoServiçoToolStripMenuItem.Name = "cadastrarNovoServiçoToolStripMenuItem";
            this.cadastrarNovoServiçoToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.cadastrarNovoServiçoToolStripMenuItem.Text = "Cadastrar Novo Serviço";
            this.cadastrarNovoServiçoToolStripMenuItem.Click += new System.EventHandler(this.cadastrarNovoServiçoToolStripMenuItem_Click);
            // 
            // agendarExameToolStripMenuItem
            // 
            this.agendarExameToolStripMenuItem.Name = "agendarExameToolStripMenuItem";
            this.agendarExameToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.agendarExameToolStripMenuItem.Text = "Agendar Exame";
            this.agendarExameToolStripMenuItem.Click += new System.EventHandler(this.agendarExameToolStripMenuItem_Click);
            // 
            // cadastrarProfissionalToolStripMenuItem
            // 
            this.cadastrarProfissionalToolStripMenuItem.Name = "cadastrarProfissionalToolStripMenuItem";
            this.cadastrarProfissionalToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.cadastrarProfissionalToolStripMenuItem.Text = "Cadastrar Profissional";
            this.cadastrarProfissionalToolStripMenuItem.Click += new System.EventHandler(this.cadastrarProfissionalToolStripMenuItem_Click);
            // 
            // fornecedoresToolStripMenuItem
            // 
            this.fornecedoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarFornecedorToolStripMenuItem});
            this.fornecedoresToolStripMenuItem.Name = "fornecedoresToolStripMenuItem";
            this.fornecedoresToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.fornecedoresToolStripMenuItem.Text = "Fornecedores";
            // 
            // cadastrarFornecedorToolStripMenuItem
            // 
            this.cadastrarFornecedorToolStripMenuItem.Name = "cadastrarFornecedorToolStripMenuItem";
            this.cadastrarFornecedorToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.cadastrarFornecedorToolStripMenuItem.Text = "Cadastrar Fornecedor ";
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.produtosToolStripMenuItem.Text = "Produtos";
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // funcionáriosToolStripMenuItem
            // 
            this.funcionáriosToolStripMenuItem.Name = "funcionáriosToolStripMenuItem";
            this.funcionáriosToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.funcionáriosToolStripMenuItem.Text = "Funcionários";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.monthCalendar1.Location = new System.Drawing.Point(130, 159);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 1;
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
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.monthCalendar1);
            this.panel1.Location = new System.Drawing.Point(889, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(461, 703);
            this.panel1.TabIndex = 10;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(37, 353);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(457, 20);
            this.textBox1.TabIndex = 11;
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
            // listViewProdsLancados
            // 
            this.listViewProdsLancados.HideSelection = false;
            this.listViewProdsLancados.Location = new System.Drawing.Point(37, 406);
            this.listViewProdsLancados.Name = "listViewProdsLancados";
            this.listViewProdsLancados.Size = new System.Drawing.Size(789, 235);
            this.listViewProdsLancados.TabIndex = 14;
            this.listViewProdsLancados.UseCompatibleStateImageBehavior = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(714, 668);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 39);
            this.button1.TabIndex = 15;
            this.button1.Text = "Finalizar Venda";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Atividades do dia";
            // 
            // listViewAtivDia
            // 
            this.listViewAtivDia.HideSelection = false;
            this.listViewAtivDia.Location = new System.Drawing.Point(37, 88);
            this.listViewAtivDia.Name = "listViewAtivDia";
            this.listViewAtivDia.Size = new System.Drawing.Size(789, 230);
            this.listViewAtivDia.TabIndex = 17;
            this.listViewAtivDia.UseCompatibleStateImageBehavior = false;
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.listViewAtivDia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listViewProdsLancados);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
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
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem funcionáriosToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem cadastrarProfissionalToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listViewProdsLancados;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listViewAtivDia;
    }
}