namespace ClinicaVetWF.Views
{
    partial class VisualizarAnimais
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisualizarAnimais));
            this.btnCadastrarAnimal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewAnimais = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelLista = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAnimais)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelLista.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCadastrarAnimal
            // 
            this.btnCadastrarAnimal.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrarAnimal.Image")));
            this.btnCadastrarAnimal.Location = new System.Drawing.Point(26, 3);
            this.btnCadastrarAnimal.Name = "btnCadastrarAnimal";
            this.btnCadastrarAnimal.Size = new System.Drawing.Size(100, 76);
            this.btnCadastrarAnimal.TabIndex = 0;
            this.btnCadastrarAnimal.UseVisualStyleBackColor = true;
            this.btnCadastrarAnimal.Click += new System.EventHandler(this.btnCadastrarAnimal_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cadastar Pet";
            // 
            // dataGridViewAnimais
            // 
            this.dataGridViewAnimais.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dataGridViewAnimais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAnimais.Location = new System.Drawing.Point(25, 15);
            this.dataGridViewAnimais.Name = "dataGridViewAnimais";
            this.dataGridViewAnimais.Size = new System.Drawing.Size(694, 181);
            this.dataGridViewAnimais.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCadastrarAnimal);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(787, 151);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panelLista
            // 
            this.panelLista.Controls.Add(this.dataGridViewAnimais);
            this.panelLista.Location = new System.Drawing.Point(38, 193);
            this.panelLista.Margin = new System.Windows.Forms.Padding(10);
            this.panelLista.Name = "panelLista";
            this.panelLista.Size = new System.Drawing.Size(736, 214);
            this.panelLista.TabIndex = 4;
            // 
            // VisualizarAnimais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelLista);
            this.Controls.Add(this.panel1);
            this.Name = "VisualizarAnimais";
            this.Text = "VisualizarAnimais";
            this.Load += new System.EventHandler(this.VisualizarAnimais_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAnimais)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelLista.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrarAnimal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewAnimais;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelLista;
    }
}