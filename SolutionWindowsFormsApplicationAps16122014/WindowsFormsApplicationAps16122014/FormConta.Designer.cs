namespace WindowsFormsApplicationAps16122014
{
    partial class FormConta
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
            this.btnIncluirConta = new System.Windows.Forms.Button();
            this.btnListarConta = new System.Windows.Forms.Button();
            this.btnAlterarConta = new System.Windows.Forms.Button();
            this.btnExcluirConta = new System.Windows.Forms.Button();
            this.dataGridViewConta = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDataConta = new System.Windows.Forms.TextBox();
            this.txtTipoConta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSaldoConta = new System.Windows.Forms.TextBox();
            this.btnCredito = new System.Windows.Forms.Button();
            this.btnDebito = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConta)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIncluirConta
            // 
            this.btnIncluirConta.Location = new System.Drawing.Point(57, 256);
            this.btnIncluirConta.Name = "btnIncluirConta";
            this.btnIncluirConta.Size = new System.Drawing.Size(75, 23);
            this.btnIncluirConta.TabIndex = 0;
            this.btnIncluirConta.Text = "Incluir";
            this.btnIncluirConta.UseVisualStyleBackColor = true;
            this.btnIncluirConta.Click += new System.EventHandler(this.btnIncluirConta_Click);
            // 
            // btnListarConta
            // 
            this.btnListarConta.Location = new System.Drawing.Point(189, 256);
            this.btnListarConta.Name = "btnListarConta";
            this.btnListarConta.Size = new System.Drawing.Size(75, 23);
            this.btnListarConta.TabIndex = 1;
            this.btnListarConta.Text = "Listar";
            this.btnListarConta.UseVisualStyleBackColor = true;
            this.btnListarConta.Click += new System.EventHandler(this.btnListarConta_Click);
            // 
            // btnAlterarConta
            // 
            this.btnAlterarConta.Location = new System.Drawing.Point(321, 256);
            this.btnAlterarConta.Name = "btnAlterarConta";
            this.btnAlterarConta.Size = new System.Drawing.Size(75, 23);
            this.btnAlterarConta.TabIndex = 2;
            this.btnAlterarConta.Text = "Alterar";
            this.btnAlterarConta.UseVisualStyleBackColor = true;
            this.btnAlterarConta.Click += new System.EventHandler(this.btnAlterarConta_Click);
            // 
            // btnExcluirConta
            // 
            this.btnExcluirConta.Location = new System.Drawing.Point(453, 256);
            this.btnExcluirConta.Name = "btnExcluirConta";
            this.btnExcluirConta.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirConta.TabIndex = 3;
            this.btnExcluirConta.Text = "Excluir";
            this.btnExcluirConta.UseVisualStyleBackColor = true;
            this.btnExcluirConta.Click += new System.EventHandler(this.btnExcluirConta_Click);
            // 
            // dataGridViewConta
            // 
            this.dataGridViewConta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewConta.Location = new System.Drawing.Point(57, 294);
            this.dataGridViewConta.Name = "dataGridViewConta";
            this.dataGridViewConta.Size = new System.Drawing.Size(472, 150);
            this.dataGridViewConta.TabIndex = 4;
            this.dataGridViewConta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewConta_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Data Conta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tipo Conta";
            // 
            // txtDataConta
            // 
            this.txtDataConta.Location = new System.Drawing.Point(57, 69);
            this.txtDataConta.Name = "txtDataConta";
            this.txtDataConta.Size = new System.Drawing.Size(471, 20);
            this.txtDataConta.TabIndex = 7;
            // 
            // txtTipoConta
            // 
            this.txtTipoConta.Location = new System.Drawing.Point(57, 134);
            this.txtTipoConta.Name = "txtTipoConta";
            this.txtTipoConta.Size = new System.Drawing.Size(471, 20);
            this.txtTipoConta.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Saldo Conta";
            // 
            // txtSaldoConta
            // 
            this.txtSaldoConta.Location = new System.Drawing.Point(57, 199);
            this.txtSaldoConta.Name = "txtSaldoConta";
            this.txtSaldoConta.Size = new System.Drawing.Size(468, 20);
            this.txtSaldoConta.TabIndex = 10;
            // 
            // btnCredito
            // 
            this.btnCredito.Location = new System.Drawing.Point(281, 467);
            this.btnCredito.Name = "btnCredito";
            this.btnCredito.Size = new System.Drawing.Size(119, 23);
            this.btnCredito.TabIndex = 11;
            this.btnCredito.Text = "Crédito";
            this.btnCredito.UseVisualStyleBackColor = true;
            this.btnCredito.Click += new System.EventHandler(this.btnCredito_Click);
            // 
            // btnDebito
            // 
            this.btnDebito.Location = new System.Drawing.Point(406, 466);
            this.btnDebito.Name = "btnDebito";
            this.btnDebito.Size = new System.Drawing.Size(119, 23);
            this.btnDebito.TabIndex = 12;
            this.btnDebito.Text = "Débito";
            this.btnDebito.UseVisualStyleBackColor = true;
            this.btnDebito.Click += new System.EventHandler(this.btnDebito_Click);
            // 
            // FormConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 538);
            this.Controls.Add(this.btnDebito);
            this.Controls.Add(this.btnCredito);
            this.Controls.Add(this.txtSaldoConta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTipoConta);
            this.Controls.Add(this.txtDataConta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewConta);
            this.Controls.Add(this.btnExcluirConta);
            this.Controls.Add(this.btnAlterarConta);
            this.Controls.Add(this.btnListarConta);
            this.Controls.Add(this.btnIncluirConta);
            this.Name = "FormConta";
            this.Text = "Conta";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIncluirConta;
        private System.Windows.Forms.Button btnListarConta;
        private System.Windows.Forms.Button btnAlterarConta;
        private System.Windows.Forms.Button btnExcluirConta;
        private System.Windows.Forms.DataGridView dataGridViewConta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDataConta;
        private System.Windows.Forms.TextBox txtTipoConta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSaldoConta;
        private System.Windows.Forms.Button btnCredito;
        private System.Windows.Forms.Button btnDebito;
    }
}