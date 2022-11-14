namespace PIMQUATRO
{
    partial class FormularioRelatorio
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
            this.txtCpfCliente = new System.Windows.Forms.TextBox();
            this.btnGerarApolice = new System.Windows.Forms.Button();
            this.btnGerarRelatorio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCpfCliente
            // 
            this.txtCpfCliente.Location = new System.Drawing.Point(248, 125);
            this.txtCpfCliente.Name = "txtCpfCliente";
            this.txtCpfCliente.Size = new System.Drawing.Size(200, 23);
            this.txtCpfCliente.TabIndex = 0;
            // 
            // btnGerarApolice
            // 
            this.btnGerarApolice.Location = new System.Drawing.Point(481, 105);
            this.btnGerarApolice.Name = "btnGerarApolice";
            this.btnGerarApolice.Size = new System.Drawing.Size(109, 61);
            this.btnGerarApolice.TabIndex = 1;
            this.btnGerarApolice.Text = "Gerar apólice";
            this.btnGerarApolice.UseVisualStyleBackColor = true;
            // 
            // btnGerarRelatorio
            // 
            this.btnGerarRelatorio.Location = new System.Drawing.Point(481, 194);
            this.btnGerarRelatorio.Name = "btnGerarRelatorio";
            this.btnGerarRelatorio.Size = new System.Drawing.Size(109, 65);
            this.btnGerarRelatorio.TabIndex = 2;
            this.btnGerarRelatorio.Text = "btnRelatorio";
            this.btnGerarRelatorio.UseVisualStyleBackColor = true;
            // 
            // FormularioRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGerarRelatorio);
            this.Controls.Add(this.btnGerarApolice);
            this.Controls.Add(this.txtCpfCliente);
            this.Name = "FormularioRelatorio";
            this.Text = "FormularioRelatorio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtCpfCliente;
        private Button btnGerarApolice;
        private Button btnGerarRelatorio;
    }
}