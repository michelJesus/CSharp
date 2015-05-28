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
    public partial class FormConta : Form
    {

        ContextoDeDados db = new ContextoDeDados();
        Pessoa pessoaSelecionada = new Pessoa();

        public FormConta()
        {
            InitializeComponent();
        }

        private void btnIncluirConta_Click(object sender, EventArgs e)
        {
            Conta novaConta = new Conta();
            novaConta.DataConta = DateTime.Parse(txtDataConta.Text);
            novaConta.TipoConta = txtTipoConta.Text;
            novaConta.SaldoConta = int.Parse(txtSaldoConta.Text);
            novaConta.Pessoa = pessoaSelecionada;

            db.Contas.Add(novaConta);
            db.SaveChanges();
        }

        private void btnListarConta_Click(object sender, EventArgs e)
        {
            List<Conta> contas = db.Contas.ToList();
            dataGridViewConta.DataSource = contas;
        }

        Conta contaSelecionada;

        private void btnAlterarConta_Click(object sender, EventArgs e)
        {
            contaSelecionada.DataConta = DateTime.Parse(txtDataConta.Text);
            contaSelecionada.TipoConta = txtTipoConta.Text;
            contaSelecionada.SaldoConta = int.Parse(txtSaldoConta.Text);

            db.Entry(contaSelecionada).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }

        private void btnExcluirConta_Click(object sender, EventArgs e)
        {
            /*contaSelecionada.DataConta = DateTime.Parse(txtDataConta.Text);
            contaSelecionada.TipoConta = txtTipoConta.Text;
            contaSelecionada.SaldoConta = int.Parse(txtSaldoConta.Text);*/

            db.Entry(contaSelecionada).State = System.Data.Entity.EntityState.Deleted;
            db.SaveChanges();
        }

        private void dataGridViewConta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            contaSelecionada = (Conta)dataGridViewConta.Rows[e.RowIndex].DataBoundItem;

            txtDataConta.Text = System.Convert.ToString(contaSelecionada.DataConta);
            txtTipoConta.Text = contaSelecionada.TipoConta;
            txtSaldoConta.Text = System.Convert.ToString(contaSelecionada.SaldoConta);
        }

        public void LimpaTexto()
        {
            txtDataConta.Text = "";
            txtTipoConta.Text = "";
            txtSaldoConta.Text = "";
            contaSelecionada = null;
        }

        private void txtPessoaId_KeyUp(object sender, KeyEventArgs e)
        {
            pessoaSelecionada = db.Pessoas.Find(int.Parse(txtPessoaId.Text));
            txtNomePessoa.Text = pessoaSelecionada.NomePessoa;
        }
        /*
        private void btnCredito_Click(object sender, EventArgs e)
        {
            FormCredito fCre = new FormCredito();
            fCre.Show();
        }

        private void btnDebito_Click(object sender, EventArgs e)
        {
            FormDebito fDeb = new FormDebito();
            fDeb.Show();
        }
         * */
    }
}
