namespace PIMQUATRO
{
    partial class FormularioClientes
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
            this.Voltar = new System.Windows.Forms.Button();
            this.BtnCadastrarCliente = new System.Windows.Forms.Button();
            this.dataGridViewCliente = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // Voltar
            // 
            this.Voltar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Voltar.ForeColor = System.Drawing.Color.Snow;
            this.Voltar.Location = new System.Drawing.Point(625, 24);
            this.Voltar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Voltar.Name = "Voltar";
            this.Voltar.Size = new System.Drawing.Size(86, 47);
            this.Voltar.TabIndex = 5;
            this.Voltar.Text = "Voltar";
            this.Voltar.UseVisualStyleBackColor = false;
            this.Voltar.Click += new System.EventHandler(this.Voltar_Click);
            // 
            // BtnCadastrarCliente
            // 
            this.BtnCadastrarCliente.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BtnCadastrarCliente.ForeColor = System.Drawing.Color.Snow;
            this.BtnCadastrarCliente.Location = new System.Drawing.Point(625, 91);
            this.BtnCadastrarCliente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnCadastrarCliente.Name = "BtnCadastrarCliente";
            this.BtnCadastrarCliente.Size = new System.Drawing.Size(86, 47);
            this.BtnCadastrarCliente.TabIndex = 12;
            this.BtnCadastrarCliente.Text = "Cadastrar";
            this.BtnCadastrarCliente.UseVisualStyleBackColor = false;
            this.BtnCadastrarCliente.Click += new System.EventHandler(this.BtnCadastrarCliente_Click);
            // 
            // dataGridViewCliente
            // 
            this.dataGridViewCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCliente.Location = new System.Drawing.Point(1, 1);
            this.dataGridViewCliente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewCliente.Name = "dataGridViewCliente";
            this.dataGridViewCliente.RowHeadersWidth = 51;
            this.dataGridViewCliente.RowTemplate.Height = 25;
            this.dataGridViewCliente.Size = new System.Drawing.Size(618, 614);
            this.dataGridViewCliente.TabIndex = 13;
            // 
            // FormularioClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1198, 662);
            this.Controls.Add(this.dataGridViewCliente);
            this.Controls.Add(this.BtnCadastrarCliente);
            this.Controls.Add(this.Voltar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormularioClientes";
            this.Text = "clientes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Button Voltar;
        private Button BtnCadastrarCliente;
        private DataGridView dataGridViewCliente;
        private DataGridViewTextBoxColumn Nome;
    }
}