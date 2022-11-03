namespace PIMQUATRO
{
    partial class FormularioCadastroFuncionarios
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
            this.btnCadastrarFuncionario = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.textCidadeFunc = new System.Windows.Forms.TextBox();
            this.maskedTextCepFunc = new System.Windows.Forms.MaskedTextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.dateTimePickerFunc = new System.Windows.Forms.DateTimePicker();
            this.maskedTextFuncCpf = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextRgFunc = new System.Windows.Forms.MaskedTextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.textSenhaFunc = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cmdEstadoCivilFunc = new System.Windows.Forms.ComboBox();
            this.cmbEstadoFunc = new System.Windows.Forms.ComboBox();
            this.cmdSexoFunc = new System.Windows.Forms.ComboBox();
            this.cmbCargoFunc = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textEmailFunc = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textTelefoneFunc = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBairroFunc = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textMunicipioFunc = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textNumeroResidenciaFunc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textEnderecoFunc = new System.Windows.Forms.TextBox();
            this.textNomeFunc = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnExcluirFuncionario = new System.Windows.Forms.Button();
            this.btnEditarFuncionario = new System.Windows.Forms.Button();
            this.btnExibirFuncionario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCadastrarFuncionario
            // 
            this.btnCadastrarFuncionario.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnCadastrarFuncionario.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCadastrarFuncionario.Location = new System.Drawing.Point(830, 539);
            this.btnCadastrarFuncionario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCadastrarFuncionario.Name = "btnCadastrarFuncionario";
            this.btnCadastrarFuncionario.Size = new System.Drawing.Size(97, 41);
            this.btnCadastrarFuncionario.TabIndex = 77;
            this.btnCadastrarFuncionario.Text = "Cadastrar";
            this.btnCadastrarFuncionario.UseVisualStyleBackColor = false;
            this.btnCadastrarFuncionario.Click += new System.EventHandler(this.btnCadastrarFuncionario_Click);
            // 
            // label21
            // 
            this.label21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label21.Location = new System.Drawing.Point(27, 493);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(922, 1);
            this.label21.TabIndex = 114;
            // 
            // textCidadeFunc
            // 
            this.textCidadeFunc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textCidadeFunc.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textCidadeFunc.Location = new System.Drawing.Point(31, 443);
            this.textCidadeFunc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textCidadeFunc.Name = "textCidadeFunc";
            this.textCidadeFunc.Size = new System.Drawing.Size(288, 20);
            this.textCidadeFunc.TabIndex = 113;
            // 
            // maskedTextCepFunc
            // 
            this.maskedTextCepFunc.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.maskedTextCepFunc.Location = new System.Drawing.Point(810, 319);
            this.maskedTextCepFunc.Mask = "00000-000";
            this.maskedTextCepFunc.Name = "maskedTextCepFunc";
            this.maskedTextCepFunc.Size = new System.Drawing.Size(71, 25);
            this.maskedTextCepFunc.TabIndex = 112;
            this.maskedTextCepFunc.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.maskedTextCepFunc.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextCepFunc_MaskInputRejected);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label20.Location = new System.Drawing.Point(437, 265);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(96, 28);
            this.label20.TabIndex = 111;
            this.label20.Text = "Endereço";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label19.Location = new System.Drawing.Point(413, 22);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(158, 28);
            this.label19.TabIndex = 110;
            this.label19.Text = "Dados Pessoais";
            // 
            // label18
            // 
            this.label18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label18.Location = new System.Drawing.Point(19, 243);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(922, 1);
            this.label18.TabIndex = 109;
            // 
            // dateTimePickerFunc
            // 
            this.dateTimePickerFunc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFunc.Location = new System.Drawing.Point(37, 140);
            this.dateTimePickerFunc.Name = "dateTimePickerFunc";
            this.dateTimePickerFunc.Size = new System.Drawing.Size(158, 27);
            this.dateTimePickerFunc.TabIndex = 108;
            // 
            // maskedTextFuncCpf
            // 
            this.maskedTextFuncCpf.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.maskedTextFuncCpf.Location = new System.Drawing.Point(576, 82);
            this.maskedTextFuncCpf.Mask = "000.000.000-00";
            this.maskedTextFuncCpf.Name = "maskedTextFuncCpf";
            this.maskedTextFuncCpf.Size = new System.Drawing.Size(96, 25);
            this.maskedTextFuncCpf.TabIndex = 107;
            this.maskedTextFuncCpf.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // maskedTextRgFunc
            // 
            this.maskedTextRgFunc.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.maskedTextRgFunc.Location = new System.Drawing.Point(781, 82);
            this.maskedTextRgFunc.Mask = "00.000.000-0";
            this.maskedTextRgFunc.Name = "maskedTextRgFunc";
            this.maskedTextRgFunc.Size = new System.Drawing.Size(94, 25);
            this.maskedTextRgFunc.TabIndex = 106;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(715, 177);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(51, 20);
            this.label17.TabIndex = 105;
            this.label17.Text = "Senha";
            // 
            // textSenhaFunc
            // 
            this.textSenhaFunc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textSenhaFunc.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textSenhaFunc.Location = new System.Drawing.Point(715, 201);
            this.textSenhaFunc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textSenhaFunc.Name = "textSenhaFunc";
            this.textSenhaFunc.Size = new System.Drawing.Size(166, 20);
            this.textSenhaFunc.TabIndex = 104;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(27, 419);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(56, 20);
            this.label16.TabIndex = 103;
            this.label16.Text = "Cidade";
            // 
            // cmdEstadoCivilFunc
            // 
            this.cmdEstadoCivilFunc.FormattingEnabled = true;
            this.cmdEstadoCivilFunc.Items.AddRange(new object[] {
            "Solteiro",
            "Casado",
            "Viuvo"});
            this.cmdEstadoCivilFunc.Location = new System.Drawing.Point(743, 139);
            this.cmdEstadoCivilFunc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmdEstadoCivilFunc.Name = "cmdEstadoCivilFunc";
            this.cmdEstadoCivilFunc.Size = new System.Drawing.Size(138, 28);
            this.cmdEstadoCivilFunc.TabIndex = 102;
            // 
            // cmbEstadoFunc
            // 
            this.cmbEstadoFunc.FormattingEnabled = true;
            this.cmbEstadoFunc.Items.AddRange(new object[] {
            "",
            "AP ",
            "AM ",
            "PA ",
            "AC ",
            "RO ",
            "TO ",
            "MA ",
            "PI ",
            "CE ",
            "RN ",
            "PB ",
            "PE ",
            "AL ",
            "SE ",
            "BA ",
            "MT ",
            "DF ",
            "GO ",
            "MS ",
            "MG ",
            "ES ",
            "RJ ",
            "SP ",
            "PR ",
            "SC ",
            "RS "});
            this.cmbEstadoFunc.Location = new System.Drawing.Point(749, 443);
            this.cmbEstadoFunc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbEstadoFunc.Name = "cmbEstadoFunc";
            this.cmbEstadoFunc.Size = new System.Drawing.Size(132, 28);
            this.cmbEstadoFunc.TabIndex = 101;
            // 
            // cmdSexoFunc
            // 
            this.cmdSexoFunc.FormattingEnabled = true;
            this.cmdSexoFunc.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.cmdSexoFunc.Location = new System.Drawing.Point(526, 142);
            this.cmdSexoFunc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmdSexoFunc.Name = "cmdSexoFunc";
            this.cmdSexoFunc.Size = new System.Drawing.Size(146, 28);
            this.cmdSexoFunc.TabIndex = 100;
            // 
            // cmbCargoFunc
            // 
            this.cmbCargoFunc.FormattingEnabled = true;
            this.cmbCargoFunc.Items.AddRange(new object[] {
            "Gerente",
            "Analista",
            "Vendas",
            "Suporte"});
            this.cmbCargoFunc.Location = new System.Drawing.Point(287, 142);
            this.cmbCargoFunc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbCargoFunc.Name = "cmbCargoFunc";
            this.cmbCargoFunc.Size = new System.Drawing.Size(138, 28);
            this.cmbCargoFunc.TabIndex = 99;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(42, 176);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(46, 20);
            this.label15.TabIndex = 98;
            this.label15.Text = "Email";
            // 
            // textEmailFunc
            // 
            this.textEmailFunc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textEmailFunc.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textEmailFunc.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textEmailFunc.Location = new System.Drawing.Point(33, 201);
            this.textEmailFunc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textEmailFunc.Name = "textEmailFunc";
            this.textEmailFunc.Size = new System.Drawing.Size(392, 20);
            this.textEmailFunc.TabIndex = 97;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(749, 419);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 20);
            this.label14.TabIndex = 96;
            this.label14.Text = "Estado:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(628, 360);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 20);
            this.label12.TabIndex = 94;
            this.label12.Text = "Telefone:";
            // 
            // textTelefoneFunc
            // 
            this.textTelefoneFunc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textTelefoneFunc.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textTelefoneFunc.Location = new System.Drawing.Point(628, 386);
            this.textTelefoneFunc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textTelefoneFunc.Name = "textTelefoneFunc";
            this.textTelefoneFunc.Size = new System.Drawing.Size(166, 20);
            this.textTelefoneFunc.TabIndex = 93;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(810, 296);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 20);
            this.label11.TabIndex = 92;
            this.label11.Text = "Cep:";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(27, 365);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 20);
            this.label10.TabIndex = 91;
            this.label10.Text = "Bairro:";
            // 
            // textBairroFunc
            // 
            this.textBairroFunc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBairroFunc.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBairroFunc.Location = new System.Drawing.Point(31, 386);
            this.textBairroFunc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBairroFunc.Name = "textBairroFunc";
            this.textBairroFunc.Size = new System.Drawing.Size(448, 20);
            this.textBairroFunc.TabIndex = 90;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(420, 419);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 20);
            this.label9.TabIndex = 89;
            this.label9.Text = "Município:";
            // 
            // textMunicipioFunc
            // 
            this.textMunicipioFunc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textMunicipioFunc.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textMunicipioFunc.Location = new System.Drawing.Point(420, 443);
            this.textMunicipioFunc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textMunicipioFunc.Name = "textMunicipioFunc";
            this.textMunicipioFunc.Size = new System.Drawing.Size(232, 20);
            this.textMunicipioFunc.TabIndex = 88;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(570, 310);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 20);
            this.label8.TabIndex = 87;
            this.label8.Text = "Número:";
            // 
            // textNumeroResidenciaFunc
            // 
            this.textNumeroResidenciaFunc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textNumeroResidenciaFunc.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textNumeroResidenciaFunc.Location = new System.Drawing.Point(570, 334);
            this.textNumeroResidenciaFunc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textNumeroResidenciaFunc.Name = "textNumeroResidenciaFunc";
            this.textNumeroResidenciaFunc.Size = new System.Drawing.Size(82, 20);
            this.textNumeroResidenciaFunc.TabIndex = 86;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(743, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 20);
            this.label7.TabIndex = 85;
            this.label7.Text = "Estado civil:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(31, 310);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 20);
            this.label6.TabIndex = 84;
            this.label6.Text = "Logradouro";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(37, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 20);
            this.label5.TabIndex = 83;
            this.label5.Text = "Data de Nascimento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(526, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 20);
            this.label4.TabIndex = 82;
            this.label4.Text = "Sexo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(781, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 20);
            this.label3.TabIndex = 81;
            this.label3.Text = "RG:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(576, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 20);
            this.label2.TabIndex = 80;
            this.label2.Text = "CPF:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(37, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 79;
            this.label1.Text = "Nome:";
            // 
            // textEnderecoFunc
            // 
            this.textEnderecoFunc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textEnderecoFunc.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textEnderecoFunc.Location = new System.Drawing.Point(31, 334);
            this.textEnderecoFunc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textEnderecoFunc.Name = "textEnderecoFunc";
            this.textEnderecoFunc.Size = new System.Drawing.Size(448, 20);
            this.textEnderecoFunc.TabIndex = 95;
            // 
            // textNomeFunc
            // 
            this.textNomeFunc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textNomeFunc.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textNomeFunc.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textNomeFunc.Location = new System.Drawing.Point(37, 82);
            this.textNomeFunc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textNomeFunc.Name = "textNomeFunc";
            this.textNomeFunc.Size = new System.Drawing.Size(434, 20);
            this.textNomeFunc.TabIndex = 78;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(287, 118);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 20);
            this.label13.TabIndex = 115;
            this.label13.Text = "Cargo:";
            // 
            // btnExcluirFuncionario
            // 
            this.btnExcluirFuncionario.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnExcluirFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExcluirFuncionario.ForeColor = System.Drawing.Color.White;
            this.btnExcluirFuncionario.Location = new System.Drawing.Point(435, 539);
            this.btnExcluirFuncionario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExcluirFuncionario.Name = "btnExcluirFuncionario";
            this.btnExcluirFuncionario.Size = new System.Drawing.Size(108, 41);
            this.btnExcluirFuncionario.TabIndex = 118;
            this.btnExcluirFuncionario.Text = "Excluir";
            this.btnExcluirFuncionario.UseVisualStyleBackColor = false;
            // 
            // btnEditarFuncionario
            // 
            this.btnEditarFuncionario.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnEditarFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEditarFuncionario.ForeColor = System.Drawing.Color.White;
            this.btnEditarFuncionario.Location = new System.Drawing.Point(564, 539);
            this.btnEditarFuncionario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEditarFuncionario.Name = "btnEditarFuncionario";
            this.btnEditarFuncionario.Size = new System.Drawing.Size(108, 41);
            this.btnEditarFuncionario.TabIndex = 117;
            this.btnEditarFuncionario.Text = "Editar";
            this.btnEditarFuncionario.UseVisualStyleBackColor = false;
            // 
            // btnExibirFuncionario
            // 
            this.btnExibirFuncionario.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnExibirFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExibirFuncionario.ForeColor = System.Drawing.Color.White;
            this.btnExibirFuncionario.Location = new System.Drawing.Point(690, 539);
            this.btnExibirFuncionario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExibirFuncionario.Name = "btnExibirFuncionario";
            this.btnExibirFuncionario.Size = new System.Drawing.Size(108, 41);
            this.btnExibirFuncionario.TabIndex = 116;
            this.btnExibirFuncionario.Text = "Exibir";
            this.btnExibirFuncionario.UseVisualStyleBackColor = false;
            // 
            // FormularioCadastroFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(973, 616);
            this.Controls.Add(this.btnExcluirFuncionario);
            this.Controls.Add(this.btnEditarFuncionario);
            this.Controls.Add(this.btnExibirFuncionario);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.textCidadeFunc);
            this.Controls.Add(this.maskedTextCepFunc);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.dateTimePickerFunc);
            this.Controls.Add(this.maskedTextFuncCpf);
            this.Controls.Add(this.maskedTextRgFunc);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.textSenhaFunc);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.cmdEstadoCivilFunc);
            this.Controls.Add(this.cmbEstadoFunc);
            this.Controls.Add(this.cmdSexoFunc);
            this.Controls.Add(this.cmbCargoFunc);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.textEmailFunc);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textTelefoneFunc);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBairroFunc);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textMunicipioFunc);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textNumeroResidenciaFunc);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textEnderecoFunc);
            this.Controls.Add(this.textNomeFunc);
            this.Controls.Add(this.btnCadastrarFuncionario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormularioCadastroFuncionarios";
            this.Text = "Funcionarios";
            this.Load += new System.EventHandler(this.CadastroFuncionarios_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox textBox13;
        private Button btnCadastrarFuncionario;
        private Label label21;
        private TextBox textCidadeFunc;
        private MaskedTextBox maskedTextCepFunc;
        private Label label20;
        private Label label19;
        private Label label18;
        private DateTimePicker dateTimePickerFunc;
        private MaskedTextBox maskedTextFuncCpf;
        private MaskedTextBox maskedTextRgFunc;
        private Label label17;
        private TextBox textSenhaFunc;
        private Label label16;
        private ComboBox cmdEstadoCivilFunc;
        private ComboBox cmbEstadoFunc;
        private ComboBox cmdSexoFunc;
        private ComboBox cmbCargoFunc;
        private Label label15;
        private TextBox textEmailFunc;
        private Label label14;
        private Label label12;
        private TextBox textTelefoneFunc;
        private Label label11;
        private Label label10;
        private TextBox textBairroFunc;
        private Label label9;
        private TextBox textMunicipioFunc;
        private Label label8;
        private TextBox textNumeroResidenciaFunc;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textEnderecoFunc;
        private TextBox textNomeFunc;
        private Label label13;
        private Button btnExcluirFuncionario;
        private Button btnEditarFuncionario;
        private Button btnExibirFuncionario;
    }
}