﻿namespace PIMQUATRO
{
    partial class FormularioFuncionario
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
            this.Voltar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewFuncionario = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFuncionario)).BeginInit();
            this.SuspendLayout();
            // 
            // Voltar
            // 
            this.Voltar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Voltar.ForeColor = System.Drawing.Color.Snow;
            this.Voltar.Location = new System.Drawing.Point(702, 13);
            this.Voltar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Voltar.Name = "Voltar";
            this.Voltar.Size = new System.Drawing.Size(86, 31);
            this.Voltar.TabIndex = 9;
            this.Voltar.Text = "Voltar";
            this.Voltar.UseVisualStyleBackColor = false;
            this.Voltar.Click += new System.EventHandler(this.Voltar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button1.ForeColor = System.Drawing.Color.Snow;
            this.button1.Location = new System.Drawing.Point(702, 52);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 31);
            this.button1.TabIndex = 10;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewFuncionario
            // 
            this.dataGridViewFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFuncionario.Location = new System.Drawing.Point(14, 13);
            this.dataGridViewFuncionario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewFuncionario.Name = "dataGridViewFuncionario";
            this.dataGridViewFuncionario.RowHeadersWidth = 51;
            this.dataGridViewFuncionario.RowTemplate.Height = 25;
            this.dataGridViewFuncionario.Size = new System.Drawing.Size(655, 660);
            this.dataGridViewFuncionario.TabIndex = 11;
            // 
            // FormularioFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 615);
            this.Controls.Add(this.dataGridViewFuncionario);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Voltar);
            this.Name = "FormularioFuncionario";
            this.Text = "Funcionario";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFuncionario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button Voltar;
        private Button button1;
        private DataGridView dataGridViewFuncionario;
    }
}