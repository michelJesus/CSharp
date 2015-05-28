namespace WindowsFormsApplicationAps16122014
{
    partial class FormCredito
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnIncluirCredito = new System.Windows.Forms.Button();
            this.btnListarCredito = new System.Windows.Forms.Button();
            this.btnAlterarCredito = new System.Windows.Forms.Button();
            this.btnExcluirCredito = new System.Windows.Forms.Button();
            this.dataGridViewCredito = new System.Windows.Forms.DataGridView();
            this.txtDataCredito = new System.Windows.Forms.TextBox();
            this.txtValorCredito = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCredito)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data Crédito";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valor Crédito";
            // 
            // btnIncluirCredito
            // 
            this.btnIncluirCredito.Location = new System.Drawing.Point(51, 225);
            this.btnIncluirCredito.Name = "btnIncluirCredito";
            this.btnIncluirCredito.Size = new System.Drawing.Size(75, 23);
            this.btnIncluirCredito.TabIndex = 2;
            this.btnIncluirCredito.Text = "Incluir";
            this.btnIncluirCredito.UseVisualStyleBackColor = true;
            this.btnIncluirCredito.Click += new System.EventHandler(this.btnIncluirCredito_Click);
            // 
            // btnListarCredito
            // 
            this.btnListarCredito.Location = new System.Drawing.Point(195, 225);
            this.btnListarCredito.Name = "btnListarCredito";
            this.btnListarCredito.Size = new System.Drawing.Size(75, 23);
            this.btnListarCredito.TabIndex = 3;
            this.btnListarCredito.Text = "Listar";
            this.btnListarCredito.UseVisualStyleBackColor = true;
            this.btnListarCredito.Click += new System.EventHandler(this.btnListarCredito_Click);
            // 
            // btnAlterarCredito
            // 
            this.btnAlterarCredito.Location = new System.Drawing.Point(339, 225);
            this.btnAlterarCredito.Name = "btnAlterarCredito";
            this.btnAlterarCredito.Size = new System.Drawing.Size(75, 23);
            this.btnAlterarCredito.TabIndex = 4;
            this.btnAlterarCredito.Text = "Alterar";
            this.btnAlterarCredito.UseVisualStyleBackColor = true;
            this.btnAlterarCredito.Click += new System.EventHandler(this.btnAlterarCredito_Click);
            // 
            // btnExcluirCredito
            // 
            this.btnExcluirCredito.Location = new System.Drawing.Point(483, 225);
            this.btnExcluirCredito.Name = "btnExcluirCredito";
            this.btnExcluirCredito.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirCredito.TabIndex = 5;
            this.btnExcluirCredito.Text = "Excluir";
            this.btnExcluirCredito.UseVisualStyleBackColor = true;
            this.btnExcluirCredito.Click += new System.EventHandler(this.btnExcluirCredito_Click);
            // 
            // dataGridViewCredito
            // 
            this.dataGridViewCredito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCredito.Location = new System.Drawing.Point(51, 311);
            this.dataGridViewCredito.Name = "dataGridViewCredito";
            this.dataGridViewCredito.Size = new System.Drawing.Size(507, 150);
            this.dataGridViewCredito.TabIndex = 6;
            this.dataGridViewCredito.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCredito_CellClick);
            // 
            // txtDataCredito
            // 
            this.txtDataCredito.Location = new System.Drawing.Point(51, 71);
            this.txtDataCredito.Name = "txtDataCredito";
            this.txtDataCredito.Size = new System.Drawing.Size(507, 20);
            this.txtDataCredito.TabIndex = 7;
            // 
            // txtValorCredito
            // 
            this.txtValorCredito.Location = new System.Drawing.Point(51, 142);
            this.txtValorCredito.Name = "txtValorCredito";
            this.txtValorCredito.Size = new System.Drawing.Size(507, 20);
            this.txtValorCredito.TabIndex = 8;
            // 
            // FormCredito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 508);
            this.Controls.Add(this.txtValorCredito);
            this.Controls.Add(this.txtDataCredito);
            this.Controls.Add(this.dataGridViewCredito);
            this.Controls.Add(this.btnExcluirCredito);
            this.Controls.Add(this.btnAlterarCredito);
            this.Controls.Add(this.btnListarCredito);
            this.Controls.Add(this.btnIncluirCredito);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormCredito";
            this.Text = "Credito";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCredito)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnIncluirCredito;
        private System.Windows.Forms.Button btnListarCredito;
        private System.Windows.Forms.Button btnAlterarCredito;
        private System.Windows.Forms.Button btnExcluirCredito;
        private System.Windows.Forms.DataGridView dataGridViewCredito;
        private System.Windows.Forms.TextBox txtDataCredito;
        private System.Windows.Forms.TextBox txtValorCredito;
    }
}