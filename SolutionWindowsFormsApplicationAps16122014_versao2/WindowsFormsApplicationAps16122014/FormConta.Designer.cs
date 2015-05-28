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
            this.label4 = new System.Windows.Forms.Label();
            this.txtPessoaId = new System.Windows.Forms.TextBox();
            this.txtNomePessoa = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConta)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIncluirConta
            // 
            this.btnIncluirConta.Location = new System.Drawing.Point(76, 315);
            this.btnIncluirConta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnIncluirConta.Name = "btnIncluirConta";
            this.btnIncluirConta.Size = new System.Drawing.Size(100, 28);
            this.btnIncluirConta.TabIndex = 0;
            this.btnIncluirConta.Text = "Incluir";
            this.btnIncluirConta.UseVisualStyleBackColor = true;
            this.btnIncluirConta.Click += new System.EventHandler(this.btnIncluirConta_Click);
            // 
            // btnListarConta
            // 
            this.btnListarConta.Location = new System.Drawing.Point(252, 315);
            this.btnListarConta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnListarConta.Name = "btnListarConta";
            this.btnListarConta.Size = new System.Drawing.Size(100, 28);
            this.btnListarConta.TabIndex = 1;
            this.btnListarConta.Text = "Listar";
            this.btnListarConta.UseVisualStyleBackColor = true;
            this.btnListarConta.Click += new System.EventHandler(this.btnListarConta_Click);
            // 
            // btnAlterarConta
            // 
            this.btnAlterarConta.Location = new System.Drawing.Point(428, 315);
            this.btnAlterarConta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAlterarConta.Name = "btnAlterarConta";
            this.btnAlterarConta.Size = new System.Drawing.Size(100, 28);
            this.btnAlterarConta.TabIndex = 2;
            this.btnAlterarConta.Text = "Alterar";
            this.btnAlterarConta.UseVisualStyleBackColor = true;
            this.btnAlterarConta.Click += new System.EventHandler(this.btnAlterarConta_Click);
            // 
            // btnExcluirConta
            // 
            this.btnExcluirConta.Location = new System.Drawing.Point(604, 315);
            this.btnExcluirConta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExcluirConta.Name = "btnExcluirConta";
            this.btnExcluirConta.Size = new System.Drawing.Size(100, 28);
            this.btnExcluirConta.TabIndex = 3;
            this.btnExcluirConta.Text = "Excluir";
            this.btnExcluirConta.UseVisualStyleBackColor = true;
            this.btnExcluirConta.Click += new System.EventHandler(this.btnExcluirConta_Click);
            // 
            // dataGridViewConta
            // 
            this.dataGridViewConta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewConta.Location = new System.Drawing.Point(76, 362);
            this.dataGridViewConta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewConta.Name = "dataGridViewConta";
            this.dataGridViewConta.Size = new System.Drawing.Size(629, 185);
            this.dataGridViewConta.TabIndex = 4;
            this.dataGridViewConta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewConta_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 78);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Data Conta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 158);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tipo Conta";
            // 
            // txtDataConta
            // 
            this.txtDataConta.Location = new System.Drawing.Point(76, 114);
            this.txtDataConta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDataConta.Name = "txtDataConta";
            this.txtDataConta.Size = new System.Drawing.Size(627, 22);
            this.txtDataConta.TabIndex = 7;
            // 
            // txtTipoConta
            // 
            this.txtTipoConta.Location = new System.Drawing.Point(76, 194);
            this.txtTipoConta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTipoConta.Name = "txtTipoConta";
            this.txtTipoConta.Size = new System.Drawing.Size(627, 22);
            this.txtTipoConta.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 238);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Saldo Conta";
            // 
            // txtSaldoConta
            // 
            this.txtSaldoConta.Location = new System.Drawing.Point(76, 274);
            this.txtSaldoConta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSaldoConta.Name = "txtSaldoConta";
            this.txtSaldoConta.Size = new System.Drawing.Size(623, 22);
            this.txtSaldoConta.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(79, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Pessoa";
            // 
            // txtPessoaId
            // 
            this.txtPessoaId.Location = new System.Drawing.Point(82, 34);
            this.txtPessoaId.Name = "txtPessoaId";
            this.txtPessoaId.Size = new System.Drawing.Size(100, 22);
            this.txtPessoaId.TabIndex = 12;
            this.txtPessoaId.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPessoaId_KeyUp);
            // 
            // txtNomePessoa
            // 
            this.txtNomePessoa.Location = new System.Drawing.Point(189, 33);
            this.txtNomePessoa.Name = "txtNomePessoa";
            this.txtNomePessoa.Size = new System.Drawing.Size(395, 22);
            this.txtNomePessoa.TabIndex = 13;
            // 
            // FormConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 662);
            this.Controls.Add(this.txtNomePessoa);
            this.Controls.Add(this.txtPessoaId);
            this.Controls.Add(this.label4);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPessoaId;
        private System.Windows.Forms.TextBox txtNomePessoa;
    }
}