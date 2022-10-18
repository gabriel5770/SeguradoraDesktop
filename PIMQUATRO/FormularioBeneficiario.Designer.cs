namespace PIMQUATRO
{
    partial class FormularioBeneficiario
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
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnCadastrarBeneficiario = new System.Windows.Forms.Button();
            this.dataGridViewBeneficiario = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBeneficiario)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(664, 46);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(91, 29);
            this.btnVoltar.TabIndex = 0;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnCadastrarBeneficiario
            // 
            this.btnCadastrarBeneficiario.Location = new System.Drawing.Point(664, 108);
            this.btnCadastrarBeneficiario.Name = "btnCadastrarBeneficiario";
            this.btnCadastrarBeneficiario.Size = new System.Drawing.Size(91, 29);
            this.btnCadastrarBeneficiario.TabIndex = 1;
            this.btnCadastrarBeneficiario.Text = "Cadastrar";
            this.btnCadastrarBeneficiario.UseVisualStyleBackColor = true;
            this.btnCadastrarBeneficiario.Click += new System.EventHandler(this.btnCadastrarBeneficiario_Click);
            // 
            // dataGridViewBeneficiario
            // 
            this.dataGridViewBeneficiario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBeneficiario.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewBeneficiario.Name = "dataGridViewBeneficiario";
            this.dataGridViewBeneficiario.RowTemplate.Height = 25;
            this.dataGridViewBeneficiario.Size = new System.Drawing.Size(613, 426);
            this.dataGridViewBeneficiario.TabIndex = 2;
            // 
            // FormularioBeneficiario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewBeneficiario);
            this.Controls.Add(this.btnCadastrarBeneficiario);
            this.Controls.Add(this.btnVoltar);
            this.Name = "FormularioBeneficiario";
            this.Text = "FormularioBeneficiario";
            this.Load += new System.EventHandler(this.FormularioBeneficiario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBeneficiario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnVoltar;
        private Button btnCadastrarBeneficiario;
        private DataGridView dataGridViewBeneficiario;
    }
}