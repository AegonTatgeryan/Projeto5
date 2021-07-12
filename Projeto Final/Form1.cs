using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Projeto_Final
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            if (Cliente.colunaTele != "")
            {
                cmbTele.Text = Cliente.colunaTele;
                txtNumero.Text = Cliente.coluna;
                txtNome.Text = Cliente.colunaNome;
                txtCNPJ.Text = Cliente.colunaCNPJ;
                txtEstacoes.Text = Cliente.colunaEstacoes;
                txtM2M.Text = Cliente.colunaM2M;
                txtTotal.Text = Cliente.colunaTotal;
                mskData.Text = Cliente.colunaReferencia;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidarForm())
            {
                SalvarClienteCsv();
                LimparForm();
                this.Close();
            }
                
        }
        private void LimparForm()
        {
            cmbTele.Text = "";
            txtNumero.Text = "";
            txtNome.Text = "";
            txtCNPJ.Text = "";
            txtEstacoes.Text = "";
            txtM2M.Text = "";
            txtTotal.Text = "";
            mskData.Text = "";
            cmbTele.Focus();
        }
        private void SalvarClienteCsv()
        {
            Cliente.colunaTele = cmbTele.Text;
            Cliente.coluna = txtNome.Text;
            Cliente.colunaCNPJ = txtCNPJ.Text;
            Cliente.colunaEstacoes = txtEstacoes.Text;
            Cliente.colunaM2M = txtM2M.Text;
            Cliente.colunaTotal = txtTotal.Text;
            Cliente.colunaReferencia = mskData.Text;


        }

        private bool ValidarForm()
        {
            var FormValido = true;
            if (txtNumero.Text == "")
            {
                MessageBox.Show("Informe o Numero da Entidade");
                txtNumero.Focus();
                FormValido = false;
            }
            else if (txtNome.Text == "")
            {
                MessageBox.Show("Informe o Nome/Razão Social");
                txtNome.Focus();
                FormValido = false;
            }
            else if (txtCNPJ.Text == "")
            {
                MessageBox.Show("Informe o CNPJ");
                txtCNPJ.Focus();
                FormValido = false;
            }
            else FormValido = true;

            return FormValido;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
