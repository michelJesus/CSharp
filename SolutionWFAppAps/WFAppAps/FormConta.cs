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
    public partial class FormConta : Form
    {

        ContextoDeDados db = new ContextoDeDados();

        public FormConta()
        {
            InitializeComponent();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            Conta novaConta = new Conta();
            novaConta.DataConta = DateTime.Parse(txtDataConta.Text);
            novaConta.TipoConta = txtTipoConta.Text;

            db.Contas.Add(novaConta);
            db.SaveChanges();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            List<Conta> contas = db.Contas.ToList();
            dataGridViewConta.DataSource = contas;
        }

        Conta contaSelecionada;

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            contaSelecionada.DataConta = DateTime.Parse(txtDataConta.Text);
            contaSelecionada.TipoConta = txtTipoConta.Text;

            db.Entry(contaSelecionada).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            contaSelecionada.DataConta = DateTime.Parse(txtDataConta.Text);
            contaSelecionada.TipoConta = txtTipoConta.Text;

            db.Entry(contaSelecionada).State = System.Data.Entity.EntityState.Deleted;
            db.SaveChanges();
        }

        private void dataGridViewConta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            contaSelecionada = (Conta)dataGridViewConta.Rows[e.RowIndex].DataBoundItem;

            txtTipoConta.Text = System.Convert.ToString(contaSelecionada.DataConta);
            txtTipoConta.Text = contaSelecionada.TipoConta;
        }

        public void LimpaTexto() 
        {
            txtDataConta.Text = "";
            txtTipoConta.Text = "";
            contaSelecionada = null;
        }
    }
}
