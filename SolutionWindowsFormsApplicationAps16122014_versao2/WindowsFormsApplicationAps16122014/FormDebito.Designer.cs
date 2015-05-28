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
            this.label2 = new System.Windows.Forms.Label();
            this.txtContaDebito = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDebito)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIncluirDebito
            // 
            this.btnIncluirDebito.Location = new System.Drawing.Point(41, 319);
            this.btnIncluirDebito.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnIncluirDebito.Name = "btnIncluirDebito";
            this.btnIncluirDebito.Size = new System.Drawing.Size(100, 28);
            this.btnIncluirDebito.TabIndex = 0;
            this.btnIncluirDebito.Text = "Incluir";
            this.btnIncluirDebito.UseVisualStyleBackColor = true;
            this.btnIncluirDebito.Click += new System.EventHandler(this.btnIncluirDebito_Click);
            // 
            // btnAlterarDebito
            // 
            this.btnAlterarDebito.Location = new System.Drawing.Point(387, 318);
            this.btnAlterarDebito.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAlterarDebito.Name = "btnAlterarDebito";
            this.btnAlterarDebito.Size = new System.Drawing.Size(100, 28);
            this.btnAlterarDebito.TabIndex = 1;
            this.btnAlterarDebito.Text = "Alterar";
            this.btnAlterarDebito.UseVisualStyleBackColor = true;
            this.btnAlterarDebito.Click += new System.EventHandler(this.btnAlterarDebito_Click);
            // 
            // btnListarDebito
            // 
            this.btnListarDebito.Location = new System.Drawing.Point(221, 318);
            this.btnListarDebito.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnListarDebito.Name = "btnListarDebito";
            this.btnListarDebito.Size = new System.Drawing.Size(100, 28);
            this.btnListarDebito.TabIndex = 2;
            this.btnListarDebito.Text = "Listar";
            this.btnListarDebito.UseVisualStyleBackColor = true;
            this.btnListarDebito.Click += new System.EventHandler(this.btnListarDebito_Click);
            // 
            // btnExcluirDebito
            // 
            this.btnExcluirDebito.Location = new System.Drawing.Point(569, 318);
            this.btnExcluirDebito.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExcluirDebito.Name = "btnExcluirDebito";
            this.btnExcluirDebito.Size = new System.Drawing.Size(100, 28);
            this.btnExcluirDebito.TabIndex = 3;
            this.btnExcluirDebito.Text = "Excluir";
            this.btnExcluirDebito.UseVisualStyleBackColor = true;
            this.btnExcluirDebito.Click += new System.EventHandler(this.btnExcluirDebito_Click);
            // 
            // dataGridViewDebito
            // 
            this.dataGridViewDebito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDebito.Location = new System.Drawing.Point(41, 418);
            this.dataGridViewDebito.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewDebito.Name = "dataGridViewDebito";
            this.dataGridViewDebito.Size = new System.Drawing.Size(632, 185);
            this.dataGridViewDebito.TabIndex = 4;
            this.dataGridViewDebito.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDebito_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 95);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Data Débito";
            // 
            // labelValorDebito
            // 
            this.labelValorDebito.AutoSize = true;
            this.labelValorDebito.Location = new System.Drawing.Point(41, 180);
            this.labelValorDebito.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelValorDebito.Name = "labelValorDebito";
            this.labelValorDebito.Size = new System.Drawing.Size(86, 17);
            this.labelValorDebito.TabIndex = 6;
            this.labelValorDebito.Text = "Valor Débito";
            // 
            // txtDataDebito
            // 
            this.txtDataDebito.Location = new System.Drawing.Point(41, 133);
            this.txtDataDebito.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDataDebito.Name = "txtDataDebito";
            this.txtDataDebito.Size = new System.Drawing.Size(627, 22);
            this.txtDataDebito.TabIndex = 7;
            // 
            // txtValorDebito
            // 
            this.txtValorDebito.Location = new System.Drawing.Point(41, 218);
            this.txtValorDebito.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtValorDebito.Name = "txtValorDebito";
            this.txtValorDebito.Size = new System.Drawing.Size(627, 22);
            this.txtValorDebito.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Conta";
            // 
            // txtContaDebito
            // 
            this.txtContaDebito.Location = new System.Drawing.Point(44, 58);
            this.txtContaDebito.Name = "txtContaDebito";
            this.txtContaDebito.Size = new System.Drawing.Size(100, 22);
            this.txtContaDebito.TabIndex = 10;
            this.txtContaDebito.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtContaDebito_KeyUp);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(173, 58);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(314, 22);
            this.txtNome.TabIndex = 11;
            // 
            // FormDebito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 652);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtContaDebito);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtValorDebito);
            this.Controls.Add(this.txtDataDebito);
            this.Controls.Add(this.labelValorDebito);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewDebito);
            this.Controls.Add(this.btnExcluirDebito);
            this.Controls.Add(this.btnListarDebito);
            this.Controls.Add(this.btnAlterarDebito);
            this.Controls.Add(this.btnIncluirDebito);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtContaDebito;
        private System.Windows.Forms.TextBox txtNome;
    }
}