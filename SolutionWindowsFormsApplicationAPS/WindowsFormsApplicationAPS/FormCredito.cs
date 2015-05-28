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
    public partial class FormCredito : Form
    {

        ContextoDeDados db = new ContextoDeDados();

        public FormCredito()
        {
            InitializeComponent();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            Credito novoCredito = new Credito();
            novoCredito.DataCredito = DateTime.Parse(txtDataCredito.Text);
            novoCredito.DescricaoCredito = txtDescricaoCredito.Text;
            novoCredito.valorCredito = decimal.Parse(txtValorCredito.Text);

            db.Creditos.Add(novoCredito);
            db.SaveChanges();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            List<Credito> creditos = db.Creditos.ToList();
            dataGridViewCredito.DataSource = creditos;
        }

        Credito creditoselecionado;

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            creditoselecionado.DataCredito = DateTime.Parse(txtDataCredito.Text);
            creditoselecionado.DescricaoCredito = txtDescricaoCredito.Text;
            creditoselecionado.valorCredito = decimal.Parse(txtValorCredito.Text);

            db.Entry(creditoselecionado).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            creditoselecionado.DataCredito = DateTime.Parse(txtDataCredito.Text);
            creditoselecionado.DescricaoCredito = txtDescricaoCredito.Text;
            creditoselecionado.valorCredito = decimal.Parse(txtValorCredito.Text);

            db.Entry(creditoselecionado).State = System.Data.Entity.EntityState.Deleted;
            db.SaveChanges();
        }

        private void dataGridViewCredito_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            creditoselecionado = (Credito)dataGridViewCredito.Rows[e.RowIndex].DataBoundItem;

            txtDataCredito.Text = System.Convert.ToString(creditoselecionado.DataCredito);
            txtDescricaoCredito.Text = creditoselecionado.DescricaoCredito;
            txtValorCredito.Text = System.Convert.ToString(creditoselecionado.valorCredito);
        }

        public void LimpaTexto()
        {
            txtDataCredito.Text = "";
            txtDescricaoCredito.Text = "";
            txtValorCredito.Text = "";
            creditoselecionado = null;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
