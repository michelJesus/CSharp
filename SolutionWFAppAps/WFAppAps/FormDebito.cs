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
            novoDebito.ValorDebito = int.Parse(txtValorDebito.Text);

            db.Debitos.Add(novoDebito);
            db.SaveChanges();
        }

        private void btnListarDebito_Click(object sender, EventArgs e)
        {
            List<Debito> debitos = db.Debitos.ToList();
            dataGridViewDebito.DataSource = debitos;
        }

        Debito debitoSelecionada;

        private void btnAlterarDebito_Click(object sender, EventArgs e)
        {
            debitoSelecionada.DataDebito = DateTime.Parse(txtDataDebito.Text);
            debitoSelecionada.ValorDebito = int.Parse(txtValorDebito.Text);

            db.Entry(debitoSelecionada).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }

        private void btnExcluirDebito_Click(object sender, EventArgs e)
        {
            debitoSelecionada.DataDebito = DateTime.Parse(txtDataDebito.Text);
            debitoSelecionada.ValorDebito = int.Parse(txtValorDebito.Text);

            db.Entry(debitoSelecionada).State = System.Data.Entity.EntityState.Deleted;
            db.SaveChanges();
        }

        private void dataGridViewDebito_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            debitoSelecionada = (Debito)dataGridViewDebito.Rows[e.RowIndex].DataBoundItem;

            txtDataDebito.Text = System.Convert.ToString(debitoSelecionada.DataDebito);
            txtValorDebito.Text = System.Convert.ToString(debitoSelecionada.ValorDebito);
        }

        public void LimpaTexto() 
        {
            txtDataDebito.Text = "";
            txtValorDebito.Text = "";
            debitoSelecionada = null;
        }
    }
}
