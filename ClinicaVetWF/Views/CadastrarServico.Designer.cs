namespace ClinicaVetWF.Views
{
    partial class CadastrarServico
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
            this.txbDescricaoServico = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbTipoResponsavel = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbMedidaReferencia = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCadastrarServico = new System.Windows.Forms.Button();
            this.maskedTextBoxValor = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbColaborador = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descrição do Serviço";
            // 
            // txbDescricaoServico
            // 
            this.txbDescricaoServico.Location = new System.Drawing.Point(24, 50);
            this.txbDescricaoServico.Name = "txbDescricaoServico";
            this.txbDescricaoServico.Size = new System.Drawing.Size(246, 20);
            this.txbDescricaoServico.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(346, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tipo de profissional";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cbbTipoResponsavel
            // 
            this.cbbTipoResponsavel.FormattingEnabled = true;
            this.cbbTipoResponsavel.Location = new System.Drawing.Point(349, 49);
            this.cbbTipoResponsavel.Name = "cbbTipoResponsavel";
            this.cbbTipoResponsavel.Size = new System.Drawing.Size(307, 21);
            this.cbbTipoResponsavel.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Valor a ser cobrado";
            // 
            // cbbMedidaReferencia
            // 
            this.cbbMedidaReferencia.FormattingEnabled = true;
            this.cbbMedidaReferencia.Location = new System.Drawing.Point(349, 119);
            this.cbbMedidaReferencia.Name = "cbbMedidaReferencia";
            this.cbbMedidaReferencia.Size = new System.Drawing.Size(307, 21);
            this.cbbMedidaReferencia.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(346, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Medida de referência";
            // 
            // btnCadastrarServico
            // 
            this.btnCadastrarServico.Location = new System.Drawing.Point(570, 362);
            this.btnCadastrarServico.Name = "btnCadastrarServico";
            this.btnCadastrarServico.Size = new System.Drawing.Size(114, 45);
            this.btnCadastrarServico.TabIndex = 11;
            this.btnCadastrarServico.Text = "Confirmar";
            this.btnCadastrarServico.UseVisualStyleBackColor = true;
            this.btnCadastrarServico.Click += new System.EventHandler(this.btnCadastrarServico_Click);
            // 
            // maskedTextBoxValor
            // 
            this.maskedTextBoxValor.Location = new System.Drawing.Point(24, 120);
            this.maskedTextBoxValor.Name = "maskedTextBoxValor";
            this.maskedTextBoxValor.Size = new System.Drawing.Size(131, 20);
            this.maskedTextBoxValor.TabIndex = 12;
            this.maskedTextBoxValor.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBoxValor_MaskInputRejected);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(346, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Colaborador";
            // 
            // cbbColaborador
            // 
            this.cbbColaborador.FormattingEnabled = true;
            this.cbbColaborador.Location = new System.Drawing.Point(349, 192);
            this.cbbColaborador.Name = "cbbColaborador";
            this.cbbColaborador.Size = new System.Drawing.Size(307, 21);
            this.cbbColaborador.TabIndex = 15;
            // 
            // CadastrarServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbbColaborador);
            this.Controls.Add(this.maskedTextBoxValor);
            this.Controls.Add(this.btnCadastrarServico);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbbMedidaReferencia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbbTipoResponsavel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbDescricaoServico);
            this.Controls.Add(this.label1);
            this.Name = "CadastrarServico";
            this.Text = "CadastrarServico";
            this.Load += new System.EventHandler(this.CadastrarServico_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbDescricaoServico;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbTipoResponsavel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbMedidaReferencia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCadastrarServico;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxValor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbColaborador;
    }
}