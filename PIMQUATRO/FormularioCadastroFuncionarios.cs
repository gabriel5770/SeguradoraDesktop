using PIMQUATRO.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace PIMQUATRO
{
    public partial class FormularioCadastroFuncionarios : Form
    {
        private void CadastroFuncionarios_Load(object sender, EventArgs e)
        {

        }
        public FormularioCadastroFuncionarios()
        {
            InitializeComponent();

        }


        private void Voltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormularioMenu().ShowDialog();
        }

        private void btnCadastrarFuncionario_Click(object sender, EventArgs e)
        {
            ObtemDadosFuncionarios();
        }

        private void ObtemDadosFuncionarios()
        {
            string Email = textEmailFunc.Text;
            string Senha = textSenhaFunc.Text;
            string Nome = textNomeFunc.Text;
            string EstadoCivil = cmdEstadoCivilFunc.Text;
            DateTime DataNascimento = Convert.ToDateTime(dateTimePickerFunc.Text);
            string Rg = maskedTextRgFunc.Text;
            string Cpf = maskedTextFuncCpf.Text;
            string Sexo = cmdSexoFunc.Text;
            string Endereco = textEnderecoFunc.Text;
            string NumResidencia = textNumeroResidenciaFunc.Text;
            string Estado = cmbEstadoFunc.Text;
            string Municipio = textMunicipioFunc.Text;
            string Bairro = textBairroFunc.Text;
            string Cidade = textCidadeFunc.Text;
            string Cep = maskedTextCepFunc.Text;
            string Telefone = textTelefoneFunc.Text;
            string Cargo = cmbCargoFunc.Text;


            Funcionario func = new Funcionario(Nome, Cpf, Rg, DataNascimento, Endereco, Email, Senha, EstadoCivil, Sexo, NumResidencia, Municipio, Bairro, Cep, Telefone, Estado, Cidade, Cargo);
            if (VerificaCampo())
            {

                if (func.Cadastrar())
                {
                    this.Hide();
                    new FormularioMenu().ShowDialog();
                    MessageBox.Show("Funcionário cadastrado com sucesso");
                }
            }
        }

        private bool VerificaCampo()
        {
            if (textEmailFunc.Text == "" || textSenhaFunc.Text == "" || textNomeFunc.Text == "" || cmdEstadoCivilFunc.Text == "" ||
                maskedTextRgFunc.Text == "" || maskedTextFuncCpf.Text == "" || cmdSexoFunc.Text == "" || textEnderecoFunc.Text == "" ||
                textNumeroResidenciaFunc.Text == "" || cmbEstadoFunc.Text == "" || textMunicipioFunc.Text == "" || textBairroFunc.Text == "" ||
                textCidadeFunc.Text == "" || maskedTextCepFunc.Text == "" || textTelefoneFunc.Text == "" || cmbCargoFunc.Text == "")
            {
                MessageBox.Show("Há campos que não foram preenchidos , revise");
                return false;
            }
            return true;

        }
    }
}



