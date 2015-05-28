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
    public partial class Form3 : Form
    {
        ContextoDeDados db = new ContextoDeDados();

        public Form3()
        {
            InitializeComponent();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            Receita newReceita = new Receita();
            newReceita.Data = DateTime.Parse(txtData.Text);
            newReceita.Descricao = txtDescricao.Text;
            newReceita.Valor = decimal.Parse(txtValor.Text);

            db.Receitas.Add(newReceita);
            db.SaveChanges();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            List<Receita> receitas = db.Receitas.ToList();
            dataGridViewReceita.DataSource = receitas;
        }

        Receita receitaSelecionada;

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            receitaSelecionada.Data = DateTime.Parse(txtData.Text);
            receitaSelecionada.Descricao = txtDescricao.Text;
            receitaSelecionada.Valor = decimal.Parse(txtValor.Text);

            db.Entry(receitaSelecionada).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            receitaSelecionada.Data = DateTime.Parse(txtData.Text);
            receitaSelecionada.Descricao = txtDescricao.Text;
            receitaSelecionada.Valor = decimal.Parse(txtValor.Text);

            db.Entry(receitaSelecionada).State = System.Data.Entity.EntityState.Deleted;
            db.SaveChanges();
        }

        private void dataGridViewReceita_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            receitaSelecionada = (Receita)dataGridViewReceita.Rows[e.RowIndex].DataBoundItem;

            txtData.Text = System.Convert.ToString(receitaSelecionada.Data);
            txtDescricao.Text = receitaSelecionada.Descricao;
            txtValor.Text = System.Convert.ToString(receitaSelecionada.Valor);
        }

        public void LimpaTexto()
        {
            txtData.Text = "";
            txtDescricao.Text = "";
            txtValor.Text = "";
            receitaSelecionada = null;
        }


    }
}
