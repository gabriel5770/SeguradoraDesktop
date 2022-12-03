namespace PIMQUATRO
{
    partial class FormularioVendas
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.maskedNascimento = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.maskedTelefone = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.maskedCpf = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridVendas = new System.Windows.Forms.DataGridView();
            this.cmbSexoVendas = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmdSeguro = new System.Windows.Forms.ComboBox();
            this.btnCadastrarVendas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVendas)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(36, 79);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(311, 27);
            this.txtNome.TabIndex = 0;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(36, 176);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(311, 27);
            this.txtEmail.TabIndex = 1;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(36, 56);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(50, 20);
            this.lbl1.TabIndex = 2;
            this.lbl1.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Email";
            // 
            // maskedNascimento
            // 
            this.maskedNascimento.Location = new System.Drawing.Point(425, 79);
            this.maskedNascimento.Mask = "00/00/0000";
            this.maskedNascimento.Name = "maskedNascimento";
            this.maskedNascimento.Size = new System.Drawing.Size(125, 27);
            this.maskedNascimento.TabIndex = 4;
            this.maskedNascimento.ValidatingType = typeof(System.DateTime);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(425, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Date Nascimento";
            // 
            // maskedTelefone
            // 
            this.maskedTelefone.Location = new System.Drawing.Point(794, 79);
            this.maskedTelefone.Mask = "(00)-000000000";
            this.maskedTelefone.Name = "maskedTelefone";
            this.maskedTelefone.Size = new System.Drawing.Size(125, 27);
            this.maskedTelefone.TabIndex = 6;
            this.maskedTelefone.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(794, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Telefone";
            // 
            // maskedCpf
            // 
            this.maskedCpf.Location = new System.Drawing.Point(615, 79);
            this.maskedCpf.Mask = "000.000.000-00";
            this.maskedCpf.Name = "maskedCpf";
            this.maskedCpf.Size = new System.Drawing.Size(125, 27);
            this.maskedCpf.TabIndex = 8;
            this.maskedCpf.ValidatingType = typeof(System.DateTime);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(615, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "CPF";
            // 
            // dataGridVendas
            // 
            this.dataGridVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridVendas.Location = new System.Drawing.Point(36, 211);
            this.dataGridVendas.Name = "dataGridVendas";
            this.dataGridVendas.RowHeadersWidth = 51;
            this.dataGridVendas.RowTemplate.Height = 29;
            this.dataGridVendas.Size = new System.Drawing.Size(883, 344);
            this.dataGridVendas.TabIndex = 13;
            // 
            // cmbSexoVendas
            // 
            this.cmbSexoVendas.FormattingEnabled = true;
            this.cmbSexoVendas.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.cmbSexoVendas.Location = new System.Drawing.Point(425, 176);
            this.cmbSexoVendas.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.cmbSexoVendas.Name = "cmbSexoVendas";
            this.cmbSexoVendas.Size = new System.Drawing.Size(146, 28);
            this.cmbSexoVendas.TabIndex = 52;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(425, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 20);
            this.label5.TabIndex = 53;
            this.label5.Text = "Sexo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(699, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 20);
            this.label6.TabIndex = 54;
            this.label6.Text = "Seguro";
            // 
            // cmdSeguro
            // 
            this.cmdSeguro.FormattingEnabled = true;
            this.cmdSeguro.Items.AddRange(new object[] {
            "Invalidez",
            "Morte Acidental",
            "Doença Hereditaria"});
            this.cmdSeguro.Location = new System.Drawing.Point(699, 175);
            this.cmdSeguro.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.cmdSeguro.Name = "cmdSeguro";
            this.cmdSeguro.Size = new System.Drawing.Size(191, 28);
            this.cmdSeguro.TabIndex = 55;
            // 
            // btnCadastrarVendas
            // 
            this.btnCadastrarVendas.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnCadastrarVendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCadastrarVendas.ForeColor = System.Drawing.Color.White;
            this.btnCadastrarVendas.Location = new System.Drawing.Point(809, 562);
            this.btnCadastrarVendas.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnCadastrarVendas.Name = "btnCadastrarVendas";
            this.btnCadastrarVendas.Size = new System.Drawing.Size(108, 41);
            this.btnCadastrarVendas.TabIndex = 56;
            this.btnCadastrarVendas.Text = "Cadastrar";
            this.btnCadastrarVendas.UseVisualStyleBackColor = false;
            this.btnCadastrarVendas.Click += new System.EventHandler(this.btnCadastrarVendas_Click);
            // 
            // FormularioVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(973, 616);
            this.Controls.Add(this.btnCadastrarVendas);
            this.Controls.Add(this.cmdSeguro);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbSexoVendas);
            this.Controls.Add(this.dataGridVendas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.maskedCpf);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.maskedTelefone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.maskedNascimento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormularioVendas";
            this.Text = "Vendas";
            this.Load += new System.EventHandler(this.FormularioVendas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVendas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtNome;
        private TextBox txtEmail;
        private Label lbl1;
        private Label label1;
        private MaskedTextBox maskedNascimento;
        private Label label2;
        private MaskedTextBox maskedTelefone;
        private Label label3;
        private MaskedTextBox maskedCpf;
        private Label label4;
        private DataGridView dataGridVendas;
        private ComboBox cmbSexoVendas;
        private Label label5;
        private Label label6;
        private ComboBox cmdSeguro;
        private Button btnCadastrarVendas;
    }
}