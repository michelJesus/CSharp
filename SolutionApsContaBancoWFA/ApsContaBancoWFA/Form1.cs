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
    public partial class Form1 : Form
    {

        ContextoDeDados db = new ContextoDeDados();
        
    
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            Pessoa novaPessoa = new Pessoa();
            novaPessoa.DataDeCadastro = DateTime.Parse(txtDataDeCadastro.Text);
            novaPessoa.Nome = txtNome.Text;
            novaPessoa.Endereco = txtEndereco.Text;
            novaPessoa.Cpf = int.Parse(txtCpf.Text);

            db.CadastroDePessoas.Add(novaPessoa);
            
            db.SaveChanges();
            
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            List<Pessoa> cadastroDePessoas = db.CadastroDePessoas.ToList();
            dataGridViewPessoa.DataSource = cadastroDePessoas;
        }

        Pessoa pessoaSelecionada;

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            pessoaSelecionada.DataDeCadastro = DateTime.Parse(txtDataDeCadastro.Text);
            pessoaSelecionada.Nome = txtNome.Text;
            pessoaSelecionada.Endereco = txtEndereco.Text;
            pessoaSelecionada.Cpf = int.Parse(txtCpf.Text);

            db.Entry(pessoaSelecionada).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            pessoaSelecionada.DataDeCadastro = DateTime.Parse(txtDataDeCadastro.Text);
            pessoaSelecionada.Nome = txtNome.Text;
            pessoaSelecionada.Endereco = txtEndereco.Text;
            pessoaSelecionada.Cpf = int.Parse(txtCpf.Text);

            db.Entry(pessoaSelecionada).State = System.Data.Entity.EntityState.Deleted;
            db.SaveChanges();
        }

        private void dataGridViewPessoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pessoaSelecionada = (Pessoa)dataGridViewPessoa.Rows[e.RowIndex].DataBoundItem;

            txtDataDeCadastro.Text = System.Convert.ToString(pessoaSelecionada.DataDeCadastro);
            txtNome.Text = pessoaSelecionada.Nome;
            txtEndereco.Text = pessoaSelecionada.Endereco;
            txtCpf.Text = System.Convert.ToString(pessoaSelecionada.Cpf);
        }

        public void LimpaTexto() { 
            txtDataDeCadastro.Text = "";
            txtNome.Text = "";
            txtEndereco.Text = "";
            txtCpf.Text = "";
            pessoaSelecionada = null;
        }


    }
}
