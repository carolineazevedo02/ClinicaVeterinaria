namespace ClinicaVetWF.Views
{
    partial class Pagamento
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
            this.cbbFormasPgto = new System.Windows.Forms.ComboBox();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.lblValorReceber = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalVenda = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbbFormasPgto
            // 
            this.cbbFormasPgto.FormattingEnabled = true;
            this.cbbFormasPgto.Location = new System.Drawing.Point(33, 184);
            this.cbbFormasPgto.Name = "cbbFormasPgto";
            this.cbbFormasPgto.Size = new System.Drawing.Size(232, 21);
            this.cbbFormasPgto.TabIndex = 0;
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Location = new System.Drawing.Point(623, 369);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(107, 55);
            this.btnFinalizar.TabIndex = 1;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // lblValorReceber
            // 
            this.lblValorReceber.AutoSize = true;
            this.lblValorReceber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorReceber.Location = new System.Drawing.Point(38, 36);
            this.lblValorReceber.Name = "lblValorReceber";
            this.lblValorReceber.Size = new System.Drawing.Size(195, 20);
            this.lblValorReceber.TabIndex = 2;
            this.lblValorReceber.Text = "Valor a receber: R$100,00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Selecione a forma de pagamento";
            // 
            // lblTotalVenda
            // 
            this.lblTotalVenda.AutoSize = true;
            this.lblTotalVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalVenda.Location = new System.Drawing.Point(421, 385);
            this.lblTotalVenda.Name = "lblTotalVenda";
            this.lblTotalVenda.Size = new System.Drawing.Size(137, 20);
            this.lblTotalVenda.TabIndex = 8;
            this.lblTotalVenda.Text = "TOTAL: R$100,00";
            this.lblTotalVenda.Click += new System.EventHandler(this.label3_Click);
            // 
            // Pagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTotalVenda);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblValorReceber);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.cbbFormasPgto);
            this.Name = "Pagamento";
            this.Text = "Pagemento";
            this.Load += new System.EventHandler(this.Pagemento_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbFormasPgto;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Label lblValorReceber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotalVenda;
    }
}