using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplicationAPS2
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnCadastrarPessoa_Click(object sender, EventArgs e)
        {
            FormPessoa fPessoa = new FormPessoa();
            fPessoa.Show();
        }

        private void btnCadastrarConta_Click(object sender, EventArgs e)
        {
            FormConta fConta = new FormConta();
            fConta.Show();
        }

        private void btnCadastrarCredito_Click(object sender, EventArgs e)
        {
            FormCredito fCredito = new FormCredito();
            fCredito.Show();
        }

        private void btnCadastrarDebito_Click(object sender, EventArgs e)
        {
            FormDebito fDebito = new FormDebito();
            fDebito.Show();
        }
    }
}
