namespace WFAppAps
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
            this.txtDataCredito = new System.Windows.Forms.TextBox();
            this.txtValorCredito = new System.Windows.Forms.TextBox();
            this.btnIncluirCredito = new System.Windows.Forms.Button();
            this.btnListarCredito = new System.Windows.Forms.Button();
            this.btnAlterarCredito = new System.Windows.Forms.Button();
            this.btnExcluirCredito = new System.Windows.Forms.Button();
            this.dataGridViewCredito = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCredito)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data Crédito";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valor Crédito";
            // 
            // txtDataCredito
            // 
            this.txtDataCredito.Location = new System.Drawing.Point(40, 94);
            this.txtDataCredito.Name = "txtDataCredito";
            this.txtDataCredito.Size = new System.Drawing.Size(576, 22);
            this.txtDataCredito.TabIndex = 2;
            // 
            // txtValorCredito
            // 
            this.txtValorCredito.Location = new System.Drawing.Point(40, 169);
            this.txtValorCredito.Name = "txtValorCredito";
            this.txtValorCredito.Size = new System.Drawing.Size(576, 22);
            this.txtValorCredito.TabIndex = 3;
            // 
            // btnIncluirCredito
            // 
            this.btnIncluirCredito.Location = new System.Drawing.Point(40, 270);
            this.btnIncluirCredito.Name = "btnIncluirCredito";
            this.btnIncluirCredito.Size = new System.Drawing.Size(75, 23);
            this.btnIncluirCredito.TabIndex = 4;
            this.btnIncluirCredito.Text = "Incluir";
            this.btnIncluirCredito.UseVisualStyleBackColor = true;
            this.btnIncluirCredito.Click += new System.EventHandler(this.btnIncluirCredito_Click);
            // 
            // btnListarCredito
            // 
            this.btnListarCredito.Location = new System.Drawing.Point(207, 270);
            this.btnListarCredito.Name = "btnListarCredito";
            this.btnListarCredito.Size = new System.Drawing.Size(75, 23);
            this.btnListarCredito.TabIndex = 5;
            this.btnListarCredito.Text = "Listar";
            this.btnListarCredito.UseVisualStyleBackColor = true;
            this.btnListarCredito.Click += new System.EventHandler(this.btnListarCredito_Click);
            // 
            // btnAlterarCredito
            // 
            this.btnAlterarCredito.Location = new System.Drawing.Point(374, 270);
            this.btnAlterarCredito.Name = "btnAlterarCredito";
            this.btnAlterarCredito.Size = new System.Drawing.Size(75, 23);
            this.btnAlterarCredito.TabIndex = 6;
            this.btnAlterarCredito.Text = "Alterar";
            this.btnAlterarCredito.UseVisualStyleBackColor = true;
            this.btnAlterarCredito.Click += new System.EventHandler(this.btnAlterarCredito_Click);
            // 
            // btnExcluirCredito
            // 
            this.btnExcluirCredito.Location = new System.Drawing.Point(541, 270);
            this.btnExcluirCredito.Name = "btnExcluirCredito";
            this.btnExcluirCredito.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirCredito.TabIndex = 7;
            this.btnExcluirCredito.Text = "Excluir";
            this.btnExcluirCredito.UseVisualStyleBackColor = true;
            this.btnExcluirCredito.Click += new System.EventHandler(this.btnExcluirCredito_Click);
            // 
            // dataGridViewCredito
            // 
            this.dataGridViewCredito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCredito.Location = new System.Drawing.Point(40, 354);
            this.dataGridViewCredito.Name = "dataGridViewCredito";
            this.dataGridViewCredito.RowTemplate.Height = 24;
            this.dataGridViewCredito.Size = new System.Drawing.Size(577, 150);
            this.dataGridViewCredito.TabIndex = 8;
            this.dataGridViewCredito.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCredito_CellClick);
            // 
            // FormCredito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 606);
            this.Controls.Add(this.dataGridViewCredito);
            this.Controls.Add(this.btnExcluirCredito);
            this.Controls.Add(this.btnAlterarCredito);
            this.Controls.Add(this.btnListarCredito);
            this.Controls.Add(this.btnIncluirCredito);
            this.Controls.Add(this.txtValorCredito);
            this.Controls.Add(this.txtDataCredito);
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
        private System.Windows.Forms.TextBox txtDataCredito;
        private System.Windows.Forms.TextBox txtValorCredito;
        private System.Windows.Forms.Button btnIncluirCredito;
        private System.Windows.Forms.Button btnListarCredito;
        private System.Windows.Forms.Button btnAlterarCredito;
        private System.Windows.Forms.Button btnExcluirCredito;
        private System.Windows.Forms.DataGridView dataGridViewCredito;
    }
}