using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFApsExercicio2.Model;

namespace WFApsExercicio2
{
    public partial class FormCadastroProduto : Form
    {
        ContextoDeDados db = new ContextoDeDados();
        Produto produtoSelecionado;
        public FormCadastroProduto()
        {
            InitializeComponent();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Produto p = new Produto();
            p.Nome = txtNomeProduto.Text;
            db.Produtos.Add(p);
            db.SaveChanges();
            txtNomeProduto.Text = "";
            PopularGrid();
        }

        private void PopularGrid()
        {
            gdrView.DataSource = db.Produtos.ToList();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            PopularGrid();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            produtoSelecionado.Nome = txtNomeProduto.Text;
            db.Entry(produtoSelecionado).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            PopularGrid();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            db.Entry(produtoSelecionado).State = System.Data.Entity.EntityState.Deleted;
            db.SaveChanges();
            PopularGrid();
        }

        private void gdrView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            produtoSelecionado = (Produto)gdrView.Rows[e.RowIndex].DataBoundItem;
            txtNomeProduto.Text = produtoSelecionado.Nome;
        }
    }
}
