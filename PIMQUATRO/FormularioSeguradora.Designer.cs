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
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnpjDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seguradoraBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.dataGridViewSeguradora.Location = new System.Drawing.Point(3, -1);
            this.dataGridViewSeguradora.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewSeguradora.Name = "dataGridViewSeguradora";
            this.dataGridViewSeguradora.RowHeadersWidth = 51;
            this.dataGridViewSeguradora.RowTemplate.Height = 25;
            this.dataGridViewSeguradora.Size = new System.Drawing.Size(729, 568);
            this.dataGridViewSeguradora.TabIndex = 0;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.Width = 200;
            // 
            // cnpjDataGridViewTextBoxColumn
            // 
            this.cnpjDataGridViewTextBoxColumn.DataPropertyName = "Cnpj";
            this.cnpjDataGridViewTextBoxColumn.HeaderText = "Cnpj";
            this.cnpjDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cnpjDataGridViewTextBoxColumn.Name = "cnpjDataGridViewTextBoxColumn";
            this.cnpjDataGridViewTextBoxColumn.Width = 150;
            // 
            // seguradoraBindingSource
            // 
            this.seguradoraBindingSource.DataSource = typeof(PIMQUATRO.Modelo.Seguradora);
            // 
            // FormularioSeguradora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(973, 875);
            this.Controls.Add(this.dataGridViewSeguradora);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormularioSeguradora";
            this.Text = "FormularioSeguradora";
            this.Load += new System.EventHandler(this.FormularioSeguradora_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSeguradora)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seguradoraBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridViewSeguradora;
        private DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cnpjDataGridViewTextBoxColumn;
        private BindingSource seguradoraBindingSource;
    }
}