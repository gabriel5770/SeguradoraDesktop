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
        public string Nome { get; set; }
        public String Cpf { get; set; }
        public String Rg { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Endereco { get; set; }
        public String Email { get; set; }
        public String Senha { get; set; }
        public string EstadoCivil { get; set; }
        public string Sexo { get; set; }
        public string NumeroResidencia { get; set; }
        public string Municipio { get; set; }
        public string Bairro { get; set; }
        public string Cep { get; set; }
        public String Telefone { get; set; }
        public string Estado { get; set; }

        public Funcionario(string nome, string cpf, string rg, DateTime dataNascimento, string endereco, string email, string senha, string estadoCivil, string sexo, string numeroResidencia, string municipio, string bairro, string cep, String telefone, string estado)
        {
            Nome = nome;
            Cpf = cpf;
            Rg = rg;
            DataNascimento = dataNascimento;
            Endereco = endereco;
            Email = email;
            Senha = senha;
            EstadoCivil = estadoCivil;
            Sexo = sexo;
            NumeroResidencia = numeroResidencia;
            Municipio = municipio;
            Bairro = bairro;
            Cep = cep;
            Telefone = telefone;
            Estado = estado;
        }

        public bool Cadastrar()
        {
            {
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
                            command.Parameters.AddWithValue("@Email", Email);
                            command.Parameters.AddWithValue("@Senha", Senha);
                            command.Parameters.AddWithValue("@Nome", Nome);
                            command.Parameters.AddWithValue("@EstadoCivil", EstadoCivil);
                            command.Parameters.AddWithValue("@DataNascimento", Convert.ToDateTime(DataNascimento));
                            command.Parameters.AddWithValue("@Rg", Rg);
                            command.Parameters.AddWithValue("@Cpf", Cpf);
                            command.Parameters.AddWithValue("@Sexo", Sexo);
                            command.Parameters.AddWithValue("@Endereco", Endereco);
                            command.Parameters.AddWithValue("@NumeroResidencia", NumeroResidencia);
                            command.Parameters.AddWithValue("@Estado",Estado);
                            command.Parameters.AddWithValue("@Municipio", Municipio);
                            command.Parameters.AddWithValue("@Bairro", Bairro);
                            command.Parameters.AddWithValue("@Cep", Cep);
                            command.Parameters.AddWithValue("@Telefone", Telefone);


                            connection.Open();
                            command.ExecuteNonQuery();

                            return true;
                        }
                        catch (SqlException ex)
                        {
                            MessageBox.Show("Erro ao cadastrar usuário");
                            MessageBox.Show("Erro encontrado: " + ex);
                            return false;
                        }
                    }
                }
            }
        }
    }
}

