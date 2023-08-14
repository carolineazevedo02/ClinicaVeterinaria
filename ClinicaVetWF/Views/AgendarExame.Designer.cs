namespace ClinicaVetWF.Views
{
    partial class Agendamento
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
            this.cbbAnimal = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbServico = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.txbObservacoes = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTutorNome = new System.Windows.Forms.Label();
            this.lblDataConsulta = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPagamento = new System.Windows.Forms.Button();
            this.btnFinalizarAgendamento = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbbAnimal
            // 
            this.cbbAnimal.FormattingEnabled = true;
            this.cbbAnimal.Location = new System.Drawing.Point(24, 51);
            this.cbbAnimal.Name = "cbbAnimal";
            this.cbbAnimal.Size = new System.Drawing.Size(367, 21);
            this.cbbAnimal.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Animal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Selecione a data";
            // 
            // cbbServico
            // 
            this.cbbServico.FormattingEnabled = true;
            this.cbbServico.Location = new System.Drawing.Point(437, 51);
            this.cbbServico.Name = "cbbServico";
            this.cbbServico.Size = new System.Drawing.Size(330, 21);
            this.cbbServico.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(434, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tipo de Serviço";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(27, 131);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(228, 20);
            this.dateTimePicker.TabIndex = 7;
            this.dateTimePicker.Value = new System.DateTime(2023, 8, 10, 21, 57, 0, 0);
            // 
            // txbObservacoes
            // 
            this.txbObservacoes.Location = new System.Drawing.Point(27, 276);
            this.txbObservacoes.Multiline = true;
            this.txbObservacoes.Name = "txbObservacoes";
            this.txbObservacoes.Size = new System.Drawing.Size(278, 83);
            this.txbObservacoes.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Observações";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(93, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Informações da consulta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Tutor:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Valor a ser cobrado:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Data:";
            // 
            // lblTutorNome
            // 
            this.lblTutorNome.AutoSize = true;
            this.lblTutorNome.Location = new System.Drawing.Point(52, 64);
            this.lblTutorNome.Name = "lblTutorNome";
            this.lblTutorNome.Size = new System.Drawing.Size(0, 13);
            this.lblTutorNome.TabIndex = 14;
            // 
            // lblDataConsulta
            // 
            this.lblDataConsulta.AutoSize = true;
            this.lblDataConsulta.Location = new System.Drawing.Point(50, 100);
            this.lblDataConsulta.Name = "lblDataConsulta";
            this.lblDataConsulta.Size = new System.Drawing.Size(0, 13);
            this.lblDataConsulta.TabIndex = 15;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(118, 133);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(0, 13);
            this.lblValor.TabIndex = 16;
            this.lblValor.Click += new System.EventHandler(this.lblValor_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lblValor);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lblDataConsulta);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.lblTutorNome);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(450, 103);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(317, 201);
            this.panel1.TabIndex = 17;
            // 
            // btnPagamento
            // 
            this.btnPagamento.Location = new System.Drawing.Point(450, 344);
            this.btnPagamento.Name = "btnPagamento";
            this.btnPagamento.Size = new System.Drawing.Size(113, 57);
            this.btnPagamento.TabIndex = 18;
            this.btnPagamento.Text = "Pagamento";
            this.btnPagamento.UseVisualStyleBackColor = true;
            // 
            // btnFinalizarAgendamento
            // 
            this.btnFinalizarAgendamento.Location = new System.Drawing.Point(649, 344);
            this.btnFinalizarAgendamento.Name = "btnFinalizarAgendamento";
            this.btnFinalizarAgendamento.Size = new System.Drawing.Size(118, 57);
            this.btnFinalizarAgendamento.TabIndex = 19;
            this.btnFinalizarAgendamento.Text = "Agendar";
            this.btnFinalizarAgendamento.UseVisualStyleBackColor = true;
            this.btnFinalizarAgendamento.Click += new System.EventHandler(this.btnFinalizarAgendamento_Click);
            // 
            // Agendamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFinalizarAgendamento);
            this.Controls.Add(this.btnPagamento);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbObservacoes);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbbServico);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbAnimal);
            this.Name = "Agendamento";
            this.Text = "AgendarExame";
            this.Load += new System.EventHandler(this.AgendarExame_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbAnimal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbServico;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox txbObservacoes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTutorNome;
        private System.Windows.Forms.Label lblDataConsulta;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPagamento;
        private System.Windows.Forms.Button btnFinalizarAgendamento;
    }
}