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
            this.btnCadastrarBeneficiario = new System.Windows.Forms.Button();
            this.dataGridViewBeneficiario = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBeneficiario)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCadastrarBeneficiario
            // 
            this.btnCadastrarBeneficiario.BackColor = System.Drawing.Color.DarkBlue;
            this.btnCadastrarBeneficiario.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCadastrarBeneficiario.Location = new System.Drawing.Point(867, 737);
            this.btnCadastrarBeneficiario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCadastrarBeneficiario.Name = "btnCadastrarBeneficiario";
            this.btnCadastrarBeneficiario.Size = new System.Drawing.Size(104, 39);
            this.btnCadastrarBeneficiario.TabIndex = 1;
            this.btnCadastrarBeneficiario.Text = "Cadastrar";
            this.btnCadastrarBeneficiario.UseVisualStyleBackColor = false;
            this.btnCadastrarBeneficiario.Click += new System.EventHandler(this.btnCadastrarBeneficiario_Click);
            // 
            // dataGridViewBeneficiario
            // 
            this.dataGridViewBeneficiario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBeneficiario.Location = new System.Drawing.Point(14, 16);
            this.dataGridViewBeneficiario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewBeneficiario.Name = "dataGridViewBeneficiario";
            this.dataGridViewBeneficiario.RowHeadersWidth = 51;
            this.dataGridViewBeneficiario.RowTemplate.Height = 25;
            this.dataGridViewBeneficiario.Size = new System.Drawing.Size(701, 568);
            this.dataGridViewBeneficiario.TabIndex = 2;
            // 
            // FormularioBeneficiario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(973, 875);
            this.Controls.Add(this.dataGridViewBeneficiario);
            this.Controls.Add(this.btnCadastrarBeneficiario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormularioBeneficiario";
            this.Text = "FormularioBeneficiario";
            this.Load += new System.EventHandler(this.FormularioBeneficiario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBeneficiario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Button btnCadastrarBeneficiario;
        private DataGridView dataGridViewBeneficiario;
    }
}