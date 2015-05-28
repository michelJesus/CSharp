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
    public partial class Form1 : Form
    {
        ContextoDeDados db = new ContextoDeDados();
        Cliente clienteSelecionado;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Cliente c = new Cliente();
            c.Nome = txtNome.Text;
            db.Clientes.Add(c);
            db.SaveChanges();
            txtNome.Text = "";
            PopularGrid();
            
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            PopularGrid();
        }

        public void PopularGrid()
        {
            gdrView.DataSource = db.Clientes.ToList();
        }

        private void gdrView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            clienteSelecionado = (Cliente)gdrView.Rows[e.RowIndex].DataBoundItem;
            txtNome.Text = clienteSelecionado.Nome;

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            clienteSelecionado.Nome = txtNome.Text;
            db.Entry(clienteSelecionado).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            PopularGrid();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            db.Entry(clienteSelecionado).State = System.Data.Entity.EntityState.Deleted;
            db.SaveChanges();
            PopularGrid();
        }

        private void btnCadastroProduto_Click(object sender, EventArgs e)
        {
            FormCadastroProduto abreTelaCadastro = new FormCadastroProduto();
            abreTelaCadastro.Show();
        }
    }
}