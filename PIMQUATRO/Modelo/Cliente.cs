using iText.Kernel.Pdf.Canvas.Wmf;
using iText.StyledXmlParser.Jsoup.Nodes;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace PIMQUATRO.Modelo
{
    public class Cliente
    {
        public string _email { get; set; }
        public string _senha { get; set; }
        public string _nome { get; set; }
        public string _estadoCivil { get; set; }
        public string _rg { get; set; }
        public string _sexo { get; set; }
        public string _endereco { get; set; }
        public string _numeroResidencia { get; set; }
        public string _municipio { get; set; }
        public string _bairro { get; set; }
        public string _cep { get; set; }
        public string _telefone { get; set; }
        public string _estado { get; set; }
        public string _beneficios { get; set; }
        public string _cidade { get; set; }
        public string _cpf { get; set; }
        public DateTime _dataNascimento { get; set; }
        public string _dataVigenciaInicial { get; set; }
        public string _dataVigenciaFinal { get; set; }
        public string _nomeSeguradora { get; set; }

        public Cliente(string email, string senha, string nome, string estadoCivil, string rg, string sexo, string endereco, string numeroResidencia, string municipio, string bairro, string cep, string telefone, string estado, DateTime dataNascimento, string cpf, string beneficios, string cidade, string dataVigenciaInicial = "", string dataVigenciaFinal = "", string nomeSeguradora = "")
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
            bool rtnValido = true;
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
                            command.Parameters.AddWithValue("@DataVigenciaInicial", Convert.ToDateTime(_dataVigenciaInicial));
                            command.Parameters.AddWithValue("@DataVigenciaFinal", Convert.ToDateTime(_dataVigenciaFinal));
                            command.Parameters.AddWithValue("@NumeroApolice", NumeroApolice.Next());
                            command.Parameters.AddWithValue("@NumeroContrato", NumeroContrato.Next());
                            command.Parameters.AddWithValue("@NomeSeguradora", _nomeSeguradora);


                            SqlParameter param = new SqlParameter();

                            var returnParameter = command.Parameters.Add("@CadastroValido", SqlDbType.Int);
                            returnParameter.Direction = ParameterDirection.ReturnValue;

                            connection.Open();
                            command.ExecuteNonQuery();

                            var result = (int)returnParameter.Value;


                            if (result == 1)
                            {
                                MessageBox.Show("Há um cadastro com este CPF!");
                                rtnValido = false;

                            }
                            else if (result == 2)
                            {
                                MessageBox.Show("Há um cadastro com este RG");
                                rtnValido = false;
                            }
                            else if (result == 3)
                            {
                                MessageBox.Show("Há um cadastro com este EMAIL");
                                rtnValido = false;
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
                            rtnValido = false;
                        }
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

        public List<Cliente> GetTodosClientes()
        {
            List<Cliente> resultClientes = new List<Cliente>();

            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ToString()))
            {
                connection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM tbClientes";

                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    var cliente = new Cliente
                    {
                        _nome = reader[1]?.ToString(),
                        _rg = reader[2]?.ToString(),
                        _cpf = reader[3]?.ToString(),
                        _sexo = reader[4]?.ToString(),
                        _dataNascimento = Convert.ToDateTime(reader[5]?.ToString()),
                        _estadoCivil = reader[6]?.ToString(),
                        _cidade = reader[7]?.ToString(),
                        _email = reader[16]?.ToString()
                    };

                    resultClientes.Add(cliente);
                }
                connection.Close();
            }
            return resultClientes;
        }
    }
}
