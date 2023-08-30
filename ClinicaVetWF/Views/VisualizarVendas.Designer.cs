namespace ClinicaVetWF.Views
{
    partial class VisualizarVendas
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
            this.listViewVendas = new System.Windows.Forms.ListView();
            this.colunaId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colunaData = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colunaValor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colunaFuncionario = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.maskedTextBoxDataFinal = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxDataInicial = new System.Windows.Forms.MaskedTextBox();
            this.btnCancelarVenda = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewVendas
            // 
            this.listViewVendas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colunaId,
            this.colunaData,
            this.colunaValor,
            this.colunaFuncionario});
            this.listViewVendas.FullRowSelect = true;
            this.listViewVendas.GridLines = true;
            this.listViewVendas.HideSelection = false;
            this.listViewVendas.Location = new System.Drawing.Point(12, 69);
            this.listViewVendas.Name = "listViewVendas";
            this.listViewVendas.Size = new System.Drawing.Size(776, 303);
            this.listViewVendas.TabIndex = 0;
            this.listViewVendas.UseCompatibleStateImageBehavior = false;
            this.listViewVendas.View = System.Windows.Forms.View.Details;
            // 
            // colunaId
            // 
            this.colunaId.Text = "Id";
            // 
            // colunaData
            // 
            this.colunaData.Text = "Data Venda";
            this.colunaData.Width = 130;
            // 
            // colunaValor
            // 
            this.colunaValor.Text = "Valor";
            this.colunaValor.Width = 166;
            // 
            // colunaFuncionario
            // 
            this.colunaFuncionario.Text = "Funcionário";
            this.colunaFuncionario.Width = 420;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label1.Location = new System.Drawing.Point(351, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "ATÉ";
            // 
            // maskedTextBoxDataFinal
            // 
            this.maskedTextBoxDataFinal.Location = new System.Drawing.Point(430, 12);
            this.maskedTextBoxDataFinal.Mask = "00/00/0000 90:00";
            this.maskedTextBoxDataFinal.Name = "maskedTextBoxDataFinal";
            this.maskedTextBoxDataFinal.Size = new System.Drawing.Size(147, 20);
            this.maskedTextBoxDataFinal.TabIndex = 7;
            this.maskedTextBoxDataFinal.ValidatingType = typeof(System.DateTime);
            this.maskedTextBoxDataFinal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.maskedTextBoxDataFinal_KeyDown);
            // 
            // maskedTextBoxDataInicial
            // 
            this.maskedTextBoxDataInicial.Location = new System.Drawing.Point(163, 12);
            this.maskedTextBoxDataInicial.Mask = "00/00/0000 90:00";
            this.maskedTextBoxDataInicial.Name = "maskedTextBoxDataInicial";
            this.maskedTextBoxDataInicial.Size = new System.Drawing.Size(153, 20);
            this.maskedTextBoxDataInicial.TabIndex = 6;
            this.maskedTextBoxDataInicial.ValidatingType = typeof(System.DateTime);
            // 
            // btnCancelarVenda
            // 
            this.btnCancelarVenda.Location = new System.Drawing.Point(616, 391);
            this.btnCancelarVenda.Name = "btnCancelarVenda";
            this.btnCancelarVenda.Size = new System.Drawing.Size(124, 47);
            this.btnCancelarVenda.TabIndex = 9;
            this.btnCancelarVenda.Text = "Cancelar";
            this.btnCancelarVenda.UseVisualStyleBackColor = true;
            this.btnCancelarVenda.Click += new System.EventHandler(this.btnCancelarVenda_Click);
            // 
            // VisualizarVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancelarVenda);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maskedTextBoxDataFinal);
            this.Controls.Add(this.maskedTextBoxDataInicial);
            this.Controls.Add(this.listViewVendas);
            this.Name = "VisualizarVendas";
            this.Text = "VisualizarVendas";
            this.Load += new System.EventHandler(this.VisualizarVendas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewVendas;
        private System.Windows.Forms.ColumnHeader colunaId;
        private System.Windows.Forms.ColumnHeader colunaData;
        private System.Windows.Forms.ColumnHeader colunaValor;
        private System.Windows.Forms.ColumnHeader colunaFuncionario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDataFinal;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDataInicial;
        private System.Windows.Forms.Button btnCancelarVenda;
    }
}