namespace PIMQUATRO
{
    partial class FormularioSeguradora
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
            this.components = new System.ComponentModel.Container();
            this.seguradoraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.seguradoraBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // seguradoraBindingSource
            // 
            this.seguradoraBindingSource.DataSource = typeof(PIMQUATRO.Modelo.Seguradora);
            // 
            // FormularioSeguradora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(778, 700);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "FormularioSeguradora";
            this.Text = "FormularioSeguradora";
            this.Load += new System.EventHandler(this.FormularioSeguradora_Load);
            ((System.ComponentModel.ISupportInitialize)(this.seguradoraBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private BindingSource seguradoraBindingSource;
    }
}