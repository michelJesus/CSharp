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
    }
}
