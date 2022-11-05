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
            if (RetornaPesquisaCpf())
            {
                MessageBox.Show("Cadastro encontrado!");
            }
            else
            {
                MessageBox.Show("Não foi possível encontrar cadastro com este CPF");
            }
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
            string Telefone = maskedTelefoneFuncionario.Text;
            string Cargo = cmbCargoFunc.Text;


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

        private bool RetornaPesquisaCpf()
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

        private void btnExcluirFuncionario_Click(object sender, EventArgs e)
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
    }
}







