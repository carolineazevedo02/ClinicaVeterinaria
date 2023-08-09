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
            this.fornecedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarFornecedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(804, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
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
            this.agendarExameToolStripMenuItem});
            this.clínicaToolStripMenuItem.Name = "clínicaToolStripMenuItem";
            this.clínicaToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.clínicaToolStripMenuItem.Text = "Clínica";
            // 
            // agendarConsultaToolStripMenuItem
            // 
            this.agendarConsultaToolStripMenuItem.Name = "agendarConsultaToolStripMenuItem";
            this.agendarConsultaToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.agendarConsultaToolStripMenuItem.Text = "Agendar Consulta";
            // 
            // cadastrarNovoServiçoToolStripMenuItem
            // 
            this.cadastrarNovoServiçoToolStripMenuItem.Name = "cadastrarNovoServiçoToolStripMenuItem";
            this.cadastrarNovoServiçoToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.cadastrarNovoServiçoToolStripMenuItem.Text = "Cadastrar Novo Serviço";
            // 
            // agendarExameToolStripMenuItem
            // 
            this.agendarExameToolStripMenuItem.Name = "agendarExameToolStripMenuItem";
            this.agendarExameToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.agendarExameToolStripMenuItem.Text = "Agendar Exame";
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
            this.monthCalendar1.Location = new System.Drawing.Point(29, 144);
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
            this.label1.Location = new System.Drawing.Point(2, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 43);
            this.label1.TabIndex = 9;
            this.label1.Text = "Felinos da Montanha";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ClinicaVetWF.Properties.Resources.icone;
            this.pictureBox1.Location = new System.Drawing.Point(182, 76);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.monthCalendar1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(485, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(319, 319);
            this.panel1.TabIndex = 10;
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "TelaPrincipal";
            this.Text = "TelaPrincipal";
            this.Load += new System.EventHandler(this.TelaPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem funcionáriosToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
    }
}