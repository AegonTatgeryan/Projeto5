
namespace Projeto_Final
{
    partial class FrmGrid
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colunaTele = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coluna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaCNPJ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaEstacoes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaM2M = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaReferencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnSalvarr = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DarkSalmon;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colunaTele,
            this.coluna,
            this.colunaNome,
            this.colunaCNPJ,
            this.colunaEstacoes,
            this.colunaM2M,
            this.colunaTotal,
            this.colunaReferencia});
            this.dataGridView1.Location = new System.Drawing.Point(12, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(842, 323);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // colunaTele
            // 
            this.colunaTele.HeaderText = "Serviço de Telecomuniações";
            this.colunaTele.Name = "colunaTele";
            this.colunaTele.ReadOnly = true;
            // 
            // coluna
            // 
            this.coluna.HeaderText = "Número da Entidade";
            this.coluna.Name = "coluna";
            this.coluna.ReadOnly = true;
            // 
            // colunaNome
            // 
            this.colunaNome.HeaderText = "Nome/Razão Social";
            this.colunaNome.Name = "colunaNome";
            this.colunaNome.ReadOnly = true;
            // 
            // colunaCNPJ
            // 
            this.colunaCNPJ.HeaderText = "CNPJ";
            this.colunaCNPJ.Name = "colunaCNPJ";
            this.colunaCNPJ.ReadOnly = true;
            // 
            // colunaEstacoes
            // 
            this.colunaEstacoes.HeaderText = "Estações Convencionais";
            this.colunaEstacoes.Name = "colunaEstacoes";
            this.colunaEstacoes.ReadOnly = true;
            // 
            // colunaM2M
            // 
            this.colunaM2M.HeaderText = "Estações M2M";
            this.colunaM2M.Name = "colunaM2M";
            this.colunaM2M.ReadOnly = true;
            // 
            // colunaTotal
            // 
            this.colunaTotal.HeaderText = "Total";
            this.colunaTotal.Name = "colunaTotal";
            this.colunaTotal.ReadOnly = true;
            // 
            // colunaReferencia
            // 
            this.colunaReferencia.HeaderText = "Referência";
            this.colunaReferencia.Name = "colunaReferencia";
            this.colunaReferencia.ReadOnly = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.ForeColor = System.Drawing.Color.White;
            this.btnAlterar.Location = new System.Drawing.Point(262, 416);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(139, 51);
            this.btnAlterar.TabIndex = 1;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.ForeColor = System.Drawing.Color.White;
            this.btnNovo.Location = new System.Drawing.Point(65, 416);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(139, 51);
            this.btnNovo.TabIndex = 2;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnSalvarr
            // 
            this.btnSalvarr.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnSalvarr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarr.ForeColor = System.Drawing.Color.White;
            this.btnSalvarr.Location = new System.Drawing.Point(679, 416);
            this.btnSalvarr.Name = "btnSalvarr";
            this.btnSalvarr.Size = new System.Drawing.Size(139, 51);
            this.btnSalvarr.TabIndex = 3;
            this.btnSalvarr.Text = "Salvar";
            this.btnSalvarr.UseVisualStyleBackColor = false;
            this.btnSalvarr.Click += new System.EventHandler(this.btnSalvarr_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.Color.White;
            this.btnExcluir.Location = new System.Drawing.Point(475, 416);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(139, 51);
            this.btnExcluir.TabIndex = 4;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // FrmGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(865, 503);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnSalvarr);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmGrid";
            this.Text = "Grid";
            this.Load += new System.EventHandler(this.FrmGrid_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaTele;
        private System.Windows.Forms.DataGridViewTextBoxColumn coluna;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaCNPJ;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaEstacoes;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaM2M;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaReferencia;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnSalvarr;
        private System.Windows.Forms.Button btnExcluir;
    }
}