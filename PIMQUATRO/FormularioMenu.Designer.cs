namespace PIMQUATRO
{
    partial class FormularioMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioMenu));
            this.btnSeguradoras = new System.Windows.Forms.Button();
            this.btnVendas = new System.Windows.Forms.Button();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.btnCadastroCliente = new System.Windows.Forms.Button();
            this.btnCadastroFuncionario = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnCadastrarBeneficiario = new System.Windows.Forms.Button();
            this.btnApolice = new System.Windows.Forms.Button();
            this.panelForms = new System.Windows.Forms.Panel();
            this.panelPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSeguradoras
            // 
            this.btnSeguradoras.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnSeguradoras.FlatAppearance.BorderSize = 0;
            this.btnSeguradoras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeguradoras.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSeguradoras.ForeColor = System.Drawing.Color.Snow;
            this.btnSeguradoras.Image = ((System.Drawing.Image)(resources.GetObject("btnSeguradoras.Image")));
            this.btnSeguradoras.Location = new System.Drawing.Point(0, 197);
            this.btnSeguradoras.Name = "btnSeguradoras";
            this.btnSeguradoras.Size = new System.Drawing.Size(217, 70);
            this.btnSeguradoras.TabIndex = 8;
            this.btnSeguradoras.Text = " Seguradoras";
            this.btnSeguradoras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSeguradoras.UseVisualStyleBackColor = false;
            this.btnSeguradoras.Click += new System.EventHandler(this.btnSeguradoras_Click);
            // 
            // btnVendas
            // 
            this.btnVendas.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnVendas.FlatAppearance.BorderSize = 0;
            this.btnVendas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVendas.ForeColor = System.Drawing.Color.Snow;
            this.btnVendas.Image = ((System.Drawing.Image)(resources.GetObject("btnVendas.Image")));
            this.btnVendas.Location = new System.Drawing.Point(-1, 266);
            this.btnVendas.Name = "btnVendas";
            this.btnVendas.Size = new System.Drawing.Size(218, 68);
            this.btnVendas.TabIndex = 9;
            this.btnVendas.Text = " Vendas";
            this.btnVendas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVendas.UseVisualStyleBackColor = false;
            this.btnVendas.Click += new System.EventHandler(this.btnVendas_Click);
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.BackColor = System.Drawing.Color.Cyan;
            this.panelPrincipal.Controls.Add(this.btnCadastroCliente);
            this.panelPrincipal.Controls.Add(this.btnCadastroFuncionario);
            this.panelPrincipal.Controls.Add(this.btnVendas);
            this.panelPrincipal.Controls.Add(this.btnFechar);
            this.panelPrincipal.Controls.Add(this.btnCadastrarBeneficiario);
            this.panelPrincipal.Controls.Add(this.btnApolice);
            this.panelPrincipal.Controls.Add(this.btnSeguradoras);
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelPrincipal.Location = new System.Drawing.Point(0, 0);
            this.panelPrincipal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(216, 647);
            this.panelPrincipal.TabIndex = 13;
            // 
            // btnCadastroCliente
            // 
            this.btnCadastroCliente.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnCadastroCliente.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCadastroCliente.FlatAppearance.BorderSize = 0;
            this.btnCadastroCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnCadastroCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnCadastroCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastroCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCadastroCliente.ForeColor = System.Drawing.Color.White;
            this.btnCadastroCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastroCliente.Image")));
            this.btnCadastroCliente.Location = new System.Drawing.Point(-1, 0);
            this.btnCadastroCliente.Name = "btnCadastroCliente";
            this.btnCadastroCliente.Size = new System.Drawing.Size(218, 70);
            this.btnCadastroCliente.TabIndex = 14;
            this.btnCadastroCliente.Text = "Cadastro de Clientes";
            this.btnCadastroCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastroCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCadastroCliente.UseVisualStyleBackColor = false;
            this.btnCadastroCliente.Click += new System.EventHandler(this.btnCadastroCliente_Click);
            // 
            // btnCadastroFuncionario
            // 
            this.btnCadastroFuncionario.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnCadastroFuncionario.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCadastroFuncionario.FlatAppearance.BorderSize = 0;
            this.btnCadastroFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastroFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCadastroFuncionario.ForeColor = System.Drawing.Color.White;
            this.btnCadastroFuncionario.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastroFuncionario.Image")));
            this.btnCadastroFuncionario.Location = new System.Drawing.Point(-1, 69);
            this.btnCadastroFuncionario.Name = "btnCadastroFuncionario";
            this.btnCadastroFuncionario.Size = new System.Drawing.Size(218, 65);
            this.btnCadastroFuncionario.TabIndex = 16;
            this.btnCadastroFuncionario.Text = "Cadastro de Funcionários";
            this.btnCadastroFuncionario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastroFuncionario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCadastroFuncionario.UseVisualStyleBackColor = false;
            this.btnCadastroFuncionario.Click += new System.EventHandler(this.btnCadastroFuncionario_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFechar.ForeColor = System.Drawing.Color.Snow;
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.Location = new System.Drawing.Point(-1, 399);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(219, 64);
            this.btnFechar.TabIndex = 13;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnCadastrarBeneficiario
            // 
            this.btnCadastrarBeneficiario.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnCadastrarBeneficiario.FlatAppearance.BorderSize = 0;
            this.btnCadastrarBeneficiario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarBeneficiario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCadastrarBeneficiario.ForeColor = System.Drawing.Color.Snow;
            this.btnCadastrarBeneficiario.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrarBeneficiario.Image")));
            this.btnCadastrarBeneficiario.Location = new System.Drawing.Point(-1, 134);
            this.btnCadastrarBeneficiario.Name = "btnCadastrarBeneficiario";
            this.btnCadastrarBeneficiario.Size = new System.Drawing.Size(218, 68);
            this.btnCadastrarBeneficiario.TabIndex = 12;
            this.btnCadastrarBeneficiario.Text = " Beneficiários";
            this.btnCadastrarBeneficiario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCadastrarBeneficiario.UseVisualStyleBackColor = false;
            this.btnCadastrarBeneficiario.Click += new System.EventHandler(this.btnBeneficiario_Click);
            // 
            // btnApolice
            // 
            this.btnApolice.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnApolice.FlatAppearance.BorderSize = 0;
            this.btnApolice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApolice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnApolice.ForeColor = System.Drawing.Color.Snow;
            this.btnApolice.Image = ((System.Drawing.Image)(resources.GetObject("btnApolice.Image")));
            this.btnApolice.Location = new System.Drawing.Point(0, 334);
            this.btnApolice.Name = "btnApolice";
            this.btnApolice.Size = new System.Drawing.Size(217, 68);
            this.btnApolice.TabIndex = 10;
            this.btnApolice.Text = "Apólice";
            this.btnApolice.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnApolice.UseVisualStyleBackColor = false;
            this.btnApolice.Click += new System.EventHandler(this.btnApolice_Click);
            // 
            // panelForms
            // 
            this.panelForms.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelForms.Location = new System.Drawing.Point(216, 0);
            this.panelForms.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelForms.Name = "panelForms";
            this.panelForms.Size = new System.Drawing.Size(1140, 462);
            this.panelForms.TabIndex = 14;
            // 
            // FormularioMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1356, 647);
            this.Controls.Add(this.panelForms);
            this.Controls.Add(this.panelPrincipal);
            this.Name = "FormularioMenu";
            this.Text = "menu";
            this.panelPrincipal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Button btnSeguradoras;
        private Button btnVendas;
        private Panel panelPrincipal;
        private Button btnFechar;
        private Button btnCadastroCliente;
        private Button btnCadastroFuncionario;
        private Panel panelForms;
        private Button btnCadastrarBeneficiario;
        private Button btnApolice;
    }
}