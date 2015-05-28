using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplicationExemploGrud
{
    public partial class Form1 : Form
    {
        ContextoDeDados ctx = new ContextoDeDados();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            // Cria o novo cliente e atribui os valores da tela
            Cliente novoCliente = new Cliente();
            novoCliente.Nome = txtNome.Text;
            novoCliente.Endereco = txtEndereco.Text;

            // Salva o cliente no banco de dados
            ctx.Clientes.Add(novoCliente);
            ctx.SaveChanges();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            List<Cliente> clientes = ctx.Clientes.ToList();
            dgvDados.DataSource = clientes;
        }

        Cliente clienteSelecionado;

        private void dgvDados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // carregar o clinete selecionado da grid de dados
            // baseado na linha que foi clicada pelo usuário
            clienteSelecionado = (Cliente) dgvDados.Rows[e.RowIndex].DataBoundItem;
            
            // popula a tela com os dados do cliente
            txtNome.Text = clienteSelecionado.Nome;
            txtEndereco.Text = clienteSelecionado.Endereco;
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            clienteSelecionado.Nome = txtNome.Text;
            clienteSelecionado.Endereco = txtEndereco.Text;
            ctx.Entry(clienteSelecionado).State = System.Data.Entity.EntityState.Modified;
            ctx.SaveChanges();
            LimparCaixaDeTexto();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            ctx.Entry(clienteSelecionado).State = System.Data.Entity.EntityState.Deleted;
            ctx.SaveChanges();
        }

        public void LimparCaixaDeTexto() 
        {
            txtNome.Text = "";
            txtEndereco.Text = "";
            clienteSelecionado = null;
        } 

    }
}
