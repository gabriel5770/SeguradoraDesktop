namespace PIMQUATRO
{
    partial class FormularioSeguradora
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
            this.components = new System.ComponentModel.Container();
            this.dataGridViewSeguradora = new System.Windows.Forms.DataGridView();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnCadastrarSeguradora = new System.Windows.Forms.Button();
            this.seguradoraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnpjDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSeguradora)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seguradoraBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSeguradora
            // 
            this.dataGridViewSeguradora.AutoGenerateColumns = false;
            this.dataGridViewSeguradora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSeguradora.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeDataGridViewTextBoxColumn,
            this.cnpjDataGridViewTextBoxColumn});
            this.dataGridViewSeguradora.DataSource = this.seguradoraBindingSource;
            this.dataGridViewSeguradora.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewSeguradora.Name = "dataGridViewSeguradora";
            this.dataGridViewSeguradora.RowTemplate.Height = 25;
            this.dataGridViewSeguradora.Size = new System.Drawing.Size(638, 426);
            this.dataGridViewSeguradora.TabIndex = 0;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(699, 68);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 1;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnCadastrarSeguradora
            // 
            this.btnCadastrarSeguradora.Location = new System.Drawing.Point(699, 109);
            this.btnCadastrarSeguradora.Name = "btnCadastrarSeguradora";
            this.btnCadastrarSeguradora.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrarSeguradora.TabIndex = 2;
            this.btnCadastrarSeguradora.Text = "Cadastrar";
            this.btnCadastrarSeguradora.UseVisualStyleBackColor = true;
            this.btnCadastrarSeguradora.Click += new System.EventHandler(this.btnCadastrarSeguradora_Click);
            // 
            // seguradoraBindingSource
            // 
            this.seguradoraBindingSource.DataSource = typeof(PIMQUATRO.Modelo.Seguradora);
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.Width = 200;
            // 
            // cnpjDataGridViewTextBoxColumn
            // 
            this.cnpjDataGridViewTextBoxColumn.DataPropertyName = "Cnpj";
            this.cnpjDataGridViewTextBoxColumn.HeaderText = "Cnpj";
            this.cnpjDataGridViewTextBoxColumn.Name = "cnpjDataGridViewTextBoxColumn";
            this.cnpjDataGridViewTextBoxColumn.Width = 150;
            // 
            // FormularioSeguradora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCadastrarSeguradora);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.dataGridViewSeguradora);
            this.Name = "FormularioSeguradora";
            this.Text = "FormularioSeguradora";
            this.Load += new System.EventHandler(this.FormularioSeguradora_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSeguradora)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seguradoraBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridViewSeguradora;
        private Button btnVoltar;
        private Button btnCadastrarSeguradora;
        private DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cnpjDataGridViewTextBoxColumn;
        private BindingSource seguradoraBindingSource;
    }
}