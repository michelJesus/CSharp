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
    public partial class FormCredito : Form
    {

        ContextoDeDados db = new ContextoDeDados();

        public FormCredito()
        {
            InitializeComponent();
        }

        private void btnIncluirCredito_Click(object sender, EventArgs e)
        {
            Credito novoCredito = new Credito();

            novoCredito.DataCredito = DateTime.Parse(txtDataCredito.Text);
            novoCredito.ValorCredito = int.Parse(txtValorCredito.Text);

            db.Creditos.Add(novoCredito);
            db.SaveChanges();
        }

        private void btnListarCredito_Click(object sender, EventArgs e)
        {
            List<Credito> creditos = db.Creditos.ToList();
            dataGridViewCredito.DataSource = creditos;
        }

        Credito creditoSelecionado;

        private void btnAlterarCredito_Click(object sender, EventArgs e)
        {
            creditoSelecionado.DataCredito = DateTime.Parse(txtDataCredito.Text);
            creditoSelecionado.ValorCredito = int.Parse(txtValorCredito.Text);

            db.Entry(creditoSelecionado).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }

        private void btnExcluirCredito_Click(object sender, EventArgs e)
        {
            creditoSelecionado.DataCredito = DateTime.Parse(txtDataCredito.Text);
            creditoSelecionado.ValorCredito = int.Parse(txtValorCredito.Text);

            db.Entry(creditoSelecionado).State = System.Data.Entity.EntityState.Deleted;
            db.SaveChanges();
        }

        private void dataGridViewCredito_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            creditoSelecionado = (Credito)dataGridViewCredito.Rows[e.RowIndex].DataBoundItem;

            txtDataCredito.Text = System.Convert.ToString(creditoSelecionado.DataCredito);
            txtValorCredito.Text = System.Convert.ToString(creditoSelecionado.ValorCredito);
        }

        public void LimpaTexto() 
        {
            txtDataCredito.Text = "";
            txtValorCredito.Text = "";
            creditoSelecionado = null;
        }




    }
}
