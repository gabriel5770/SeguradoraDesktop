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
        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrarFuncionario_Click(object sender, EventArgs e)
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



            Funcionario func = new Funcionario(Nome, Cpf, Rg, DataNascimento, Endereco, Email, Senha, EstadoCivil, Sexo, NumResidencia, Municipio, Bairro, Cep, Telefone, Estado, Cidade);

            if (func.Cadastrar())
            {
                this.Hide();
                new FormularioMenu().ShowDialog();
                MessageBox.Show("Funcionário cadastrado com sucesso");
            }
        }

        private void cmbSexoFunc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtNomeFunc_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextFuncCpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void cmbEstadoFunc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textNumeroResidenciaFunc_TextChanged(object sender, EventArgs e)
        {

        }

        private void textMunicipioFunc_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBairroFunc_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmdEstadoCivilFunc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textSenhaFunc_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbCargoFunc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}


