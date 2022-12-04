using PIMQUATRO.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace PIMQUATRO
{
    public partial class FormularioCadastroFuncionarios : Form
    {
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

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            PesquisaDadosFuncionario();
        }

        private void btnExcluirFuncionario_Click(object sender, EventArgs e)
        {
            ExcluiDadosFuncionario();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            AtualizaDadosFuncionario();
        }


        protected void ObtemDadosFuncionarios()
        {

            string Email = textEmailFunc.Text.Trim();
            string Senha = textSenhaFunc.Text.Trim();
            string Nome = textNomeFunc.Text.Trim();
            string EstadoCivil = cmdEstadoCivilFunc.Text.Trim();
            DateTime DataNascimento = Convert.ToDateTime(dateTimePickerFunc.Text.Trim());
            string Rg = maskedTextRgFunc.Text.Trim();
            string Cpf = maskedTextFuncCpf.Text.Trim();
            string Sexo = cmdSexoFunc.Text.Trim();
            string Endereco = textEnderecoFunc.Text.Trim();
            string NumResidencia = textNumeroResidenciaFunc.Text.Trim();
            string Estado = cmbEstadoFunc.Text.Trim();
            string Municipio = textMunicipioFunc.Text.Trim();
            string Bairro = textBairroFunc.Text.Trim();
            string Cidade = textCidadeFunc.Text.Trim();
            string Cep = maskedTextCepFunc.Text.Trim();
            string Telefone = maskedTelefoneFuncionario.Text.Trim();
            string Cargo = cmbCargoFunc.Text.Trim();


            Funcionario func = new Funcionario(Nome, Cpf, Rg, DataNascimento, Endereco, Email, Senha, EstadoCivil, Sexo, NumResidencia, Municipio, Bairro, Cep, Telefone, Estado, Cidade, Cargo);

            if (func.VerificaCampo())
            {
                if (func.Cadastrar())
                {
                    this.Hide();
                    new FormularioMenu().ShowDialog();
                    MessageBox.Show("Funcionário cadastrado com sucesso");
                }
            }
        }

        protected bool RetornaPesquisaCpf()
        {
            bool rtnValido = false;
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ToString()))
            {
                connection.Open();

                using (var command = new SqlCommand($"Select * from tbFuncionarios where cpf = '{maskedTextFuncCpf.Text}'", connection))

                    try
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            textNomeFunc.Text = reader.GetString(1);
                            maskedTextFuncCpf.Text = reader.GetString(2);
                            dateTimePickerFunc.Text = reader.GetDateTime(3).ToString();
                            maskedTextRgFunc.Text = reader.GetString(4);
                            cmdSexoFunc.Text = reader.GetString(5);
                            cmbCargoFunc.Text = reader.GetString(6);
                            cmdEstadoCivilFunc.Text = reader.GetString(8);
                            textCidadeFunc.Text = reader.GetString(9);
                            textEnderecoFunc.Text = reader.GetString(10);
                            textNumeroResidenciaFunc.Text = reader.GetString(11);
                            textBairroFunc.Text = reader.GetString(12);
                            textMunicipioFunc.Text = reader.GetString(13);
                            cmbEstadoFunc.Text = reader.GetString(14);
                            maskedTextCepFunc.Text = reader.GetString(15);
                            textEmailFunc.Text = reader.GetString(16);
                            maskedTelefoneFuncionario.Text = reader.GetString(17);
                            textSenhaFunc.Text = reader.GetString(18);

                            rtnValido = true;
                            return rtnValido;
                        }

                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Erro ao buscar funcionário");
                        MessageBox.Show("Erro encontrado: " + ex);

                    }
                return rtnValido;
            }
        }

       
        protected bool ValidaCampos()
        {
            if (textNomeFunc.Text == "" || maskedTextFuncCpf.Text == "" || maskedTextRgFunc.Text == ""
                || cmbCargoFunc.Text == "" || cmdSexoFunc.Text == "" || cmdEstadoCivilFunc.Text == ""
                || textEmailFunc.Text == "" || maskedTelefoneFuncionario.Text == "" || textSenhaFunc.Text == ""
                || textEnderecoFunc.Text == "" || textNumeroResidenciaFunc.Text == "" || maskedTextCepFunc.Text == ""
                || textBairroFunc.Text == "" || textCidadeFunc.Text == "" || textMunicipioFunc.Text == "" || cmbEstadoFunc.Text == "")
            {
                MessageBox.Show("Há campos não preenchidos , revise");
                return false;
            }
            return true;
        }


        protected void PesquisaDadosFuncionario()
        {
            if (maskedTextFuncCpf.Text == "")
            {
                MessageBox.Show("Por favor , insira um valor no campo CPF");
            }
            else if (RetornaPesquisaCpf())
            {
                MessageBox.Show("Cadastro encontrado!");
            }
            else
            {
                MessageBox.Show("Não foi possível encontrar cadastro com este CPF");
            }
        }

        protected void ExcluiDadosFuncionario()
        {
            if (ValidaCampos())
            {
                DialogResult = MessageBox.Show("Deseja excluir o cadastro?", "ATENÇÃO", MessageBoxButtons.YesNo);
                if (DialogResult == DialogResult.Yes)
                {
                    if (Funcionario.ExcluiCadastro(maskedTextFuncCpf.Text))
                    {
                        MessageBox.Show("Cadastro excluido com sucesso");
                        this.Hide();
                        new FormularioCadastroFuncionarios().ShowDialog();

                    }
                    else
                    {
                        MessageBox.Show("Não foi possível excluir o cadastro");
                    }
                }

            }
            else
            {
                MessageBox.Show("Pesquise o CPF a ser excluido");
            }
        }

        protected void AtualizaDadosFuncionario()
        {
            string Email = textEmailFunc.Text.Trim();
            string Senha = textSenhaFunc.Text.Trim();
            string Nome = textNomeFunc.Text.Trim();
            string EstadoCivil = cmdEstadoCivilFunc.Text.Trim();
            DateTime DataNascimento = Convert.ToDateTime(dateTimePickerFunc.Text.Trim());
            string Rg = maskedTextRgFunc.Text.Trim();
            string Cpf = maskedTextFuncCpf.Text.Trim();
            string Sexo = cmdSexoFunc.Text.Trim();
            string Endereco = textEnderecoFunc.Text.Trim();
            string NumResidencia = textNumeroResidenciaFunc.Text.Trim();
            string Estado = cmbEstadoFunc.Text.Trim();
            string Municipio = textMunicipioFunc.Text.Trim();
            string Bairro = textBairroFunc.Text.Trim();
            string Cidade = textCidadeFunc.Text.Trim();
            string Cep = maskedTextCepFunc.Text.Trim();
            string Telefone = maskedTelefoneFuncionario.Text.Trim();
            string Cargo = cmbCargoFunc.Text.Trim();

            if (ValidaCampos())
            {
                DialogResult = MessageBox.Show("Deseja atualizar o cadastro?", "ATENÇÃO", MessageBoxButtons.YesNo);
                if (DialogResult == DialogResult.Yes)
                {
                    Funcionario func = new Funcionario(Nome, Cpf, Rg, DataNascimento, Endereco, Email, Senha, EstadoCivil, Sexo, NumResidencia, Municipio, Bairro, Cep, Telefone, Estado, Cidade, Cargo);
                    if (func.AtualizaCadastro(Cpf))
                    {
                        MessageBox.Show("Cadastro atualizado com sucesso");
                    }
                    else
                    {
                        MessageBox.Show("Não foi possíevl atualizar o cadastro");
                    }
                }
            }
            else
            {
                MessageBox.Show("Pesquise o CPF a ser Atualizado");
            }
        }
    }
}







