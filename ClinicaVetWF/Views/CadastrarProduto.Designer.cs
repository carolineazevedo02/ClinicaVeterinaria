namespace ClinicaVetWF.Views
{
    partial class CadastrarProduto
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
            this.txbDescricao = new System.Windows.Forms.TextBox();
            this.maskedTextBoxValorCusto = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxValorVenda = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxCodigo = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox4 = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbFornecedor = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.radioButtonAtivo = new System.Windows.Forms.RadioButton();
            this.radioButtonInativo = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // txbDescricao
            // 
            this.txbDescricao.Location = new System.Drawing.Point(74, 45);
            this.txbDescricao.Name = "txbDescricao";
            this.txbDescricao.Size = new System.Drawing.Size(442, 20);
            this.txbDescricao.TabIndex = 0;
            // 
            // maskedTextBoxValorCusto
            // 
            this.maskedTextBoxValorCusto.Location = new System.Drawing.Point(74, 174);
            this.maskedTextBoxValorCusto.Name = "maskedTextBoxValorCusto";
            this.maskedTextBoxValorCusto.Size = new System.Drawing.Size(135, 20);
            this.maskedTextBoxValorCusto.TabIndex = 1;
            // 
            // maskedTextBoxValorVenda
            // 
            this.maskedTextBoxValorVenda.Location = new System.Drawing.Point(250, 174);
            this.maskedTextBoxValorVenda.Name = "maskedTextBoxValorVenda";
            this.maskedTextBoxValorVenda.Size = new System.Drawing.Size(120, 20);
            this.maskedTextBoxValorVenda.TabIndex = 2;
            // 
            // maskedTextBoxCodigo
            // 
            this.maskedTextBoxCodigo.Location = new System.Drawing.Point(74, 104);
            this.maskedTextBoxCodigo.Name = "maskedTextBoxCodigo";
            this.maskedTextBoxCodigo.Size = new System.Drawing.Size(341, 20);
            this.maskedTextBoxCodigo.TabIndex = 3;
            // 
            // maskedTextBox4
            // 
            this.maskedTextBox4.Location = new System.Drawing.Point(437, 104);
            this.maskedTextBox4.Name = "maskedTextBox4";
            this.maskedTextBox4.Size = new System.Drawing.Size(80, 20);
            this.maskedTextBox4.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Desrição";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Valor Custo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(247, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Valor Venda";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Código";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(434, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Qtd";
            // 
            // cbbFornecedor
            // 
            this.cbbFornecedor.FormattingEnabled = true;
            this.cbbFornecedor.Location = new System.Drawing.Point(74, 259);
            this.cbbFornecedor.Name = "cbbFornecedor";
            this.cbbFornecedor.Size = new System.Drawing.Size(443, 21);
            this.cbbFornecedor.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(71, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Fornecedor";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(635, 331);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(117, 50);
            this.btnConfirmar.TabIndex = 13;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // radioButtonAtivo
            // 
            this.radioButtonAtivo.AutoSize = true;
            this.radioButtonAtivo.Location = new System.Drawing.Point(562, 48);
            this.radioButtonAtivo.Name = "radioButtonAtivo";
            this.radioButtonAtivo.Size = new System.Drawing.Size(49, 17);
            this.radioButtonAtivo.TabIndex = 14;
            this.radioButtonAtivo.TabStop = true;
            this.radioButtonAtivo.Text = "Ativo";
            this.radioButtonAtivo.UseVisualStyleBackColor = true;
            // 
            // radioButtonInativo
            // 
            this.radioButtonInativo.AutoSize = true;
            this.radioButtonInativo.Location = new System.Drawing.Point(626, 48);
            this.radioButtonInativo.Name = "radioButtonInativo";
            this.radioButtonInativo.Size = new System.Drawing.Size(57, 17);
            this.radioButtonInativo.TabIndex = 15;
            this.radioButtonInativo.TabStop = true;
            this.radioButtonInativo.Text = "Inativo";
            this.radioButtonInativo.UseVisualStyleBackColor = true;
            // 
            // CadastrarProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.radioButtonInativo);
            this.Controls.Add(this.radioButtonAtivo);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbbFornecedor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maskedTextBox4);
            this.Controls.Add(this.maskedTextBoxCodigo);
            this.Controls.Add(this.maskedTextBoxValorVenda);
            this.Controls.Add(this.maskedTextBoxValorCusto);
            this.Controls.Add(this.txbDescricao);
            this.Name = "CadastrarProduto";
            this.Text = "CadastrarProduto";
            this.Load += new System.EventHandler(this.CadastrarProduto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbDescricao;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxValorCusto;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxValorVenda;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCodigo;
        private System.Windows.Forms.MaskedTextBox maskedTextBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbbFornecedor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.RadioButton radioButtonAtivo;
        private System.Windows.Forms.RadioButton radioButtonInativo;
    }
}