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
    public partial class FormConta : Form
    {

        ContextoDeDados dbConta = new ContextoDeDados();
        public FormConta()
        {
            InitializeComponent();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            Conta newConta = new Conta();
            newConta.DataConta = DateTime.Parse(txtDataConta.Text);
            newConta.DataConta = DateTime.Parse(txtDataConta.Text);

            dbConta.Contas.Add(newConta);
            dbConta.SaveChanges();            
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            List<Conta> contas = dbConta.Contas.ToList();
            dataGridViewConta.DataSource = contas;
        }

        Conta contaselecionada;

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            contaselecionada.DataConta = DateTime.Parse(txtDataConta.Text);
            contaselecionada.TipoConta = txtTipoConta.Text;

            dbConta.Entry(contaselecionada).State = System.Data.Entity.EntityState.Modified;
            dbConta.SaveChanges();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            contaselecionada.DataConta = DateTime.Parse(txtDataConta.Text);
            contaselecionada.TipoConta = txtTipoConta.Text;

            dbConta.Entry(contaselecionada).State = System.Data.Entity.EntityState.Deleted;
            dbConta.SaveChanges();
        }

        private void dataGridViewConta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            contaselecionada = (Conta)dataGridViewConta.Rows[e.RowIndex].DataBoundItem;

            txtDataConta.Text = System.Convert.ToString(contaselecionada.DataConta);
            txtTipoConta.Text = contaselecionada.TipoConta;
        }

        public void LimpaTexto()
        {
            txtDataConta.Text = "";
            txtTipoConta.Text = "";
            contaselecionada = null;
        }
    }
}
