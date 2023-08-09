namespace ClinicaVetWF.Views
{
    partial class CadastroFuncionario
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
            this.btnConfirmarCadastroUsuario = new System.Windows.Forms.Button();
            this.txbLoginCadastro = new System.Windows.Forms.TextBox();
            this.txbSenhaCadastro = new System.Windows.Forms.TextBox();
            this.cbCargos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbNomeCadastroFuncionario = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbEmailCadastroFuncionario = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConfirmarCadastroUsuario
            // 
            this.btnConfirmarCadastroUsuario.Location = new System.Drawing.Point(650, 361);
            this.btnConfirmarCadastroUsuario.Name = "btnConfirmarCadastroUsuario";
            this.btnConfirmarCadastroUsuario.Size = new System.Drawing.Size(126, 66);
            this.btnConfirmarCadastroUsuario.TabIndex = 0;
            this.btnConfirmarCadastroUsuario.Text = "Confirmar";
            this.btnConfirmarCadastroUsuario.UseVisualStyleBackColor = true;
            this.btnConfirmarCadastroUsuario.Click += new System.EventHandler(this.btnConfirmarCadastroUsuario_Click);
            // 
            // txbLoginCadastro
            // 
            this.txbLoginCadastro.Location = new System.Drawing.Point(42, 229);
            this.txbLoginCadastro.Name = "txbLoginCadastro";
            this.txbLoginCadastro.Size = new System.Drawing.Size(186, 20);
            this.txbLoginCadastro.TabIndex = 1;
            // 
            // txbSenhaCadastro
            // 
            this.txbSenhaCadastro.Location = new System.Drawing.Point(42, 292);
            this.txbSenhaCadastro.Name = "txbSenhaCadastro";
            this.txbSenhaCadastro.Size = new System.Drawing.Size(186, 20);
            this.txbSenhaCadastro.TabIndex = 2;
            // 
            // cbCargos
            // 
            this.cbCargos.FormattingEnabled = true;
            this.cbCargos.Location = new System.Drawing.Point(345, 78);
            this.cbCargos.Name = "cbCargos";
            this.cbCargos.Size = new System.Drawing.Size(182, 21);
            this.cbCargos.TabIndex = 3;
            this.cbCargos.SelectedIndexChanged += new System.EventHandler(this.cbCargos_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Usuário ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Senha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(342, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Selecione o cargo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nome";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txbNomeCadastroFuncionario
            // 
            this.txbNomeCadastroFuncionario.Location = new System.Drawing.Point(42, 72);
            this.txbNomeCadastroFuncionario.Name = "txbNomeCadastroFuncionario";
            this.txbNomeCadastroFuncionario.Size = new System.Drawing.Size(186, 20);
            this.txbNomeCadastroFuncionario.TabIndex = 8;
            this.txbNomeCadastroFuncionario.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "E-mail";
            // 
            // txbEmailCadastroFuncionario
            // 
            this.txbEmailCadastroFuncionario.Location = new System.Drawing.Point(42, 147);
            this.txbEmailCadastroFuncionario.Name = "txbEmailCadastroFuncionario";
            this.txbEmailCadastroFuncionario.Size = new System.Drawing.Size(186, 20);
            this.txbEmailCadastroFuncionario.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ClinicaVetWF.Properties.Resources.icone;
            this.pictureBox1.Location = new System.Drawing.Point(609, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // CadastroFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbEmailCadastroFuncionario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbNomeCadastroFuncionario);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbCargos);
            this.Controls.Add(this.txbSenhaCadastro);
            this.Controls.Add(this.txbLoginCadastro);
            this.Controls.Add(this.btnConfirmarCadastroUsuario);
            this.Name = "CadastroFuncionario";
            this.Text = "CadastroFuncionario";
            this.Load += new System.EventHandler(this.CadastroFuncionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConfirmarCadastroUsuario;
        private System.Windows.Forms.TextBox txbLoginCadastro;
        private System.Windows.Forms.TextBox txbSenhaCadastro;
        private System.Windows.Forms.ComboBox cbCargos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbNomeCadastroFuncionario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbEmailCadastroFuncionario;
    }
}