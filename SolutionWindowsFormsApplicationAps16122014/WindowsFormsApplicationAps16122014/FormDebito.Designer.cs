namespace WindowsFormsApplicationAps16122014
{
    partial class FormDebito
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
            this.btnIncluirDebito = new System.Windows.Forms.Button();
            this.btnAlterarDebito = new System.Windows.Forms.Button();
            this.btnListarDebito = new System.Windows.Forms.Button();
            this.btnExcluirDebito = new System.Windows.Forms.Button();
            this.dataGridViewDebito = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.labelValorDebito = new System.Windows.Forms.Label();
            this.txtDataDebito = new System.Windows.Forms.TextBox();
            this.txtValorDebito = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDebito)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIncluirDebito
            // 
            this.btnIncluirDebito.Location = new System.Drawing.Point(31, 259);
            this.btnIncluirDebito.Name = "btnIncluirDebito";
            this.btnIncluirDebito.Size = new System.Drawing.Size(75, 23);
            this.btnIncluirDebito.TabIndex = 0;
            this.btnIncluirDebito.Text = "Incluir";
            this.btnIncluirDebito.UseVisualStyleBackColor = true;
            this.btnIncluirDebito.Click += new System.EventHandler(this.btnIncluirDebito_Click);
            // 
            // btnAlterarDebito
            // 
            this.btnAlterarDebito.Location = new System.Drawing.Point(290, 258);
            this.btnAlterarDebito.Name = "btnAlterarDebito";
            this.btnAlterarDebito.Size = new System.Drawing.Size(75, 23);
            this.btnAlterarDebito.TabIndex = 1;
            this.btnAlterarDebito.Text = "Alterar";
            this.btnAlterarDebito.UseVisualStyleBackColor = true;
            this.btnAlterarDebito.Click += new System.EventHandler(this.btnAlterarDebito_Click);
            // 
            // btnListarDebito
            // 
            this.btnListarDebito.Location = new System.Drawing.Point(166, 258);
            this.btnListarDebito.Name = "btnListarDebito";
            this.btnListarDebito.Size = new System.Drawing.Size(75, 23);
            this.btnListarDebito.TabIndex = 2;
            this.btnListarDebito.Text = "Listar";
            this.btnListarDebito.UseVisualStyleBackColor = true;
            this.btnListarDebito.Click += new System.EventHandler(this.btnListarDebito_Click);
            // 
            // btnExcluirDebito
            // 
            this.btnExcluirDebito.Location = new System.Drawing.Point(427, 258);
            this.btnExcluirDebito.Name = "btnExcluirDebito";
            this.btnExcluirDebito.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirDebito.TabIndex = 3;
            this.btnExcluirDebito.Text = "Excluir";
            this.btnExcluirDebito.UseVisualStyleBackColor = true;
            this.btnExcluirDebito.Click += new System.EventHandler(this.btnExcluirDebito_Click);
            // 
            // dataGridViewDebito
            // 
            this.dataGridViewDebito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDebito.Location = new System.Drawing.Point(31, 340);
            this.dataGridViewDebito.Name = "dataGridViewDebito";
            this.dataGridViewDebito.Size = new System.Drawing.Size(474, 150);
            this.dataGridViewDebito.TabIndex = 4;
            this.dataGridViewDebito.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDebito_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Data Débito";
            // 
            // labelValorDebito
            // 
            this.labelValorDebito.AutoSize = true;
            this.labelValorDebito.Location = new System.Drawing.Point(31, 92);
            this.labelValorDebito.Name = "labelValorDebito";
            this.labelValorDebito.Size = new System.Drawing.Size(65, 13);
            this.labelValorDebito.TabIndex = 6;
            this.labelValorDebito.Text = "Valor Débito";
            // 
            // txtDataDebito
            // 
            this.txtDataDebito.Location = new System.Drawing.Point(31, 54);
            this.txtDataDebito.Name = "txtDataDebito";
            this.txtDataDebito.Size = new System.Drawing.Size(471, 20);
            this.txtDataDebito.TabIndex = 7;
            // 
            // txtValorDebito
            // 
            this.txtValorDebito.Location = new System.Drawing.Point(31, 123);
            this.txtValorDebito.Name = "txtValorDebito";
            this.txtValorDebito.Size = new System.Drawing.Size(471, 20);
            this.txtValorDebito.TabIndex = 8;
            // 
            // FormDebito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 530);
            this.Controls.Add(this.txtValorDebito);
            this.Controls.Add(this.txtDataDebito);
            this.Controls.Add(this.labelValorDebito);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewDebito);
            this.Controls.Add(this.btnExcluirDebito);
            this.Controls.Add(this.btnListarDebito);
            this.Controls.Add(this.btnAlterarDebito);
            this.Controls.Add(this.btnIncluirDebito);
            this.Name = "FormDebito";
            this.Text = "Debito";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDebito)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIncluirDebito;
        private System.Windows.Forms.Button btnAlterarDebito;
        private System.Windows.Forms.Button btnListarDebito;
        private System.Windows.Forms.Button btnExcluirDebito;
        private System.Windows.Forms.DataGridView dataGridViewDebito;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelValorDebito;
        private System.Windows.Forms.TextBox txtDataDebito;
        private System.Windows.Forms.TextBox txtValorDebito;
    }
}