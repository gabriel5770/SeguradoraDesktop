namespace PIMQUATRO
{
    partial class FormularioCadastroSeguradora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioCadastroSeguradora));
            this.btnCadastrarCliente = new System.Windows.Forms.Button();
            this.txtCnpjSeguradora = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeSeguradora = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCadastrarCliente
            // 
            this.btnCadastrarCliente.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnCadastrarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCadastrarCliente.ForeColor = System.Drawing.Color.White;
            this.btnCadastrarCliente.Location = new System.Drawing.Point(260, 611);
            this.btnCadastrarCliente.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnCadastrarCliente.Name = "btnCadastrarCliente";
            this.btnCadastrarCliente.Size = new System.Drawing.Size(108, 41);
            this.btnCadastrarCliente.TabIndex = 82;
            this.btnCadastrarCliente.Text = "Cadastrar";
            this.btnCadastrarCliente.UseVisualStyleBackColor = false;
            this.btnCadastrarCliente.Click += new System.EventHandler(this.btnCadastrarCliente_Click);
            // 
            // txtCnpjSeguradora
            // 
            this.txtCnpjSeguradora.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCnpjSeguradora.Location = new System.Drawing.Point(56, 622);
            this.txtCnpjSeguradora.Margin = new System.Windows.Forms.Padding(2);
            this.txtCnpjSeguradora.Mask = "00.000.000/0000-00";
            this.txtCnpjSeguradora.Name = "txtCnpjSeguradora";
            this.txtCnpjSeguradora.Size = new System.Drawing.Size(170, 30);
            this.txtCnpjSeguradora.TabIndex = 95;
            this.txtCnpjSeguradora.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(78, 600);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 94;
            this.label2.Text = "Cnpj:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(56, 536);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 93;
            this.label1.Text = "Nome:";
            // 
            // txtNomeSeguradora
            // 
            this.txtNomeSeguradora.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNomeSeguradora.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNomeSeguradora.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtNomeSeguradora.Location = new System.Drawing.Point(56, 560);
            this.txtNomeSeguradora.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtNomeSeguradora.MaxLength = 50;
            this.txtNomeSeguradora.Name = "txtNomeSeguradora";
            this.txtNomeSeguradora.Size = new System.Drawing.Size(312, 27);
            this.txtNomeSeguradora.TabIndex = 92;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, -1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(970, 516);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 96;
            this.pictureBox1.TabStop = false;
            // 
            // FormularioCadastroSeguradora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(968, 698);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtCnpjSeguradora);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNomeSeguradora);
            this.Controls.Add(this.btnCadastrarCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Name = "FormularioCadastroSeguradora";
            this.Text = "Seguradoras";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnCadastrarCliente;
        private MaskedTextBox txtCnpjSeguradora;
        private Label label2;
        private Label label1;
        private TextBox txtNomeSeguradora;
        private PictureBox pictureBox1;
    }
}