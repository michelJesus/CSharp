using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_Exercicio_02_00
{
    public partial class Form1 : Form
    {

        List<Cliente> clientes = new List<Cliente>();
        Cliente clienteSelecionado;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            Cliente novoCliente = new Cliente();
            novoCliente.Nome = txtNome.Text;

            Compra novaCompra = new Compra();
            novaCompra.Valor = double.Parse(txtCompra.Text);

            novoCliente.Compra = novaCompra;

            clientes.Add(novoCliente);
            dgvDados.DataSource = clientes;
            LimpaCaixaDeTexto();


        }

        private void LimpaCaixaDeTexto () {
            txtCompra.Text = "";
            txtNome.Text = "";
            txtParcela.Text = "";
            clienteSelecionado = null;
        }


        private void dgvDados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Cliente cliente = (Cliente)dgvDados.Rows[e.RowIndex].DataBoundItem;

            txtCompra.Text = cliente.Compra.Valor.ToString();
            txtNome.Text = cliente.Nome;
            txtParcela.Text = cliente.Compra.getValorDaParcela().ToString();

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimpaCaixaDeTexto();
        }
    }
}
