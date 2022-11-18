using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace PIMQUATRO.Modelo
{
    public class Cliente
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
        private DateTime _dataNascimento { get; set; }
        private string _beneficios { get; set; }
        private string _cidade { get; set; }
        private string _cpf { get; set; }
        private DateTime _dataVigenciaInicial { get; set; }
        private DateTime _dataVigenciaFinal { get; set; }
        private String _nomeSeguradora { get; set; }

        public Cliente(string email, string senha, string nome, string estadoCivil, string rg, string sexo, string endereco, string numeroResidencia, string municipio, string bairro, string cep, string telefone, string estado, DateTime dataNascimento, string cpf, string beneficios, string cidade, DateTime dataVigenciaInicial, DateTime dataVigenciaFinal, string nomeSeguradora)
        {
            _email = email;
            _senha = senha;
            _nome = nome;
            _estadoCivil = estadoCivil;
            _rg = rg;
            _sexo = sexo;
            _endereco = endereco;
            _numeroResidencia = numeroResidencia;
            _municipio = municipio;
            _bairro = bairro;
            _cep = cep;
            _telefone = telefone;
            _estado = estado;
            _dataNascimento = dataNascimento;
            _cpf = cpf;
            _beneficios = beneficios;
            _cidade = cidade;
            _dataVigenciaFinal = dataVigenciaFinal;
            _dataVigenciaInicial = dataVigenciaInicial;
            _nomeSeguradora = nomeSeguradora;
        }

        public Cliente()
        {

        }


        public bool Cadastrar()
        {
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ToString()))
                {
                    Random NumeroApolice = new Random();
                    Random NumeroContrato = new Random();
 
                    using (var command = new SqlCommand
                    {
                        Connection = connection,
                        CommandType = CommandType.StoredProcedure
                    })
                    {
                        command.CommandText = "Ins_WindowsForms_Cadastro_Cliente";
                        try
                        {
                            command.Parameters.AddWithValue("@Email", _email);
                            command.Parameters.AddWithValue("@Senha", _senha);
                            command.Parameters.AddWithValue("@Nome", _nome);
                            command.Parameters.AddWithValue("@EstadoCivil", _estadoCivil);
                            command.Parameters.AddWithValue("@DataNascimento", _dataNascimento);
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
                            command.Parameters.AddWithValue("@Beneficios", _beneficios);
                            command.Parameters.AddWithValue("@Cidade", _cidade);
                            command.Parameters.AddWithValue("@DataVigenciaInicial", _dataVigenciaInicial);
                            command.Parameters.AddWithValue("@DataVigenciaFinal", _dataVigenciaFinal);
                            command.Parameters.AddWithValue("@NumeroApolice", NumeroApolice.Next());
                            command.Parameters.AddWithValue("@NumeroContrato", NumeroContrato.Next());
                            command.Parameters.AddWithValue("@NomeSeguradora", _nomeSeguradora);


                            SqlParameter param = new SqlParameter();

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
                            else

                            {
                                return true;
                            }

                        }
                        catch (SqlException ex)
                        {
                            MessageBox.Show("Erro ao cadastrar Cliente");
                            MessageBox.Show("Erro encontrado: " + ex);
                            return false;
                        }
                    }
                }
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
                    command.CommandText = "Upd_WindowsForms_Cadastro_ExcluiCadastroCliente";
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

        public bool AtualizaCadastro()
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
                    command.CommandText = "Upd_WindowsForms_Cadastro_AtualizaCadastroCliente";
                    try
                    {
                        command.Parameters.AddWithValue("@Cpf", _cpf);
                        command.Parameters.AddWithValue("@Email", _email);
                        command.Parameters.AddWithValue("@Senha", _senha);
                        command.Parameters.AddWithValue("@Nome", _nome);
                        command.Parameters.AddWithValue("@Beneficios", _beneficios);
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
    }
}
