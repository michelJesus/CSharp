namespace WindowsFormsApplicationAps16122014
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
            this.SuspendLayout();
            // 
            // btnCadastrarPessoa
            // 
            this.btnCadastrarPessoa.Location = new System.Drawing.Point(66, 70);
            this.btnCadastrarPessoa.Name = "btnCadastrarPessoa";
            this.btnCadastrarPessoa.Size = new System.Drawing.Size(131, 39);
            this.btnCadastrarPessoa.TabIndex = 0;
            this.btnCadastrarPessoa.Text = "Cadastrar Pessoa";
            this.btnCadastrarPessoa.UseVisualStyleBackColor = true;
            this.btnCadastrarPessoa.Click += new System.EventHandler(this.btnCadastrarPessoa_Click);
            // 
            // btnCadastrarConta
            // 
            this.btnCadastrarConta.Location = new System.Drawing.Point(66, 150);
            this.btnCadastrarConta.Name = "btnCadastrarConta";
            this.btnCadastrarConta.Size = new System.Drawing.Size(131, 39);
            this.btnCadastrarConta.TabIndex = 1;
            this.btnCadastrarConta.Text = "Cadastrar Conta";
            this.btnCadastrarConta.UseVisualStyleBackColor = true;
            this.btnCadastrarConta.Click += new System.EventHandler(this.btnCadastrarConta_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 439);
            this.Controls.Add(this.btnCadastrarConta);
            this.Controls.Add(this.btnCadastrarPessoa);
            this.Name = "FormPrincipal";
            this.Text = "Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrarPessoa;
        private System.Windows.Forms.Button btnCadastrarConta;
    }
}