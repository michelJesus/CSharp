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
    public partial class FormCredito : Form
    {

        ContextoDeDados dbCredito = new ContextoDeDados()
;
        public FormCredito()
        {
            InitializeComponent();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            Credito newCredito = new Credito();
            newCredito.DataCredito = DateTime.Parse(txtDataCredito.Text);
            newCredito.DescricaoCredito = txtDescricaoCredito.Text;
            newCredito.ValorCredito = int.Parse(txtValorCredito.Text);

            dbCredito.Creditos.Add(newCredito);
            dbCredito.SaveChanges();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            List<Credito> creditos = dbCredito.Creditos.ToList();
            dataGridViewCredito.DataSource = creditos;
        }

        Credito creditoSelecionado;

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            creditoSelecionado.DataCredito = DateTime.Parse(txtDataCredito.Text);
            creditoSelecionado.DescricaoCredito = txtDescricaoCredito.Text;
            creditoSelecionado.ValorCredito = int.Parse(txtValorCredito.Text);

            dbCredito.Entry(creditoSelecionado).State = System.Data.Entity.EntityState.Modified;
            dbCredito.SaveChanges();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            creditoSelecionado.DataCredito = DateTime.Parse(txtDataCredito.Text);
            creditoSelecionado.DescricaoCredito = txtDescricaoCredito.Text;
            creditoSelecionado.ValorCredito = int.Parse(txtValorCredito.Text);

            dbCredito.Entry(creditoSelecionado).State = System.Data.Entity.EntityState.Deleted;
            dbCredito.SaveChanges();
        }

        private void dataGridViewCredito_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            creditoSelecionado = (Credito)dataGridViewCredito.Rows[e.RowIndex].DataBoundItem;

            txtDataCredito.Text = System.Convert.ToString(creditoSelecionado.DataCredito);
            txtDescricaoCredito.Text = creditoSelecionado.DescricaoCredito;
            txtValorCredito.Text = System.Convert.ToString(creditoSelecionado.ValorCredito);
        }

        public void LimpaTexto() {
            txtDataCredito.Text = "";
            txtDescricaoCredito.Text = "";
            creditoSelecionado = null;
        }
    }
}
