namespace ClinicaVetWF.Views
{
    partial class Relatorios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Relatorios));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRelCompras = new System.Windows.Forms.Button();
            this.btnRelVendas = new System.Windows.Forms.Button();
            this.btnRelServicos = new System.Windows.Forms.Button();
            this.btnRelFornecedores = new System.Windows.Forms.Button();
            this.btnRelClientes = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.maskedTextBoxDataFinal = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxDataInicial = new System.Windows.Forms.MaskedTextBox();
            this.axAcroPDF1 = new AxAcroPDFLib.AxAcroPDF();
            this.btnRelVendasCanceladas = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.btnRelVendasCanceladas);
            this.panel1.Controls.Add(this.btnRelCompras);
            this.panel1.Controls.Add(this.btnRelVendas);
            this.panel1.Controls.Add(this.btnRelServicos);
            this.panel1.Controls.Add(this.btnRelFornecedores);
            this.panel1.Controls.Add(this.btnRelClientes);
            this.panel1.Location = new System.Drawing.Point(3, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 714);
            this.panel1.TabIndex = 0;
            // 
            // btnRelCompras
            // 
            this.btnRelCompras.Enabled = false;
            this.btnRelCompras.Location = new System.Drawing.Point(39, 598);
            this.btnRelCompras.Name = "btnRelCompras";
            this.btnRelCompras.Size = new System.Drawing.Size(157, 50);
            this.btnRelCompras.TabIndex = 5;
            this.btnRelCompras.Text = "COMPRAS";
            this.btnRelCompras.UseVisualStyleBackColor = true;
            this.btnRelCompras.Click += new System.EventHandler(this.btnRelCompras_Click);
            // 
            // btnRelVendas
            // 
            this.btnRelVendas.Enabled = false;
            this.btnRelVendas.Location = new System.Drawing.Point(39, 386);
            this.btnRelVendas.Name = "btnRelVendas";
            this.btnRelVendas.Size = new System.Drawing.Size(157, 50);
            this.btnRelVendas.TabIndex = 4;
            this.btnRelVendas.Text = "VENDAS";
            this.btnRelVendas.UseVisualStyleBackColor = true;
            this.btnRelVendas.Click += new System.EventHandler(this.btnRelVendas_Click);
            // 
            // btnRelServicos
            // 
            this.btnRelServicos.Enabled = false;
            this.btnRelServicos.Location = new System.Drawing.Point(39, 275);
            this.btnRelServicos.Name = "btnRelServicos";
            this.btnRelServicos.Size = new System.Drawing.Size(157, 50);
            this.btnRelServicos.TabIndex = 3;
            this.btnRelServicos.Text = "SERVIÇOS PRESTADOS";
            this.btnRelServicos.UseVisualStyleBackColor = true;
            this.btnRelServicos.Click += new System.EventHandler(this.btnRelServicos_Click);
            // 
            // btnRelFornecedores
            // 
            this.btnRelFornecedores.Enabled = false;
            this.btnRelFornecedores.Location = new System.Drawing.Point(39, 157);
            this.btnRelFornecedores.Name = "btnRelFornecedores";
            this.btnRelFornecedores.Size = new System.Drawing.Size(157, 50);
            this.btnRelFornecedores.TabIndex = 2;
            this.btnRelFornecedores.Text = "FORNECEDORES";
            this.btnRelFornecedores.UseVisualStyleBackColor = true;
            this.btnRelFornecedores.Click += new System.EventHandler(this.btnRelFornecedores_Click);
            // 
            // btnRelClientes
            // 
            this.btnRelClientes.Enabled = false;
            this.btnRelClientes.Location = new System.Drawing.Point(39, 40);
            this.btnRelClientes.Name = "btnRelClientes";
            this.btnRelClientes.Size = new System.Drawing.Size(157, 50);
            this.btnRelClientes.TabIndex = 1;
            this.btnRelClientes.Text = "CLIENTES";
            this.btnRelClientes.UseVisualStyleBackColor = true;
            this.btnRelClientes.Click += new System.EventHandler(this.btnRelClientes_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.maskedTextBoxDataFinal);
            this.panel2.Controls.Add(this.maskedTextBoxDataInicial);
            this.panel2.Controls.Add(this.axAcroPDF1);
            this.panel2.Location = new System.Drawing.Point(406, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(932, 669);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(438, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "ATÉ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // maskedTextBoxDataFinal
            // 
            this.maskedTextBoxDataFinal.Location = new System.Drawing.Point(517, 30);
            this.maskedTextBoxDataFinal.Mask = "00/00/0000 90:00";
            this.maskedTextBoxDataFinal.Name = "maskedTextBoxDataFinal";
            this.maskedTextBoxDataFinal.Size = new System.Drawing.Size(147, 20);
            this.maskedTextBoxDataFinal.TabIndex = 4;
            this.maskedTextBoxDataFinal.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBoxDataInicial
            // 
            this.maskedTextBoxDataInicial.Location = new System.Drawing.Point(250, 30);
            this.maskedTextBoxDataInicial.Mask = "00/00/0000 90:00";
            this.maskedTextBoxDataInicial.Name = "maskedTextBoxDataInicial";
            this.maskedTextBoxDataInicial.Size = new System.Drawing.Size(153, 20);
            this.maskedTextBoxDataInicial.TabIndex = 3;
            this.maskedTextBoxDataInicial.ValidatingType = typeof(System.DateTime);
            // 
            // axAcroPDF1
            // 
            this.axAcroPDF1.Enabled = true;
            this.axAcroPDF1.Location = new System.Drawing.Point(77, 56);
            this.axAcroPDF1.Name = "axAcroPDF1";
            this.axAcroPDF1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAcroPDF1.OcxState")));
            this.axAcroPDF1.Size = new System.Drawing.Size(775, 575);
            this.axAcroPDF1.TabIndex = 2;
            // 
            // btnRelVendasCanceladas
            // 
            this.btnRelVendasCanceladas.Enabled = false;
            this.btnRelVendasCanceladas.Location = new System.Drawing.Point(39, 487);
            this.btnRelVendasCanceladas.Name = "btnRelVendasCanceladas";
            this.btnRelVendasCanceladas.Size = new System.Drawing.Size(157, 50);
            this.btnRelVendasCanceladas.TabIndex = 6;
            this.btnRelVendasCanceladas.Text = "VENDAS CANCELADAS";
            this.btnRelVendasCanceladas.UseVisualStyleBackColor = true;
            this.btnRelVendasCanceladas.Click += new System.EventHandler(this.btnRelVendasCanceladas_Click);
            // 
            // Relatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Relatorios";
            this.Text = "Relatorios";
            this.Load += new System.EventHandler(this.Relatorios_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRelFornecedores;
        private System.Windows.Forms.Button btnRelClientes;
        private System.Windows.Forms.Button btnRelServicos;
        private System.Windows.Forms.Button btnRelVendas;
        private System.Windows.Forms.Button btnRelCompras;
        private System.Windows.Forms.Panel panel2;
        private AxAcroPDFLib.AxAcroPDF axAcroPDF1;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDataInicial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDataFinal;
        private System.Windows.Forms.Button btnRelVendasCanceladas;
    }
}