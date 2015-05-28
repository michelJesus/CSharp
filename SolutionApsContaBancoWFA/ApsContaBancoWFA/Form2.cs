using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApsContaBancoWFA
{
    public partial class Form2 : Form
    {
        ContextoDeDados db = new ContextoDeDados();
        public Form2()
        {
            InitializeComponent();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            Despesa novaDespesa = new Despesa();
            novaDespesa.DataDaDespesa = DateTime.Parse(txtDataDaDespesa.Text);
            novaDespesa.DescricaoDaDespesa = txtDescricaoDaDespesa.Text;
            novaDespesa.ValorDaDespesa = decimal.Parse(txtValorDaDespesa.Text);

            db.CadastroDeDespesas.Add(novaDespesa);
            db.SaveChanges();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            List<Despesa> cadastroDeDespesas = db.CadastroDeDespesas.ToList();
            dataGridViewDespesa.DataSource = cadastroDeDespesas;
        }

        Despesa despesaSelecionada;

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            despesaSelecionada.DataDaDespesa = DateTime.Parse(txtDataDaDespesa.Text);
            despesaSelecionada.DescricaoDaDespesa = txtDescricaoDaDespesa.Text;
            despesaSelecionada.ValorDaDespesa = decimal.Parse(txtDescricaoDaDespesa.Text);

            db.Entry(despesaSelecionada).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            despesaSelecionada.DataDaDespesa = DateTime.Parse(txtDataDaDespesa.Text);
            despesaSelecionada.DescricaoDaDespesa = txtDescricaoDaDespesa.Text;
            despesaSelecionada.ValorDaDespesa = decimal.Parse(txtValorDaDespesa.Text);

            db.Entry(despesaSelecionada).State = System.Data.Entity.EntityState.Deleted;
            db.SaveChanges();
        }

        private void dataGridViewDespesa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            despesaSelecionada = (Despesa)dataGridViewDespesa.Rows[e.RowIndex].DataBoundItem;

            txtDataDaDespesa.Text = System.Convert.ToString(despesaSelecionada.DataDaDespesa);
            txtDescricaoDaDespesa.Text = despesaSelecionada.DescricaoDaDespesa;
            txtValorDaDespesa.Text = System.Convert.ToString(despesaSelecionada.ValorDaDespesa);
        }

        public void LimpaTexto() { 
            txtDataDaDespesa.Text = "";
            txtDescricaoDaDespesa.Text = "";
            txtValorDaDespesa.Text = "";
            despesaSelecionada = null;
        }
    }
}
