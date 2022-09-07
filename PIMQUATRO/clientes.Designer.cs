namespace PIMQUATRO
{
    partial class clientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(clientes));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Voltar = new System.Windows.Forms.Button();
            this.Ajuda = new System.Windows.Forms.Button();
            this.BtnCadastrarCliente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(14, 16);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(106, 127);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // Voltar
            // 
            this.Voltar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Voltar.ForeColor = System.Drawing.Color.Snow;
            this.Voltar.Location = new System.Drawing.Point(854, 16);
            this.Voltar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Voltar.Name = "Voltar";
            this.Voltar.Size = new System.Drawing.Size(86, 31);
            this.Voltar.TabIndex = 5;
            this.Voltar.Text = "Voltar";
            this.Voltar.UseVisualStyleBackColor = false;
            this.Voltar.Click += new System.EventHandler(this.Voltar_Click);
            // 
            // Ajuda
            // 
            this.Ajuda.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Ajuda.ForeColor = System.Drawing.Color.Snow;
            this.Ajuda.Location = new System.Drawing.Point(854, 568);
            this.Ajuda.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Ajuda.Name = "Ajuda";
            this.Ajuda.Size = new System.Drawing.Size(86, 31);
            this.Ajuda.TabIndex = 6;
            this.Ajuda.Text = "Ajuda";
            this.Ajuda.UseVisualStyleBackColor = false;
            // 
            // BtnCadastrarCliente
            // 
            this.BtnCadastrarCliente.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BtnCadastrarCliente.ForeColor = System.Drawing.Color.Snow;
            this.BtnCadastrarCliente.Location = new System.Drawing.Point(854, 471);
            this.BtnCadastrarCliente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnCadastrarCliente.Name = "BtnCadastrarCliente";
            this.BtnCadastrarCliente.Size = new System.Drawing.Size(86, 31);
            this.BtnCadastrarCliente.TabIndex = 12;
            this.BtnCadastrarCliente.Text = "Cadastrar";
            this.BtnCadastrarCliente.UseVisualStyleBackColor = false;
            this.BtnCadastrarCliente.Click += new System.EventHandler(this.BtnCadastrarCliente_Click);
            // 
            // clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 615);
            this.Controls.Add(this.BtnCadastrarCliente);
            this.Controls.Add(this.Ajuda);
            this.Controls.Add(this.Voltar);
            this.Controls.Add(this.pictureBox2);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "clientes";
            this.Text = "clientes";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBox2;
        private Button Voltar;
        private Button Ajuda;
        private Button BtnCadastrarCliente;
    }
}