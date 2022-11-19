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
            this.btnExcluirCliente = new System.Windows.Forms.Button();
            this.btnEditarCliente = new System.Windows.Forms.Button();
            this.btnCadastrarCliente = new System.Windows.Forms.Button();
            this.txtCnpjSeguradora = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeSeguradora = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnExcluirCliente
            // 
            this.btnExcluirCliente.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnExcluirCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExcluirCliente.ForeColor = System.Drawing.Color.White;
            this.btnExcluirCliente.Location = new System.Drawing.Point(468, 423);
            this.btnExcluirCliente.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnExcluirCliente.Name = "btnExcluirCliente";
            this.btnExcluirCliente.Size = new System.Drawing.Size(86, 33);
            this.btnExcluirCliente.TabIndex = 91;
            this.btnExcluirCliente.Text = "Excluir";
            this.btnExcluirCliente.UseVisualStyleBackColor = false;
            this.btnExcluirCliente.Click += new System.EventHandler(this.btnExcluirCliente_Click);
            // 
            // btnEditarCliente
            // 
            this.btnEditarCliente.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnEditarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEditarCliente.ForeColor = System.Drawing.Color.White;
            this.btnEditarCliente.Location = new System.Drawing.Point(571, 423);
            this.btnEditarCliente.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnEditarCliente.Name = "btnEditarCliente";
            this.btnEditarCliente.Size = new System.Drawing.Size(86, 33);
            this.btnEditarCliente.TabIndex = 90;
            this.btnEditarCliente.Text = "Editar";
            this.btnEditarCliente.UseVisualStyleBackColor = false;
            this.btnEditarCliente.Click += new System.EventHandler(this.btnEditarCliente_Click);
            // 
            // btnCadastrarCliente
            // 
            this.btnCadastrarCliente.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnCadastrarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCadastrarCliente.ForeColor = System.Drawing.Color.White;
            this.btnCadastrarCliente.Location = new System.Drawing.Point(678, 423);
            this.btnCadastrarCliente.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnCadastrarCliente.Name = "btnCadastrarCliente";
            this.btnCadastrarCliente.Size = new System.Drawing.Size(86, 33);
            this.btnCadastrarCliente.TabIndex = 82;
            this.btnCadastrarCliente.Text = "Cadastrar";
            this.btnCadastrarCliente.UseVisualStyleBackColor = false;
            this.btnCadastrarCliente.Click += new System.EventHandler(this.btnCadastrarCliente_Click);
            // 
            // txtCnpjSeguradora
            // 
            this.txtCnpjSeguradora.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCnpjSeguradora.Location = new System.Drawing.Point(345, 153);
            this.txtCnpjSeguradora.Margin = new System.Windows.Forms.Padding(2);
            this.txtCnpjSeguradora.Mask = "00.000.000/0000-00";
            this.txtCnpjSeguradora.Name = "txtCnpjSeguradora";
            this.txtCnpjSeguradora.Size = new System.Drawing.Size(78, 21);
            this.txtCnpjSeguradora.TabIndex = 95;
            this.txtCnpjSeguradora.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(363, 136);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 15);
            this.label2.TabIndex = 94;
            this.label2.Text = "Cnpj:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(282, 78);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 93;
            this.label1.Text = "Nome:";
            // 
            // txtNomeSeguradora
            // 
            this.txtNomeSeguradora.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNomeSeguradora.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNomeSeguradora.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtNomeSeguradora.Location = new System.Drawing.Point(282, 97);
            this.txtNomeSeguradora.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtNomeSeguradora.Name = "txtNomeSeguradora";
            this.txtNomeSeguradora.Size = new System.Drawing.Size(230, 16);
            this.txtNomeSeguradora.TabIndex = 92;
            // 
            // FormularioCadastroSeguradora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(778, 493);
            this.Controls.Add(this.txtCnpjSeguradora);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNomeSeguradora);
            this.Controls.Add(this.btnExcluirCliente);
            this.Controls.Add(this.btnEditarCliente);
            this.Controls.Add(this.btnCadastrarCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "FormularioCadastroSeguradora";
            this.Text = "Seguradoras";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnExcluirCliente;
        private Button btnEditarCliente;
        private Button btnCadastrarCliente;
        private MaskedTextBox txtCnpjSeguradora;
        private Label label2;
        private Label label1;
        private TextBox txtNomeSeguradora;
    }
}