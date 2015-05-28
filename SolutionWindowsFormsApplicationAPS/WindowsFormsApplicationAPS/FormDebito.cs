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
    public partial class FormDebito : Form
    {

        ContextoDeDados db = new ContextoDeDados();

        public FormDebito()
        {
            InitializeComponent();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            Debito novoDedito = new Debito();
            novoDedito.DataDedito = DateTime.Parse(txtDataDedito.Text);
            novoDedito.DescricaoDedito = txtDescricaoDebito.Text;
            novoDedito.valorDedito = decimal.Parse(txtValorDebito.Text);

            db.Debitos.Add(novoDedito);
            db.SaveChanges();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            List<Debito> debitos = db.Debitos.ToList();
            dataGridViewDebito.DataSource = debitos;
        }

        Debito debitoSelecionado;

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            debitoSelecionado.DataDedito = DateTime.Parse(txtDataDedito.Text);
            debitoSelecionado.DescricaoDedito = txtDescricaoDebito.Text;
            debitoSelecionado.valorDedito = decimal.Parse(txtValorDebito.Text);

            db.Entry(debitoSelecionado).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            debitoSelecionado.DataDedito = DateTime.Parse(txtDataDedito.Text);
            debitoSelecionado.DescricaoDedito = txtDescricaoDebito.Text;
            debitoSelecionado.valorDedito = decimal.Parse(txtValorDebito.Text);

            db.Entry(debitoSelecionado).State = System.Data.Entity.EntityState.Deleted;
            db.SaveChanges();
        }

        private void dataGridViewDebito_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            debitoSelecionado = (Debito)dataGridViewDebito.Rows[e.RowIndex].DataBoundItem;

            txtDataDedito.Text = System.Convert.ToString(debitoSelecionado.DataDedito);
            txtDescricaoDebito.Text = debitoSelecionado.DescricaoDedito;
            txtValorDebito.Text = System.Convert.ToString(debitoSelecionado.valorDedito);
        }

        public void LimpaTexto()
        {
            txtDataDedito.Text = "";
            txtDescricaoDebito.Text = "";
            txtValorDebito.Text = "";
            debitoSelecionado = null;
        }

    }
}
