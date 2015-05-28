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
    public partial class Form4 : Form
    {

        ContextoDeDados db = new ContextoDeDados();

        public Form4()
        {
            InitializeComponent();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            Conta newConta = new Conta();
            newConta.Data = DateTime.Parse(txtData.Text);
            newConta.TipoDaConta = txtTipoDeConta.Text;

            db.Contas.Add(newConta);
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
            contaSelecionada.Data = DateTime.Parse(txtData.Text);
            contaSelecionada.TipoDaConta = txtTipoDeConta.Text;

            db.Entry(contaSelecionada).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            contaSelecionada.Data = DateTime.Parse(txtData.Text);
            contaSelecionada.TipoDaConta = txtTipoDeConta.Text;

            db.Entry(contaSelecionada).State = System.Data.Entity.EntityState.Deleted;
            db.SaveChanges();
        }

        private void dataGridViewConta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            contaSelecionada = (Conta)dataGridViewConta.Rows[e.RowIndex].DataBoundItem;

            txtData.Text = System.Convert.ToString(contaSelecionada.Data);
            txtTipoDeConta.Text = contaSelecionada.TipoDaConta;
        }

        public void LimpaTexto()
        {
            txtData.Text = "";
            txtTipoDeConta.Text = "";
            contaSelecionada = null;
        }
    }
}
