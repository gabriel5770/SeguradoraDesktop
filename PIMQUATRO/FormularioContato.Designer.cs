namespace PIMQUATRO
{
    partial class FormularioContato
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
            this.btnExcluir = new System.Windows.Forms.Button();
            this.dataGridContato = new System.Windows.Forms.DataGridView();
            this.seguradoraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridContato)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seguradoraBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExcluir.ForeColor = System.Drawing.Color.White;
            this.btnExcluir.Location = new System.Drawing.Point(848, 634);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(108, 41);
            this.btnExcluir.TabIndex = 58;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // dataGridContato
            // 
            this.dataGridContato.AllowUserToAddRows = false;
            this.dataGridContato.AllowUserToDeleteRows = false;
            this.dataGridContato.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridContato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridContato.Location = new System.Drawing.Point(12, 2);
            this.dataGridContato.Name = "dataGridContato";
            this.dataGridContato.ReadOnly = true;
            this.dataGridContato.RowHeadersWidth = 51;
            this.dataGridContato.RowTemplate.Height = 29;
            this.dataGridContato.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridContato.Size = new System.Drawing.Size(952, 609);
            this.dataGridContato.TabIndex = 59;
            // 
            // seguradoraBindingSource
            // 
            this.seguradoraBindingSource.DataSource = typeof(PIMQUATRO.Modelo.Seguradora);
            // 
            // FormularioContato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 697);
            this.Controls.Add(this.dataGridContato);
            this.Controls.Add(this.btnExcluir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormularioContato";
            this.Text = "FormularioContato";
            this.Load += new System.EventHandler(this.FormularioContato_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridContato)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seguradoraBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Button btnExcluir;
        private DataGridView dataGridContato;
        private BindingSource seguradoraBindingSource;
    }
}