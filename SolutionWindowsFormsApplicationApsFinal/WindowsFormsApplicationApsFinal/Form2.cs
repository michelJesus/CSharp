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
    public partial class Form2 : Form
    {
        ContextoDeDados db = new ContextoDeDados();

        public Form2()
        {
            InitializeComponent();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            Despesa newDespesa = new Despesa();
            newDespesa.Data = DateTime.Parse(txtData.Text);
            newDespesa.Descricao = txtDescricao.Text;
            newDespesa.Valor = decimal.Parse(txtValor.Text);

            db.Despesas.Add(newDespesa);
            db.SaveChanges();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            List<Despesa> despesas = db.Despesas.ToList();
            dataGridViewDespesa.DataSource = despesas;
        }

        Despesa despesaSelecionada;

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            despesaSelecionada.Data = DateTime.Parse(txtData.Text);
            despesaSelecionada.Descricao = txtDescricao.Text;
            despesaSelecionada.Valor = decimal.Parse(txtValor.Text);

            db.Entry(despesaSelecionada).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            despesaSelecionada.Data = DateTime.Parse(txtData.Text);
            despesaSelecionada.Descricao = txtDescricao.Text;
            despesaSelecionada.Valor = decimal.Parse(txtValor.Text);

            db.Entry(despesaSelecionada).State = System.Data.Entity.EntityState.Deleted;
            db.SaveChanges();
        }

        private void dataGridViewDespesa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            despesaSelecionada = (Despesa)dataGridViewDespesa.Rows[e.RowIndex].DataBoundItem;

            txtData.Text = System.Convert.ToString(despesaSelecionada.Data);
            txtDescricao.Text = despesaSelecionada.Descricao;
            txtValor.Text = System.Convert.ToString(despesaSelecionada.Valor);
        }

        public void LimpaTexto()
        {
            txtData.Text = "";
            txtDescricao.Text = "";
            txtValor.Text = "";
            despesaSelecionada = null;
        }


    }
}
