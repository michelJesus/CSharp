using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFExercico2
{
    public partial class Form1 : Form
    {

        ContextoDeDados db = new ContextoDeDados();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Cliente novoCliente = new Cliente();
            novoCliente.Nome = txtCliente.Text;
            novoCliente.ValorCompra = double.Parse(txtValorCompra.Text);

            novoCliente.ValorParcela = novoCliente.DivisaoParcela();

            db.Clientes.Add(novoCliente);
            db.SaveChanges();

            LimpaCxTexto();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            List<Cliente> clientes = db.Clientes.ToList();
            gdView.DataSource = clientes;
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            clienteSelecionado.Nome = txtCliente.Text;
            clienteSelecionado.ValorCompra = double.Parse(txtValorCompra.Text);

            clienteSelecionado.ValorParcela = clienteSelecionado.DivisaoParcela();

            db.Entry(clienteSelecionado).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();

            LimpaCxTexto();
            
        }

        Cliente clienteSelecionado;

        private void gdView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            clienteSelecionado = (Cliente)gdView.Rows[e.RowIndex].DataBoundItem;

            txtCliente.Text = clienteSelecionado.Nome;
            txtValorCompra.Text = System.Convert.ToString(clienteSelecionado.ValorCompra);
        }

        public void LimpaCxTexto() {
            txtCliente.Text = "";
            txtValorCompra.Text = "";
            clienteSelecionado = null;

            List<Cliente> clientes = db.Clientes.ToList();
            gdView.DataSource = clientes;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            clienteSelecionado.Nome = txtCliente.Text;
            clienteSelecionado.ValorCompra = double.Parse(txtValorCompra.Text);

            db.Entry(clienteSelecionado).State = System.Data.Entity.EntityState.Deleted;
            db.SaveChanges();

            LimpaCxTexto();
        }
    }
}
