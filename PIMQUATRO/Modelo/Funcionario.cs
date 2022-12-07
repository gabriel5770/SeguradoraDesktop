using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace PIMQUATRO.Modelo
{
    internal class Funcionario
    {
        private string _email { get; set; }
        private string _senha { get; set; }
        private string _nome { get; set; }
        private string _estadoCivil { get; set; }
        private string _rg { get; set; }
        private string _sexo { get; set; }
        private string _endereco { get; set; }
        private string _numeroResidencia { get; set; }
        private string _municipio { get; set; }
        private string _bairro { get; set; }
        private string _cep { get; set; }
        private string _telefone { get; set; }
        private string _estado { get; set; }
        private string _beneficios { get; set; }
        private string _cidade { get; set; }
        private string _cpf { get; set; }
        private DateTime _dataNascimento { get; set; }
        private string _cargo { get; set; }

        public Funcionario(string nome, string cpf, string rg, DateTime dataNascimento, string endereco, string email, string senha, string estadoCivil, string sexo, string numeroResidencia, string municipio, string bairro, string cep, String telefone, string estado, string cidade, string cargo)
        {
            _nome = nome;
            _cpf = cpf;
            _rg = rg;
            _dataNascimento = dataNascimento;
            _endereco = endereco;
            _email = email;
            _senha = senha;
            _estadoCivil = estadoCivil;
            _sexo = sexo;
            _numeroResidencia = numeroResidencia;
            _municipio = municipio;
            _bairro = bairro;
            _cep = cep;
            _telefone = telefone;
            _estado = estado;
            _cidade = cidade;
            _cargo = cargo;
        }


        public bool Cadastrar()
        {
            bool rtnValido = false;
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ToString()))
            {
                using (var command = new SqlCommand
                {
                    Connection = connection,
                    CommandType = CommandType.StoredProcedure
                })
                {
                    command.CommandText = "Ins_WindowsForms_Cadastro_Funcionario";
                    try
                    {
                        command.Parameters.AddWithValue("@Email", _email);
                        command.Parameters.AddWithValue("@Senha", _senha);
                        command.Parameters.AddWithValue("@Nome", _nome);
                        command.Parameters.AddWithValue("@EstadoCivil", _estadoCivil);
                        command.Parameters.AddWithValue("@DataNascimento", Convert.ToDateTime(_dataNascimento));
                        command.Parameters.AddWithValue("@Rg", _rg);
                        command.Parameters.AddWithValue("@Cpf", _cpf);
                        command.Parameters.AddWithValue("@Sexo", _sexo);
                        command.Parameters.AddWithValue("@Endereco", _endereco);
                        command.Parameters.AddWithValue("@NumeroResidencia", _numeroResidencia);
                        command.Parameters.AddWithValue("@Estado", _estado);
                        command.Parameters.AddWithValue("@Municipio", _municipio);
                        command.Parameters.AddWithValue("@Bairro", _bairro);
                        command.Parameters.AddWithValue("@Cep", _cep);
                        command.Parameters.AddWithValue("@Telefone", _telefone);
                        command.Parameters.AddWithValue("@Cargo", _cargo);
                        command.Parameters.AddWithValue("@Cidade", _cidade);


                        var returnParameter = command.Parameters.Add("@CpfValido", SqlDbType.Int);
                        returnParameter.Direction = ParameterDirection.ReturnValue;

                        connection.Open();
                        command.ExecuteNonQuery();
                        var result = (int)returnParameter.Value;


                        if (result == 1)
                        {
                            MessageBox.Show("Há um cadastro com este CPF!");
                            return false;

                        }
                        else if (result == 2)
                        {
                            MessageBox.Show("Há um cadastro com este RG!");

                        }
                        else if (result == 3)
                        {
                            MessageBox.Show("Há um cadastro com este EMAIL!");
                        }
                        else
                        {
                            rtnValido= true;
                        }

                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Erro ao cadastrar usuário");
                        MessageBox.Show("Erro encontrado: " + ex);
                        rtnValido= false;
                    }
                }
                return rtnValido;
            }
        }

        public static bool ExcluiCadastro(string cpf)
        {
            bool rtnValido = false;
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ToString()))
            {
                using (var command = new SqlCommand
                {
                    Connection = connection,
                    CommandType = CommandType.StoredProcedure
                })
                {
                    command.CommandText = "Ins_WindowsForms_Cadastro_ExcluiCadastroFuncionario";
                    try
                    {
                        command.Parameters.AddWithValue("@Cpf", cpf);

                        connection.Open();
                        command.ExecuteNonQuery();

                        rtnValido = true;
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Erro ao excluir cadastro");
                        MessageBox.Show("Erro encontrado: " + ex);
                    }
                }
            }
            return rtnValido;
        }
        public bool AtualizaCadastro(string cpf)
        {
            bool rtnValido = false;
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ToString()))
            {
                using (var command = new SqlCommand
                {
                    Connection = connection,
                    CommandType = CommandType.StoredProcedure
                })
                {
                    command.CommandText = "Qry_WindowsForms_Cadastro_AtualizaCadastroFuncionario";
                    try
                    {
                        command.Parameters.AddWithValue("@Cpf", cpf);
                        command.Parameters.AddWithValue("@Email", _email);
                        command.Parameters.AddWithValue("@Senha", _senha);
                        command.Parameters.AddWithValue("@Nome", _nome);
                        command.Parameters.AddWithValue("@EstadoCivil", _estadoCivil);
                        command.Parameters.AddWithValue("@DataNascimento", Convert.ToDateTime(_dataNascimento));
                        command.Parameters.AddWithValue("@Rg", _rg);
                        command.Parameters.AddWithValue("@Sexo", _sexo);
                        command.Parameters.AddWithValue("@Endereco", _endereco);
                        command.Parameters.AddWithValue("@NumeroResidencia", _numeroResidencia);
                        command.Parameters.AddWithValue("@Estado", _estado);
                        command.Parameters.AddWithValue("@Municipio", _municipio);
                        command.Parameters.AddWithValue("@Bairro", _bairro);
                        command.Parameters.AddWithValue("@Cep", _cep);
                        command.Parameters.AddWithValue("@Telefone", _telefone);
                        command.Parameters.AddWithValue("@Cargo", _cargo);
                        command.Parameters.AddWithValue("@Cidade", _cidade);

                        connection.Open();
                        command.ExecuteNonQuery();

                        rtnValido = true;
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Erro ao atualizar cadastro");
                        MessageBox.Show("Erro encontrado: " + ex);
                    }
                }
            }
            return rtnValido;
        }

        public bool VerificaCampo()
        {
            if (_email == "" || _senha == "" || _nome == "" || _estadoCivil == "" || _rg == "" ||
                _cpf == "" || _sexo == "" || _endereco == "" || _numeroResidencia == "" || _estado == "" || _municipio == "" || _bairro == "" ||
                _cidade == "" || _cep == "" || _telefone == "" || _cargo == "")
            {
                MessageBox.Show("Há campos que não foram preenchidos , revise");
                return false;
            }
            return true;

        }
    }
}


