namespace PIMQUATRO
{
    partial class menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menu));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Ajuda = new System.Windows.Forms.Button();
            this.Clientes = new System.Windows.Forms.Button();
            this.Funcionarios = new System.Windows.Forms.Button();
            this.Seguradoras = new System.Windows.Forms.Button();
            this.Vendas = new System.Windows.Forms.Button();
            this.Duvidas = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(372, 110);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(93, 95);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // Ajuda
            // 
            this.Ajuda.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Ajuda.ForeColor = System.Drawing.Color.Snow;
            this.Ajuda.Location = new System.Drawing.Point(747, 426);
            this.Ajuda.Name = "Ajuda";
            this.Ajuda.Size = new System.Drawing.Size(75, 23);
            this.Ajuda.TabIndex = 5;
            this.Ajuda.Text = "Ajuda";
            this.Ajuda.UseVisualStyleBackColor = false;
            // 
            // Clientes
            // 
            this.Clientes.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Clientes.ForeColor = System.Drawing.Color.Snow;
            this.Clientes.Location = new System.Drawing.Point(372, 211);
            this.Clientes.Name = "Clientes";
            this.Clientes.Size = new System.Drawing.Size(93, 23);
            this.Clientes.TabIndex = 6;
            this.Clientes.Text = "Clientes";
            this.Clientes.UseVisualStyleBackColor = false;
            this.Clientes.Click += new System.EventHandler(this.Clientes_Click);
            // 
            // Funcionarios
            // 
            this.Funcionarios.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Funcionarios.ForeColor = System.Drawing.Color.Snow;
            this.Funcionarios.Location = new System.Drawing.Point(372, 240);
            this.Funcionarios.Name = "Funcionarios";
            this.Funcionarios.Size = new System.Drawing.Size(93, 23);
            this.Funcionarios.TabIndex = 7;
            this.Funcionarios.Text = "Funcionários";
            this.Funcionarios.UseVisualStyleBackColor = false;
            this.Funcionarios.Click += new System.EventHandler(this.Funcionarios_Click);
            // 
            // Seguradoras
            // 
            this.Seguradoras.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Seguradoras.ForeColor = System.Drawing.Color.Snow;
            this.Seguradoras.Location = new System.Drawing.Point(372, 269);
            this.Seguradoras.Name = "Seguradoras";
            this.Seguradoras.Size = new System.Drawing.Size(93, 23);
            this.Seguradoras.TabIndex = 8;
            this.Seguradoras.Text = "Seguradoras";
            this.Seguradoras.UseVisualStyleBackColor = false;
            this.Seguradoras.Click += new System.EventHandler(this.Seguradoras_Click);
            // 
            // Vendas
            // 
            this.Vendas.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Vendas.ForeColor = System.Drawing.Color.Snow;
            this.Vendas.Location = new System.Drawing.Point(372, 298);
            this.Vendas.Name = "Vendas";
            this.Vendas.Size = new System.Drawing.Size(93, 23);
            this.Vendas.TabIndex = 9;
            this.Vendas.Text = "Vendas";
            this.Vendas.UseVisualStyleBackColor = false;
            this.Vendas.Click += new System.EventHandler(this.Vendas_Click);
            // 
            // Duvidas
            // 
            this.Duvidas.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Duvidas.ForeColor = System.Drawing.Color.Snow;
            this.Duvidas.Location = new System.Drawing.Point(372, 327);
            this.Duvidas.Name = "Duvidas";
            this.Duvidas.Size = new System.Drawing.Size(93, 23);
            this.Duvidas.TabIndex = 10;
            this.Duvidas.Text = "Dúvidas";
            this.Duvidas.UseVisualStyleBackColor = false;
            this.Duvidas.Click += new System.EventHandler(this.Duvidas_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 110);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Duvidas);
            this.Controls.Add(this.Vendas);
            this.Controls.Add(this.Seguradoras);
            this.Controls.Add(this.Funcionarios);
            this.Controls.Add(this.Clientes);
            this.Controls.Add(this.Ajuda);
            this.Controls.Add(this.pictureBox2);
            this.Name = "menu";
            this.Text = "menu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBox2;
        private Button Ajuda;
        private Button Clientes;
        private Button Funcionarios;
        private Button Seguradoras;
        private Button Vendas;
        private Button Duvidas;
        private DataGridView dataGridView1;
    }
}