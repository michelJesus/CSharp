using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplicationApsFinal
{
    public partial class Form1 : Form
    {
        ContextoDeDados db = new ContextoDeDados();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            Pessoa newPessoa = new Pessoa();
            newPessoa.Data = DateTime.Parse(txtData.Text);
            newPessoa.Nome = txtNome.Text;
            newPessoa.Endereco = txtEndereco.Text;
            newPessoa.Cpf = int.Parse(txtCpf.Text);

            db.Pessoas.Add(newPessoa);
            db.SaveChanges();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            List<Pessoa> pessoas = db.Pessoas.ToList();
            dataGridViewPessoa.DataSource = pessoas;
        }

        Pessoa pessoaSelecionada;

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            pessoaSelecionada.Data = DateTime.Parse(txtData.Text);
            pessoaSelecionada.Nome = txtNome.Text;
            pessoaSelecionada.Endereco = txtEndereco.Text;
            pessoaSelecionada.Cpf = int.Parse(txtCpf.Text);

            db.Entry(pessoaSelecionada).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            pessoaSelecionada.Data = DateTime.Parse(txtData.Text);
            pessoaSelecionada.Nome = txtNome.Text;
            pessoaSelecionada.Endereco = txtEndereco.Text;
            pessoaSelecionada.Cpf = int.Parse(txtCpf.Text);

            db.Entry(pessoaSelecionada).State = System.Data.Entity.EntityState.Deleted;
            db.SaveChanges();
        }

        private void dataGridViewPessoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pessoaSelecionada = (Pessoa)dataGridViewPessoa.Rows[e.RowIndex].DataBoundItem;

            txtData.Text = System.Convert.ToString(pessoaSelecionada.Data);
            txtNome.Text = pessoaSelecionada.Nome;
            txtEndereco.Text = pessoaSelecionada.Endereco;
            txtCpf.Text = System.Convert.ToString(pessoaSelecionada.Cpf);
        }

        public void LimpaTexto()
        {
            txtData.Text = "";
            txtNome.Text = "";
            txtEndereco.Text = "";
            txtCpf.Text = "";
            pessoaSelecionada = null;
        }
    }
}
