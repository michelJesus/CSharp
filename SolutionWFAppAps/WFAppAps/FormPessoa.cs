using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAppAps
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
            novaPessoa.CpfPessoa = int.Parse(txtCpfPessoa.Text);

            db.Pessoas.Add(novaPessoa);
            db.SaveChanges();
        }

        private void btnListarPessoa_Click(object sender, EventArgs e)
        {
            List<Pessoa> pesssoas = db.Pessoas.ToList();
            dataGridViewPessoa.DataSource = pesssoas;
        }

        Pessoa pessoaSelecionada;

        private void btnAlterarPessoa_Click(object sender, EventArgs e)
        {
            pessoaSelecionada.DataPessoa = DateTime.Parse(txtDataPessoa.Text);
            pessoaSelecionada.CpfPessoa = int.Parse(txtCpfPessoa.Text);

            db.Entry(pessoaSelecionada).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }

        private void btnExcluirPessoa_Click(object sender, EventArgs e)
        {
            pessoaSelecionada.DataPessoa = DateTime.Parse(txtDataPessoa.Text);
            pessoaSelecionada.CpfPessoa = int.Parse(txtCpfPessoa.Text);

            db.Entry(pessoaSelecionada).State = System.Data.Entity.EntityState.Deleted;
            db.SaveChanges();
        }

        private void dataGridViewPessoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pessoaSelecionada = (Pessoa)dataGridViewPessoa.Rows[e.RowIndex].DataBoundItem;

            txtDataPessoa.Text = System.Convert.ToString(pessoaSelecionada.DataPessoa);
            txtCpfPessoa.Text = System.Convert.ToString(pessoaSelecionada.CpfPessoa);
        }

        public void LimpaTexto() 
        {
            txtDataPessoa.Text = "";
            txtCpfPessoa.Text = "";
            pessoaSelecionada = null;
        }


    }
}
