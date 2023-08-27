namespace ClinicaVetWF.Views
{
    partial class CadastrarCompra
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
            this.cbbFornecedor = new System.Windows.Forms.ComboBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.cbbProdsFornecedor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Qtd = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.maskedTextBoxQtd = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbbFornecedor
            // 
            this.cbbFornecedor.FormattingEnabled = true;
            this.cbbFornecedor.Location = new System.Drawing.Point(28, 44);
            this.cbbFornecedor.Name = "cbbFornecedor";
            this.cbbFornecedor.Size = new System.Drawing.Size(354, 21);
            this.cbbFornecedor.TabIndex = 0;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(632, 382);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(129, 57);
            this.btnConfirmar.TabIndex = 1;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // cbbProdsFornecedor
            // 
            this.cbbProdsFornecedor.FormattingEnabled = true;
            this.cbbProdsFornecedor.Location = new System.Drawing.Point(28, 118);
            this.cbbProdsFornecedor.Name = "cbbProdsFornecedor";
            this.cbbProdsFornecedor.Size = new System.Drawing.Size(354, 21);
            this.cbbProdsFornecedor.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Fornecedor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Produtos";
            // 
            // Qtd
            // 
            this.Qtd.AutoSize = true;
            this.Qtd.Location = new System.Drawing.Point(458, 18);
            this.Qtd.Name = "Qtd";
            this.Qtd.Size = new System.Drawing.Size(24, 13);
            this.Qtd.TabIndex = 6;
            this.Qtd.Text = "Qtd";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(214, 405);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(66, 25);
            this.lblTotal.TabIndex = 7;
            this.lblTotal.Text = "Total:";
            // 
            // maskedTextBoxQtd
            // 
            this.maskedTextBoxQtd.Location = new System.Drawing.Point(461, 44);
            this.maskedTextBoxQtd.Mask = "00000";
            this.maskedTextBoxQtd.Name = "maskedTextBoxQtd";
            this.maskedTextBoxQtd.Size = new System.Drawing.Size(35, 20);
            this.maskedTextBoxQtd.TabIndex = 8;
            this.maskedTextBoxQtd.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(109, 405);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Total: R$";
            // 
            // CadastrarCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.maskedTextBoxQtd);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.Qtd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbProdsFornecedor);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.cbbFornecedor);
            this.Name = "CadastrarCompra";
            this.Text = "Total:";
            this.Load += new System.EventHandler(this.CadastrarCompra_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbFornecedor;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.ComboBox cbbProdsFornecedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Qtd;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxQtd;
        private System.Windows.Forms.Label label3;
    }
}