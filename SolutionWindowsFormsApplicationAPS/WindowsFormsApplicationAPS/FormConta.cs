using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplicationAPS
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
            novaConta.DataDaConta = DateTime.Parse(txtDataConta.Text);
            novaConta.TipoDaConta = txtTipoDaConta.Text;

            //List<Conta> lista = db.Contas.ToList();
            //foreach (Conta conta in lista)
            //{
            //    conta.TipoDaConta;
           // }


            db.Contas.Add(novaConta);
            db.SaveChanges();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            List<Conta> contas = db.Contas.ToList();
            dataGridViewConta.DataSource = contas;
        }

        Conta contaSelecionada;

        private void btnEditar_Click(object sender, EventArgs e)
        {
            contaSelecionada.DataDaConta = DateTime.Parse(txtDataConta.Text);
            contaSelecionada.TipoDaConta = txtTipoDaConta.Text;

            db.Entry(contaSelecionada).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            contaSelecionada.DataDaConta = DateTime.Parse(txtDataConta.Text);
            contaSelecionada.TipoDaConta = txtTipoDaConta.Text;

            db.Entry(contaSelecionada).State = System.Data.Entity.EntityState.Deleted;
            db.SaveChanges();
        }

        private void dataGridViewConta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            contaSelecionada = (Conta)dataGridViewConta.Rows[e.RowIndex].DataBoundItem;

            txtDataConta.Text = System.Convert.ToString(contaSelecionada.DataDaConta);
            txtTipoDaConta.Text = contaSelecionada.TipoDaConta;
        }

        public void LimpaTexto() {
            txtDataConta.Text = "";
            txtTipoDaConta.Text = "";
            contaSelecionada = null;
        }

        private void btnAtualizaSaldo_Click(object sender, EventArgs e)
        {
            
            
        }
    }
}