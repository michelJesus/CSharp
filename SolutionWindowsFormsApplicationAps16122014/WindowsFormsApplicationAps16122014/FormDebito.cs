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
    public partial class FormDebito : Form
    {

        ContextoDeDados db = new ContextoDeDados();

        public FormDebito()
        {
            InitializeComponent();
        }

        private void btnIncluirDebito_Click(object sender, EventArgs e)
        {
            Debito novoDebito = new Debito();
            novoDebito.DataDebito = DateTime.Parse(txtDataDebito.Text);
            novoDebito.ValorDebito = decimal.Parse(txtValorDebito.Text);

            db.Debitos.Add(novoDebito);
            db.SaveChanges();
        }

        private void btnListarDebito_Click(object sender, EventArgs e)
        {
            List<Debito> debitos = db.Debitos.ToList();
            dataGridViewDebito.DataSource = debitos;
        }

        Debito debitoSelecionado;

        private void btnAlterarDebito_Click(object sender, EventArgs e)
        {
            debitoSelecionado.DataDebito = DateTime.Parse(txtDataDebito.Text);
            debitoSelecionado.ValorDebito = decimal.Parse(txtValorDebito.Text);

            db.Entry(debitoSelecionado).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }

        private void btnExcluirDebito_Click(object sender, EventArgs e)
        {
            debitoSelecionado.DataDebito = DateTime.Parse(txtDataDebito.Text);
            debitoSelecionado.ValorDebito = decimal.Parse(txtValorDebito.Text);

            db.Entry(debitoSelecionado).State = System.Data.Entity.EntityState.Deleted;
            db.SaveChanges();
        }

        private void dataGridViewDebito_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            debitoSelecionado = (Debito)dataGridViewDebito.Rows[e.RowIndex].DataBoundItem;

            txtDataDebito.Text = System.Convert.ToString(debitoSelecionado.DataDebito);
            txtValorDebito.Text = System.Convert.ToString(debitoSelecionado.ValorDebito);
        }

        public void LimpaTexto()
        {
            txtDataDebito.Text = "";
            txtValorDebito.Text = "";
            debitoSelecionado = null;
        }
    }
}
