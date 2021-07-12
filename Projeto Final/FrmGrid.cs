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
    public partial class FrmGrid : Form
    {
      
        public FrmGrid()
        {
            
            InitializeComponent();
        }


        private void FrmGrid_Load(object sender, EventArgs e)
        {
            using (StreamReader csv = new StreamReader(@"c:\Dados\Estacoes_SMGS.csv"))
            {
                string linha;
                string[] campo;

                while ((linha = csv.ReadLine()) != null)
                {
                    campo = linha.Split(';');
                    dataGridView1.Rows.Add(campo);

                }
            }
        }
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.ShowDialog();

            dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["colunaTele"].Value = Cliente.colunaTele;
            dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["coluna"].Value = Cliente.coluna;
            dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["colunaNome"].Value = Cliente.colunaNome;
            dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["colunaCNPJ"].Value = Cliente.colunaCNPJ;
            dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["colunaEstacoes"].Value = Cliente.colunaEstacoes;
            dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["colunaM2M"].Value = Cliente.colunaM2M;
            dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["colunaTotal"].Value = Cliente.colunaTotal;
            dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["colunaReferencia"].Value = Cliente.colunaReferencia;
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            Cliente.colunaTele = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["colunaTele"].Value.ToString();
            Cliente.coluna = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["coluna"].Value.ToString();
            Cliente.colunaNome = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["colunaNome"].Value.ToString();
            Cliente.colunaCNPJ = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["colunaCNPJ"].Value.ToString();
            Cliente.colunaEstacoes = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["colunaEstacoes"].Value.ToString();
            Cliente.colunaM2M = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["colunaM2M"].Value.ToString();
            Cliente.colunaTotal = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["colunaTotal"].Value.ToString();
            Cliente.colunaReferencia = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["colunaReferencia"].Value.ToString();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Cliente.colunaTele = "";
            Form1 frm = new Form1();
            frm.ShowDialog();

            dataGridView1.Rows.Add(Cliente.colunaTele, Cliente.coluna, Cliente.colunaNome, Cliente.colunaCNPJ,
                Cliente.colunaEstacoes, Cliente.colunaM2M, Cliente.colunaTotal, Cliente.colunaReferencia);
        }

        private void btnSalvarr_Click(object sender, EventArgs e)
        {
            using (StreamWriter csv = new StreamWriter(@"c:\Dados\Estacoes_SMGS.csv"))
            {
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    var linha = dataGridView1.Rows[i].Cells["colunaTele"].Value + ";" +
                dataGridView1.Rows[i].Cells["coluna"].Value + ";" +
                dataGridView1.Rows[i].Cells["colunaNome"].Value + ";" +
                dataGridView1.Rows[i].Cells["colunaCNPJ"].Value + ";" +
                dataGridView1.Rows[i].Cells["colunaEstacoes"].Value + ";" +
                dataGridView1.Rows[i].Cells["colunaM2M"].Value + ";" +
                dataGridView1.Rows[i].Cells["colunaTotal"].Value + ";" +
                dataGridView1.Rows[i].Cells["colunaReferencia"].Value;

                    csv.WriteLine(linha);
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount == 0)
                MessageBox.Show("Não há linhas na grade");
            else if (MessageBox.Show("Deseja excluir?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            FiltrarGrade();
        }

        private void FiltrarGrade()
        {
        }
    }
}
