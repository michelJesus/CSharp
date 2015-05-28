namespace WindowsFormsApplicationAps16122014
{
    partial class FormPessoa
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
            this.btnIncluirPessoa = new System.Windows.Forms.Button();
            this.btnListarPessoa = new System.Windows.Forms.Button();
            this.btnAlterarPessoa = new System.Windows.Forms.Button();
            this.btnExcluirPessoa = new System.Windows.Forms.Button();
            this.dataGridViewPessoa = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDataPessoa = new System.Windows.Forms.TextBox();
            this.txtNomePessoa = new System.Windows.Forms.TextBox();
            this.txtCpfPessoa = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPessoa)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIncluirPessoa
            // 
            this.btnIncluirPessoa.Location = new System.Drawing.Point(47, 238);
            this.btnIncluirPessoa.Name = "btnIncluirPessoa";
            this.btnIncluirPessoa.Size = new System.Drawing.Size(75, 23);
            this.btnIncluirPessoa.TabIndex = 0;
            this.btnIncluirPessoa.Text = "Incluir";
            this.btnIncluirPessoa.UseVisualStyleBackColor = true;
            this.btnIncluirPessoa.Click += new System.EventHandler(this.btnIncluirPessoa_Click);
            // 
            // btnListarPessoa
            // 
            this.btnListarPessoa.Location = new System.Drawing.Point(170, 238);
            this.btnListarPessoa.Name = "btnListarPessoa";
            this.btnListarPessoa.Size = new System.Drawing.Size(75, 23);
            this.btnListarPessoa.TabIndex = 1;
            this.btnListarPessoa.Text = "Listar";
            this.btnListarPessoa.UseVisualStyleBackColor = true;
            this.btnListarPessoa.Click += new System.EventHandler(this.btnListarPessoa_Click);
            // 
            // btnAlterarPessoa
            // 
            this.btnAlterarPessoa.Location = new System.Drawing.Point(293, 238);
            this.btnAlterarPessoa.Name = "btnAlterarPessoa";
            this.btnAlterarPessoa.Size = new System.Drawing.Size(75, 23);
            this.btnAlterarPessoa.TabIndex = 2;
            this.btnAlterarPessoa.Text = "Alterar";
            this.btnAlterarPessoa.UseVisualStyleBackColor = true;
            this.btnAlterarPessoa.Click += new System.EventHandler(this.btnAlterarPessoa_Click);
            // 
            // btnExcluirPessoa
            // 
            this.btnExcluirPessoa.Location = new System.Drawing.Point(416, 238);
            this.btnExcluirPessoa.Name = "btnExcluirPessoa";
            this.btnExcluirPessoa.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirPessoa.TabIndex = 3;
            this.btnExcluirPessoa.Text = "Excluir";
            this.btnExcluirPessoa.UseVisualStyleBackColor = true;
            this.btnExcluirPessoa.Click += new System.EventHandler(this.btnExcluirPessoa_Click);
            // 
            // dataGridViewPessoa
            // 
            this.dataGridViewPessoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPessoa.Location = new System.Drawing.Point(47, 296);
            this.dataGridViewPessoa.Name = "dataGridViewPessoa";
            this.dataGridViewPessoa.Size = new System.Drawing.Size(445, 150);
            this.dataGridViewPessoa.TabIndex = 4;
            this.dataGridViewPessoa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPessoa_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Data Pessoa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nome Pessoa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "CPF Pessoa";
            // 
            // txtDataPessoa
            // 
            this.txtDataPessoa.Location = new System.Drawing.Point(47, 47);
            this.txtDataPessoa.Name = "txtDataPessoa";
            this.txtDataPessoa.Size = new System.Drawing.Size(444, 20);
            this.txtDataPessoa.TabIndex = 8;
            // 
            // txtNomePessoa
            // 
            this.txtNomePessoa.Location = new System.Drawing.Point(47, 104);
            this.txtNomePessoa.Name = "txtNomePessoa";
            this.txtNomePessoa.Size = new System.Drawing.Size(444, 20);
            this.txtNomePessoa.TabIndex = 9;
            // 
            // txtCpfPessoa
            // 
            this.txtCpfPessoa.Location = new System.Drawing.Point(47, 161);
            this.txtCpfPessoa.Name = "txtCpfPessoa";
            this.txtCpfPessoa.Size = new System.Drawing.Size(444, 20);
            this.txtCpfPessoa.TabIndex = 10;
            // 
            // FormPessoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 503);
            this.Controls.Add(this.txtCpfPessoa);
            this.Controls.Add(this.txtNomePessoa);
            this.Controls.Add(this.txtDataPessoa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewPessoa);
            this.Controls.Add(this.btnExcluirPessoa);
            this.Controls.Add(this.btnAlterarPessoa);
            this.Controls.Add(this.btnListarPessoa);
            this.Controls.Add(this.btnIncluirPessoa);
            this.Name = "FormPessoa";
            this.Text = "Pessoa";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPessoa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIncluirPessoa;
        private System.Windows.Forms.Button btnListarPessoa;
        private System.Windows.Forms.Button btnAlterarPessoa;
        private System.Windows.Forms.Button btnExcluirPessoa;
        private System.Windows.Forms.DataGridView dataGridViewPessoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDataPessoa;
        private System.Windows.Forms.TextBox txtNomePessoa;
        private System.Windows.Forms.TextBox txtCpfPessoa;
    }
}

