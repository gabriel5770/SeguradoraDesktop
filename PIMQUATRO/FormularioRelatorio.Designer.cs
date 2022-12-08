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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioRelatorio));
            this.btnGerarApolice = new System.Windows.Forms.Button();
            this.btnGerarContrato = new System.Windows.Forms.Button();
            this.pdfConfig1 = new Syncfusion.Pdf.PdfConfig();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.maskedTextDocumentoCpf = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGerarApolice
            // 
            this.btnGerarApolice.Location = new System.Drawing.Point(52, 575);
            this.btnGerarApolice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGerarApolice.Name = "btnGerarApolice";
            this.btnGerarApolice.Size = new System.Drawing.Size(125, 53);
            this.btnGerarApolice.TabIndex = 1;
            this.btnGerarApolice.Text = "Gerar apólice";
            this.btnGerarApolice.UseVisualStyleBackColor = true;
            this.btnGerarApolice.Click += new System.EventHandler(this.btnGerarApolice_Click);
            // 
            // btnGerarContrato
            // 
            this.btnGerarContrato.Location = new System.Drawing.Point(52, 638);
            this.btnGerarContrato.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGerarContrato.Name = "btnGerarContrato";
            this.btnGerarContrato.Size = new System.Drawing.Size(125, 52);
            this.btnGerarContrato.TabIndex = 3;
            this.btnGerarContrato.Text = "Gerar Contrato";
            this.btnGerarContrato.UseVisualStyleBackColor = true;
            this.btnGerarContrato.Click += new System.EventHandler(this.btnGerarContrato_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(5, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(961, 565);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(204, 589);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Digite o CPF:";
            // 
            // maskedTextDocumentoCpf
            // 
            this.maskedTextDocumentoCpf.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.maskedTextDocumentoCpf.Location = new System.Drawing.Point(204, 611);
            this.maskedTextDocumentoCpf.Margin = new System.Windows.Forms.Padding(2);
            this.maskedTextDocumentoCpf.Mask = "000.000.000-00";
            this.maskedTextDocumentoCpf.Name = "maskedTextDocumentoCpf";
            this.maskedTextDocumentoCpf.Size = new System.Drawing.Size(105, 34);
            this.maskedTextDocumentoCpf.TabIndex = 61;
            this.maskedTextDocumentoCpf.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.maskedTextDocumentoCpf.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextDocumentoCpf_MaskInputRejected);
            // 
            // FormularioRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 697);
            this.Controls.Add(this.maskedTextDocumentoCpf);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnGerarContrato);
            this.Controls.Add(this.btnGerarApolice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormularioRelatorio";
            this.Text = "FormularioRelatorio";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnGerarApolice;
        private Button btnGerarContrato;
        private Syncfusion.Pdf.PdfConfig pdfConfig1;
        private PictureBox pictureBox1;
        private Label label1;
        private MaskedTextBox maskedTextDocumentoCpf;
    }
}