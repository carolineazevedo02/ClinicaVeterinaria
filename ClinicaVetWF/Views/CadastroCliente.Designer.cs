namespace ClinicaVetWF.Views
{
    partial class CadastroCliente
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
            this.label1 = new System.Windows.Forms.Label();
            this.txbNomeCliente = new System.Windows.Forms.TextBox();
            this.Telefone = new System.Windows.Forms.Label();
            this.txbEmailCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbRgCliente = new System.Windows.Forms.TextBox();
            this.RG = new System.Windows.Forms.Label();
            this.txbEndereco = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txbCidadeEndereco = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txbCEPEndereco = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txbReferenciaEndereco = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnCadastrarCliente = new System.Windows.Forms.Button();
            this.maskedTextBoxTelefone = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxCPF = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbEstados = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome *";
            // 
            // txbNomeCliente
            // 
            this.txbNomeCliente.Location = new System.Drawing.Point(35, 44);
            this.txbNomeCliente.Name = "txbNomeCliente";
            this.txbNomeCliente.Size = new System.Drawing.Size(496, 20);
            this.txbNomeCliente.TabIndex = 1;
            // 
            // Telefone
            // 
            this.Telefone.AutoSize = true;
            this.Telefone.Location = new System.Drawing.Point(32, 88);
            this.Telefone.Name = "Telefone";
            this.Telefone.Size = new System.Drawing.Size(56, 13);
            this.Telefone.TabIndex = 2;
            this.Telefone.Text = "Telefone *";
            // 
            // txbEmailCliente
            // 
            this.txbEmailCliente.Location = new System.Drawing.Point(266, 115);
            this.txbEmailCliente.Name = "txbEmailCliente";
            this.txbEmailCliente.Size = new System.Drawing.Size(265, 20);
            this.txbEmailCliente.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(263, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "E-mail *";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "CPF *";
            // 
            // txbRgCliente
            // 
            this.txbRgCliente.Location = new System.Drawing.Point(250, 185);
            this.txbRgCliente.Name = "txbRgCliente";
            this.txbRgCliente.Size = new System.Drawing.Size(281, 20);
            this.txbRgCliente.TabIndex = 9;
            // 
            // RG
            // 
            this.RG.AutoSize = true;
            this.RG.Location = new System.Drawing.Point(247, 158);
            this.RG.Name = "RG";
            this.RG.Size = new System.Drawing.Size(30, 13);
            this.RG.TabIndex = 8;
            this.RG.Text = "RG *";
            // 
            // txbEndereco
            // 
            this.txbEndereco.Location = new System.Drawing.Point(35, 242);
            this.txbEndereco.Name = "txbEndereco";
            this.txbEndereco.Size = new System.Drawing.Size(496, 20);
            this.txbEndereco.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Rua/Av *";
            // 
            // txbCidadeEndereco
            // 
            this.txbCidadeEndereco.Location = new System.Drawing.Point(35, 315);
            this.txbCidadeEndereco.Name = "txbCidadeEndereco";
            this.txbCidadeEndereco.Size = new System.Drawing.Size(201, 20);
            this.txbCidadeEndereco.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 288);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Cidade *";
            // 
            // txbCEPEndereco
            // 
            this.txbCEPEndereco.Location = new System.Drawing.Point(250, 315);
            this.txbCEPEndereco.Name = "txbCEPEndereco";
            this.txbCEPEndereco.Size = new System.Drawing.Size(183, 20);
            this.txbCEPEndereco.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(247, 288);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "CEP *";
            // 
            // txbReferenciaEndereco
            // 
            this.txbReferenciaEndereco.Location = new System.Drawing.Point(35, 379);
            this.txbReferenciaEndereco.Name = "txbReferenciaEndereco";
            this.txbReferenciaEndereco.Size = new System.Drawing.Size(496, 20);
            this.txbReferenciaEndereco.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(32, 352);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Referência";
            // 
            // btnCadastrarCliente
            // 
            this.btnCadastrarCliente.Location = new System.Drawing.Point(681, 394);
            this.btnCadastrarCliente.Name = "btnCadastrarCliente";
            this.btnCadastrarCliente.Size = new System.Drawing.Size(83, 44);
            this.btnCadastrarCliente.TabIndex = 18;
            this.btnCadastrarCliente.Text = "Confirmar";
            this.btnCadastrarCliente.UseVisualStyleBackColor = true;
            this.btnCadastrarCliente.Click += new System.EventHandler(this.btnCadastrarCliente_Click);
            // 
            // maskedTextBoxTelefone
            // 
            this.maskedTextBoxTelefone.Location = new System.Drawing.Point(35, 115);
            this.maskedTextBoxTelefone.Name = "maskedTextBoxTelefone";
            this.maskedTextBoxTelefone.Size = new System.Drawing.Size(191, 20);
            this.maskedTextBoxTelefone.TabIndex = 19;
            // 
            // maskedTextBoxCPF
            // 
            this.maskedTextBoxCPF.Location = new System.Drawing.Point(35, 185);
            this.maskedTextBoxCPF.Name = "maskedTextBoxCPF";
            this.maskedTextBoxCPF.Size = new System.Drawing.Size(191, 20);
            this.maskedTextBoxCPF.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(449, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Estado *";
            // 
            // cbbEstados
            // 
            this.cbbEstados.FormattingEnabled = true;
            this.cbbEstados.Location = new System.Drawing.Point(452, 314);
            this.cbbEstados.Name = "cbbEstados";
            this.cbbEstados.Size = new System.Drawing.Size(89, 21);
            this.cbbEstados.TabIndex = 22;
            // 
            // CadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbbEstados);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.maskedTextBoxCPF);
            this.Controls.Add(this.maskedTextBoxTelefone);
            this.Controls.Add(this.btnCadastrarCliente);
            this.Controls.Add(this.txbReferenciaEndereco);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txbCEPEndereco);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txbCidadeEndereco);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txbEndereco);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txbRgCliente);
            this.Controls.Add(this.RG);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbEmailCliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Telefone);
            this.Controls.Add(this.txbNomeCliente);
            this.Controls.Add(this.label1);
            this.Name = "CadastroCliente";
            this.Text = "CadastroCliente";
            this.Load += new System.EventHandler(this.CadastroCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbNomeCliente;
        private System.Windows.Forms.Label Telefone;
        private System.Windows.Forms.TextBox txbEmailCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbRgCliente;
        private System.Windows.Forms.Label RG;
        private System.Windows.Forms.TextBox txbEndereco;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbCidadeEndereco;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbCEPEndereco;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txbReferenciaEndereco;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnCadastrarCliente;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTelefone;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCPF;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbEstados;
    }
}