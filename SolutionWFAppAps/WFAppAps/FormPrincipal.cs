using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAppAps
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
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

        private void btnCadastrarCredito_Click(object sender, EventArgs e)
        {
            FormCredito fCre = new FormCredito();
            fCre.Show();
        }

        private void btnCadastrarDebito_Click(object sender, EventArgs e)
        {
            FormDebito fDeb = new FormDebito();
            fDeb.Show();
        }
    }
}
