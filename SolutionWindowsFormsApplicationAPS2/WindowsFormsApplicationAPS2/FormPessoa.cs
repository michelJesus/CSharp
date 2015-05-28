using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplicationAPS2
{
    public partial class FormPessoa : Form
    {

        ContextoDeDados dbPessoa = new ContextoDeDados();

        public FormPessoa()
        {
            InitializeComponent();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            Pessoa newPessoa = new Pessoa();
            newPessoa.DataCadastroPessoa = DateTime.Parse(txtDataCadastroPessoa.Text);
            newPessoa.NomePessoa = txtNomePessoa.Text;
            newPessoa.CpfPessoa = int.Parse(txtCpfPessoa.Text);

            dbPessoa.Pessoas.Add(newPessoa);
            dbPessoa.SaveChanges();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            List<Pessoa> pessoas = dbPessoa.Pessoas.ToList();
            dataGridViewPessoa.DataSource = pessoas;
        }

        Pessoa pessoaSelecionada;

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            pessoaSelecionada.DataCadastroPessoa = DateTime.Parse(txtDataCadastroPessoa.Text);
            pessoaSelecionada.NomePessoa = txtNomePessoa.Text;
            pessoaSelecionada.CpfPessoa = int.Parse(txtCpfPessoa.Text);

            dbPessoa.Entry(pessoaSelecionada).State = System.Data.Entity.EntityState.Modified;
            dbPessoa.SaveChanges();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            pessoaSelecionada.DataCadastroPessoa = DateTime.Parse(txtDataCadastroPessoa.Text);
            pessoaSelecionada.NomePessoa = txtNomePessoa.Text;
            pessoaSelecionada.CpfPessoa = int.Parse(txtCpfPessoa.Text);

            dbPessoa.Entry(pessoaSelecionada).State = System.Data.Entity.EntityState.Deleted;
            dbPessoa.SaveChanges();
        }

        private void dataGridViewPessoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pessoaSelecionada = (Pessoa)dataGridViewPessoa.Rows[e.RowIndex].DataBoundItem;

            txtDataCadastroPessoa.Text = System.Convert.ToString(pessoaSelecionada.DataCadastroPessoa);
            txtNomePessoa.Text = pessoaSelecionada.NomePessoa;
            txtCpfPessoa.Text = System.Convert.ToString(pessoaSelecionada.CpfPessoa);
        }

        public void LimpaTexto()
        {
            txtDataCadastroPessoa.Text = "";
            txtNomePessoa.Text = "";
            txtCpfPessoa.Text = "";
            pessoaSelecionada = null;
        }

    }
}
