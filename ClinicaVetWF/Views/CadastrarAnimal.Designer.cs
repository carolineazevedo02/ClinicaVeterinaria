namespace ClinicaVetWF.Views
{
    partial class CadastrarAnimal
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
            this.cbbTutor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbEspecie = new System.Windows.Forms.ComboBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.txbNomeAnimal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.maskedTextBoxDataNasc = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.maskedTextBoxNumeroIdent = new System.Windows.Forms.MaskedTextBox();
            this.txbCorAnimal = new System.Windows.Forms.TextBox();
            this.btnSelecionarCor = new System.Windows.Forms.Button();
            this.btnConfirmarCadastroAnimal = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txbObs = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbbTutor
            // 
            this.cbbTutor.FormattingEnabled = true;
            this.cbbTutor.Location = new System.Drawing.Point(59, 75);
            this.cbbTutor.Name = "cbbTutor";
            this.cbbTutor.Size = new System.Drawing.Size(486, 21);
            this.cbbTutor.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tutor *";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(254, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Espécie *";
            // 
            // cbbEspecie
            // 
            this.cbbEspecie.FormattingEnabled = true;
            this.cbbEspecie.Location = new System.Drawing.Point(257, 214);
            this.cbbEspecie.Name = "cbbEspecie";
            this.cbbEspecie.Size = new System.Drawing.Size(288, 21);
            this.cbbEspecie.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nome *";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txbNomeAnimal
            // 
            this.txbNomeAnimal.Location = new System.Drawing.Point(59, 147);
            this.txbNomeAnimal.Name = "txbNomeAnimal";
            this.txbNomeAnimal.Size = new System.Drawing.Size(329, 20);
            this.txbNomeAnimal.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cor *";
            // 
            // maskedTextBoxDataNasc
            // 
            this.maskedTextBoxDataNasc.Location = new System.Drawing.Point(406, 147);
            this.maskedTextBoxDataNasc.Name = "maskedTextBoxDataNasc";
            this.maskedTextBoxDataNasc.Size = new System.Drawing.Size(136, 20);
            this.maskedTextBoxDataNasc.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(403, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Data de nascimento *";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Número identificador *";
            // 
            // maskedTextBoxNumeroIdent
            // 
            this.maskedTextBoxNumeroIdent.Location = new System.Drawing.Point(59, 214);
            this.maskedTextBoxNumeroIdent.Name = "maskedTextBoxNumeroIdent";
            this.maskedTextBoxNumeroIdent.Size = new System.Drawing.Size(102, 20);
            this.maskedTextBoxNumeroIdent.TabIndex = 10;
            this.maskedTextBoxNumeroIdent.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBoxNumeroIdent_MaskInputRejected);
            // 
            // txbCorAnimal
            // 
            this.txbCorAnimal.Location = new System.Drawing.Point(59, 277);
            this.txbCorAnimal.Name = "txbCorAnimal";
            this.txbCorAnimal.Size = new System.Drawing.Size(240, 20);
            this.txbCorAnimal.TabIndex = 7;
            // 
            // btnSelecionarCor
            // 
            this.btnSelecionarCor.Location = new System.Drawing.Point(305, 273);
            this.btnSelecionarCor.Name = "btnSelecionarCor";
            this.btnSelecionarCor.Size = new System.Drawing.Size(103, 27);
            this.btnSelecionarCor.TabIndex = 12;
            this.btnSelecionarCor.Text = "Selecionar cor";
            this.btnSelecionarCor.UseVisualStyleBackColor = true;
            this.btnSelecionarCor.Click += new System.EventHandler(this.btnSelecionarCor_Click);
            // 
            // btnConfirmarCadastroAnimal
            // 
            this.btnConfirmarCadastroAnimal.Location = new System.Drawing.Point(507, 352);
            this.btnConfirmarCadastroAnimal.Name = "btnConfirmarCadastroAnimal";
            this.btnConfirmarCadastroAnimal.Size = new System.Drawing.Size(121, 47);
            this.btnConfirmarCadastroAnimal.TabIndex = 13;
            this.btnConfirmarCadastroAnimal.Text = "Confirmar";
            this.btnConfirmarCadastroAnimal.UseVisualStyleBackColor = true;
            this.btnConfirmarCadastroAnimal.Click += new System.EventHandler(this.btnConfirmarCadastroAnimal_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txbObs);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnConfirmarCadastroAnimal);
            this.panel1.Controls.Add(this.cbbTutor);
            this.panel1.Controls.Add(this.btnSelecionarCor);
            this.panel1.Controls.Add(this.cbbEspecie);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.maskedTextBoxNumeroIdent);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txbNomeAnimal);
            this.panel1.Controls.Add(this.maskedTextBoxDataNasc);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txbCorAnimal);
            this.panel1.Location = new System.Drawing.Point(76, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(653, 403);
            this.panel1.TabIndex = 14;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txbObs
            // 
            this.txbObs.Location = new System.Drawing.Point(59, 352);
            this.txbObs.Multiline = true;
            this.txbObs.Name = "txbObs";
            this.txbObs.Size = new System.Drawing.Size(301, 48);
            this.txbObs.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(56, 310);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Observações ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(56, 323);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(281, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Se seu pet possui alguma alergia, enfermidade ou alguma ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(56, 336);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(304, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = " informação relevante, por favor, nos informe no campo abaixo.";
            // 
            // CadastrarAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "CadastrarAnimal";
            this.Text = "CadastrarAnimal";
            this.Load += new System.EventHandler(this.CadastrarAnimal_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbTutor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbEspecie;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbNomeAnimal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDataNasc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxNumeroIdent;
        private System.Windows.Forms.TextBox txbCorAnimal;
        private System.Windows.Forms.Button btnSelecionarCor;
        private System.Windows.Forms.Button btnConfirmarCadastroAnimal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbObs;
        private System.Windows.Forms.Label label9;
    }
}