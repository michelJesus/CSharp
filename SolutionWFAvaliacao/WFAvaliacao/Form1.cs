using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAvaliacao
{
    public partial class Form1 : Form
    {

        ContextoDeDados db = new ContextoDeDados();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Conta novaConta = new Conta();
            //novaConta.DataDeAbertura = int.Parse(txtDataDeAbertura.Text);
            novaConta.DataDeAbertura = DateTime.Parse(txtDataDeAbertura.Text);
            novaConta.Identificacao = txtIdentificacao.Text;
            novaConta.Correntista = txtCorrentista.Text;
            novaConta.Saldo = double.Parse(txtSaldo.Text);

            db.Contas.Add(novaConta);
            db.SaveChanges();

            LimpaTexto();
            List<Conta> contas = db.Contas.ToList();
            dgvDados.DataSource = contas;
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            List<Conta> contas = db.Contas.ToList();
            dgvDados.DataSource = contas;

            LimpaTexto();
        }

        Conta contaSelecionado;

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            //contaSelecionado.DataDeAbertura = int.Parse(txtDataDeAbertura.Text);
            contaSelecionado.DataDeAbertura = DateTime.Parse(txtDataDeAbertura.Text);
            contaSelecionado.Identificacao = txtIdentificacao.Text;
            contaSelecionado.Correntista = txtCorrentista.Text;
            contaSelecionado.Saldo = double.Parse(txtSaldo.Text);

            db.Entry(contaSelecionado).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();

            LimpaTexto();
            List<Conta> contas = db.Contas.ToList();
            dgvDados.DataSource = contas;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
           // contaSelecionado.DataDeAbertura = int.Parse(txtDataDeAbertura.Text);
            contaSelecionado.DataDeAbertura = DateTime.Parse(txtDataDeAbertura.Text);
            contaSelecionado.Identificacao = txtIdentificacao.Text;
            contaSelecionado.Correntista = txtCorrentista.Text;
            contaSelecionado.Saldo = double.Parse(txtSaldo.Text);

            db.Entry(contaSelecionado).State = System.Data.Entity.EntityState.Deleted;
            db.SaveChanges();

            LimpaTexto();
            List<Conta> contas = db.Contas.ToList();
            dgvDados.DataSource = contas;
        }

        private void dgvDados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            contaSelecionado = (Conta)dgvDados.Rows[e.RowIndex].DataBoundItem;

            txtDataDeAbertura.Text = System.Convert.ToString(contaSelecionado.DataDeAbertura);
            txtIdentificacao.Text = contaSelecionado.Identificacao;
            txtCorrentista.Text = contaSelecionado.Correntista;
            txtSaldo.Text = System.Convert.ToString(contaSelecionado.Saldo);
        }

        public void LimpaTexto() {
            txtDataDeAbertura.Text = "";
            txtIdentificacao.Text = "";
            txtCorrentista.Text = "";
            txtSaldo.Text = "";
            contaSelecionado = null;
        }


    }
}
