namespace WFAppAps
{
    partial class FormPrincipal
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
            this.btnCadastrarPessoa = new System.Windows.Forms.Button();
            this.btnCadastrarConta = new System.Windows.Forms.Button();
            this.btnCadastrarCredito = new System.Windows.Forms.Button();
            this.btnCadastrarDebito = new System.Windows.Forms.Button();
            this.dataGridViewResumo = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResumo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCadastrarPessoa
            // 
            this.btnCadastrarPessoa.Location = new System.Drawing.Point(57, 50);
            this.btnCadastrarPessoa.Name = "btnCadastrarPessoa";
            this.btnCadastrarPessoa.Size = new System.Drawing.Size(219, 46);
            this.btnCadastrarPessoa.TabIndex = 0;
            this.btnCadastrarPessoa.Text = "Cadastrar Pessoa";
            this.btnCadastrarPessoa.UseVisualStyleBackColor = true;
            this.btnCadastrarPessoa.Click += new System.EventHandler(this.btnCadastrarPessoa_Click);
            // 
            // btnCadastrarConta
            // 
            this.btnCadastrarConta.Location = new System.Drawing.Point(57, 135);
            this.btnCadastrarConta.Name = "btnCadastrarConta";
            this.btnCadastrarConta.Size = new System.Drawing.Size(219, 46);
            this.btnCadastrarConta.TabIndex = 1;
            this.btnCadastrarConta.Text = "Cadastrar Conta";
            this.btnCadastrarConta.UseVisualStyleBackColor = true;
            this.btnCadastrarConta.Click += new System.EventHandler(this.btnCadastrarConta_Click);
            // 
            // btnCadastrarCredito
            // 
            this.btnCadastrarCredito.Location = new System.Drawing.Point(57, 220);
            this.btnCadastrarCredito.Name = "btnCadastrarCredito";
            this.btnCadastrarCredito.Size = new System.Drawing.Size(219, 46);
            this.btnCadastrarCredito.TabIndex = 2;
            this.btnCadastrarCredito.Text = "Cadastrar Crédito";
            this.btnCadastrarCredito.UseVisualStyleBackColor = true;
            this.btnCadastrarCredito.Click += new System.EventHandler(this.btnCadastrarCredito_Click);
            // 
            // btnCadastrarDebito
            // 
            this.btnCadastrarDebito.Location = new System.Drawing.Point(57, 305);
            this.btnCadastrarDebito.Name = "btnCadastrarDebito";
            this.btnCadastrarDebito.Size = new System.Drawing.Size(219, 46);
            this.btnCadastrarDebito.TabIndex = 3;
            this.btnCadastrarDebito.Text = "Cadastrar Débito";
            this.btnCadastrarDebito.UseVisualStyleBackColor = true;
            this.btnCadastrarDebito.Click += new System.EventHandler(this.btnCadastrarDebito_Click);
            // 
            // dataGridViewResumo
            // 
            this.dataGridViewResumo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResumo.Location = new System.Drawing.Point(57, 404);
            this.dataGridViewResumo.Name = "dataGridViewResumo";
            this.dataGridViewResumo.RowTemplate.Height = 24;
            this.dataGridViewResumo.Size = new System.Drawing.Size(612, 276);
            this.dataGridViewResumo.TabIndex = 4;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 731);
            this.Controls.Add(this.dataGridViewResumo);
            this.Controls.Add(this.btnCadastrarDebito);
            this.Controls.Add(this.btnCadastrarCredito);
            this.Controls.Add(this.btnCadastrarConta);
            this.Controls.Add(this.btnCadastrarPessoa);
            this.Name = "FormPrincipal";
            this.Text = "Principal";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResumo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrarPessoa;
        private System.Windows.Forms.Button btnCadastrarConta;
        private System.Windows.Forms.Button btnCadastrarCredito;
        private System.Windows.Forms.Button btnCadastrarDebito;
        private System.Windows.Forms.DataGridView dataGridViewResumo;
    }
}