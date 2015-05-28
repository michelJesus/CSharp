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
            this.txtValorCredito = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtContaId = new System.Windows.Forms.TextBox();
            this.txtNomeConta = new System.Windows.Forms.TextBox();
            this.dtpDataCredito = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCredito)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 104);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data Crédito";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 191);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valor Crédito";
            // 
            // btnIncluirCredito
            // 
            this.btnIncluirCredito.Location = new System.Drawing.Point(68, 277);
            this.btnIncluirCredito.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnIncluirCredito.Name = "btnIncluirCredito";
            this.btnIncluirCredito.Size = new System.Drawing.Size(100, 28);
            this.btnIncluirCredito.TabIndex = 2;
            this.btnIncluirCredito.Text = "Incluir";
            this.btnIncluirCredito.UseVisualStyleBackColor = true;
            this.btnIncluirCredito.Click += new System.EventHandler(this.btnIncluirCredito_Click);
            // 
            // btnListarCredito
            // 
            this.btnListarCredito.Location = new System.Drawing.Point(260, 277);
            this.btnListarCredito.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnListarCredito.Name = "btnListarCredito";
            this.btnListarCredito.Size = new System.Drawing.Size(100, 28);
            this.btnListarCredito.TabIndex = 3;
            this.btnListarCredito.Text = "Listar";
            this.btnListarCredito.UseVisualStyleBackColor = true;
            this.btnListarCredito.Click += new System.EventHandler(this.btnListarCredito_Click);
            // 
            // btnAlterarCredito
            // 
            this.btnAlterarCredito.Location = new System.Drawing.Point(452, 277);
            this.btnAlterarCredito.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAlterarCredito.Name = "btnAlterarCredito";
            this.btnAlterarCredito.Size = new System.Drawing.Size(100, 28);
            this.btnAlterarCredito.TabIndex = 4;
            this.btnAlterarCredito.Text = "Alterar";
            this.btnAlterarCredito.UseVisualStyleBackColor = true;
            this.btnAlterarCredito.Click += new System.EventHandler(this.btnAlterarCredito_Click);
            // 
            // btnExcluirCredito
            // 
            this.btnExcluirCredito.Location = new System.Drawing.Point(644, 277);
            this.btnExcluirCredito.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExcluirCredito.Name = "btnExcluirCredito";
            this.btnExcluirCredito.Size = new System.Drawing.Size(100, 28);
            this.btnExcluirCredito.TabIndex = 5;
            this.btnExcluirCredito.Text = "Excluir";
            this.btnExcluirCredito.UseVisualStyleBackColor = true;
            this.btnExcluirCredito.Click += new System.EventHandler(this.btnExcluirCredito_Click);
            // 
            // dataGridViewCredito
            // 
            this.dataGridViewCredito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCredito.Location = new System.Drawing.Point(68, 383);
            this.dataGridViewCredito.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewCredito.Name = "dataGridViewCredito";
            this.dataGridViewCredito.Size = new System.Drawing.Size(676, 185);
            this.dataGridViewCredito.TabIndex = 6;
            this.dataGridViewCredito.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCredito_CellClick);
            // 
            // txtValorCredito
            // 
            this.txtValorCredito.Location = new System.Drawing.Point(68, 227);
            this.txtValorCredito.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtValorCredito.Name = "txtValorCredito";
            this.txtValorCredito.Size = new System.Drawing.Size(675, 22);
            this.txtValorCredito.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Conta";
            // 
            // txtContaId
            // 
            this.txtContaId.Location = new System.Drawing.Point(71, 60);
            this.txtContaId.Name = "txtContaId";
            this.txtContaId.Size = new System.Drawing.Size(97, 22);
            this.txtContaId.TabIndex = 10;
            this.txtContaId.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtContaId_KeyUp);
            // 
            // txtNomeConta
            // 
            this.txtNomeConta.Location = new System.Drawing.Point(174, 60);
            this.txtNomeConta.Name = "txtNomeConta";
            this.txtNomeConta.Size = new System.Drawing.Size(569, 22);
            this.txtNomeConta.TabIndex = 11;
            // 
            // dtpDataCredito
            // 
            this.dtpDataCredito.Location = new System.Drawing.Point(71, 138);
            this.dtpDataCredito.Name = "dtpDataCredito";
            this.dtpDataCredito.Size = new System.Drawing.Size(435, 22);
            this.dtpDataCredito.TabIndex = 12;
            // 
            // FormCredito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 625);
            this.Controls.Add(this.dtpDataCredito);
            this.Controls.Add(this.txtNomeConta);
            this.Controls.Add(this.txtContaId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtValorCredito);
            this.Controls.Add(this.dataGridViewCredito);
            this.Controls.Add(this.btnExcluirCredito);
            this.Controls.Add(this.btnAlterarCredito);
            this.Controls.Add(this.btnListarCredito);
            this.Controls.Add(this.btnIncluirCredito);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.TextBox txtValorCredito;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtContaId;
        private System.Windows.Forms.TextBox txtNomeConta;
        private System.Windows.Forms.DateTimePicker dtpDataCredito;
    }
}