using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplicationAps16122014
{
    public partial class FormPrincipal : Form
    {

        ContextoDeDados db = new ContextoDeDados();
        public FormPrincipal()
        {
            InitializeComponent();
            CarregaLista();
        }

        private void btnCadastrarPessoa_Click(object sender, EventArgs e)
        {
            FormPessoa fP = new FormPessoa();
            fP.Show();
        }

        private void btnCadastrarConta_Click(object sender, EventArgs e)
        {
            FormConta fC = new FormConta();
            fC.Show();
        }

        private void btnCredito_Click(object sender, EventArgs e)
        {
            FormCredito fCred = new FormCredito();
            fCred.Show();
        }

        private void btnDebito_Click(object sender, EventArgs e)
        {
            FormDebito fDeb = new FormDebito();
            fDeb.Show();
        }

        private void CarregaLista() 
        {
            List<Conta> listaContas = db.Contas.ToList();
            dataGridViewInfo.DataSource = listaContas;
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            CarregaLista();
        }
    }
}
