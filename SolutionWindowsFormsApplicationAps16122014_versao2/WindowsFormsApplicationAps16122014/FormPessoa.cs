using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplicationAps16122014
{
    public partial class FormPessoa : Form
    {

        ContextoDeDados db = new ContextoDeDados();

        public FormPessoa()
        {
            InitializeComponent();
        }

        private void btnIncluirPessoa_Click(object sender, EventArgs e)
        {
            Pessoa novaPessoa = new Pessoa();
            novaPessoa.DataPessoa = DateTime.Parse(txtDataPessoa.Text);
            novaPessoa.NomePessoa = txtNomePessoa.Text;
            novaPessoa.CpfPessoa = int.Parse(txtCpfPessoa.Text);

            db.Pessoas.Add(novaPessoa);
            db.SaveChanges();
        }

        private void btnListarPessoa_Click(object sender, EventArgs e)
        {
            List<Pessoa> pessoas = db.Pessoas.ToList();
            dataGridViewPessoa.DataSource = pessoas;
        }

        Pessoa pessoaSelecionada;

        private void btnAlterarPessoa_Click(object sender, EventArgs e)
        {
            pessoaSelecionada.DataPessoa = DateTime.Parse(txtDataPessoa.Text);
            pessoaSelecionada.NomePessoa = txtNomePessoa.Text;
            pessoaSelecionada.CpfPessoa = int.Parse(txtCpfPessoa.Text);

            db.Entry(pessoaSelecionada).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }

        private void btnExcluirPessoa_Click(object sender, EventArgs e)
        {
            pessoaSelecionada.DataPessoa = DateTime.Parse(txtDataPessoa.Text);
            pessoaSelecionada.NomePessoa = txtNomePessoa.Text;
            pessoaSelecionada.CpfPessoa = int.Parse(txtCpfPessoa.Text);

            db.Entry(pessoaSelecionada).State = System.Data.Entity.EntityState.Deleted;
            db.SaveChanges();
        }

        private void dataGridViewPessoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pessoaSelecionada = (Pessoa)dataGridViewPessoa.Rows[e.RowIndex].DataBoundItem;

            txtDataPessoa.Text = System.Convert.ToString(pessoaSelecionada.DataPessoa);
            txtNomePessoa.Text = pessoaSelecionada.NomePessoa;
            txtCpfPessoa.Text = System.Convert.ToString(pessoaSelecionada.CpfPessoa);
        }

        public void LimpaTexto() 
        {
            txtDataPessoa.Text = "";
            txtNomePessoa.Text = "";
            txtCpfPessoa.Text = "";
            pessoaSelecionada = null;
        }
    }
}
