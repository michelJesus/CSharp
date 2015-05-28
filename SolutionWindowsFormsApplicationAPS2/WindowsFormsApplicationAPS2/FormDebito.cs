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
    public partial class FormDebito : Form
    {

        ContextoDeDados dbDebito = new ContextoDeDados();

        public FormDebito()
        {
            InitializeComponent();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            Debito newDebito = new Debito();
            newDebito.DataDebito = DateTime.Parse(txtDataDebito.Text);
            newDebito.DescricaoDebito = txtDescricaoDebito.Text;
            newDebito.ValorDebito = int.Parse(txtvalorDebito.Text);

            dbDebito.Debitos.Add(newDebito);
            dbDebito.SaveChanges();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            List<Debito> debitos = dbDebito.Debitos.ToList();
            dataGridViewDebito.DataSource = debitos;
        }

        Debito debitoSelecionado;

        private void btnEditar_Click(object sender, EventArgs e)
        {
            debitoSelecionado.DataDebito = DateTime.Parse(txtDataDebito.Text);
            debitoSelecionado.DescricaoDebito = txtDescricaoDebito.Text;
            debitoSelecionado.ValorDebito = int.Parse(txtvalorDebito.Text);

            dbDebito.Entry(debitoSelecionado).State = System.Data.Entity.EntityState.Modified;
            dbDebito.SaveChanges();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            debitoSelecionado.DataDebito = DateTime.Parse(txtDataDebito.Text);
            debitoSelecionado.DescricaoDebito = txtDescricaoDebito.Text;
            debitoSelecionado.ValorDebito = int.Parse(txtvalorDebito.Text);

            dbDebito.Entry(debitoSelecionado).State = System.Data.Entity.EntityState.Deleted;
            dbDebito.SaveChanges();
        }

        private void dataGridViewDebito_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            debitoSelecionado = (Debito)dataGridViewDebito.Rows[e.RowIndex].DataBoundItem;

            txtDataDebito.Text = System.Convert.ToString(debitoSelecionado.DataDebito);
            txtDescricaoDebito.Text = debitoSelecionado.DescricaoDebito;
            txtvalorDebito.Text = System.Convert.ToString(debitoSelecionado.ValorDebito);
        }

        public void LimpaTexto()
        {
            txtDataDebito.Text = "";
            txtDescricaoDebito.Text = "";
            debitoSelecionado = null;
        }
    }
}
