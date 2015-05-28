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
    public partial class Form3 : Form
    {

        ContextoDeDados db = new ContextoDeDados();
        public Form3()
        {
            InitializeComponent();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            Receita novaReceita = new Receita();
            novaReceita.DataDaReceita = DateTime.Parse(txtDataDaReceita.Text);
            novaReceita.DescricaoDaReceita = txtDescricaoDaReceita.Text;
            novaReceita.ValorDaReceita = decimal.Parse(txtValorDaReceita.Text);

            db.CadastroDeReceitas.Add(novaReceita);
            db.SaveChanges();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            List<Receita> cadastroDeReceitas = db.CadastroDeReceitas.ToList();
            dataGridViewReceita.DataSource = cadastroDeReceitas;
        }

        Receita receitaSelecionada;

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            receitaSelecionada.DataDaReceita = DateTime.Parse(txtDataDaReceita.Text);
            receitaSelecionada.DescricaoDaReceita = txtDescricaoDaReceita.Text;
            receitaSelecionada.ValorDaReceita = decimal.Parse(txtDescricaoDaReceita.Text);

            db.Entry(receitaSelecionada).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            receitaSelecionada.DataDaReceita = DateTime.Parse(txtDataDaReceita.Text);
            receitaSelecionada.DescricaoDaReceita = txtDescricaoDaReceita.Text;
            receitaSelecionada.ValorDaReceita = decimal.Parse(txtValorDaReceita.Text);

            db.Entry(receitaSelecionada).State = System.Data.Entity.EntityState.Deleted;
            db.SaveChanges();
        }
    }
}
