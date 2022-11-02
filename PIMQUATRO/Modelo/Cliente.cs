using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIMQUATRO.Modelo
{
    public class Cliente
    {
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string EstadoCivil { get; set; }
        public string Rg { get; set; }
        public string Sexo { get; set; }
        public string Endereco { get; set; }
        public string NumeroResidencia { get; set; }
        public string Municipio { get; set; }
        public string Bairro { get; set; }
        public string Cep { get; set; }
        public string Telefone { get; set; }
        public string Estado { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Beneficios { get; set; }
        public string Cidade { get; set; }
        public string Cpf { get; set; }

        public Cliente(string email, string senha, string nome, string estadoCivil, string rg, string sexo, string endereco, string numeroResidencia, string municipio, string bairro, string cep, string telefone, string estado, DateTime dataNascimento, string cpf, string beneficios, string cidade)
        {
            Email = email;
            Senha = senha;
            Nome = nome;
            EstadoCivil = estadoCivil;
            Rg = rg;
            Sexo = sexo;
            Endereco = endereco;
            NumeroResidencia = numeroResidencia;
            Municipio = municipio;
            Bairro = bairro;
            Cep = cep;
            Telefone = telefone;
            Estado = estado;
            DataNascimento = dataNascimento;
            Cpf = cpf;
            Beneficios = beneficios;
            Cidade = cidade;
        }

        public Cliente()
        {

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
                        command.CommandText = "Ins_WindowsForms_Cadastro_Cliente";
                        try
                        {
                            command.Parameters.AddWithValue("@Email", Email);
                            command.Parameters.AddWithValue("@Senha", Senha);
                            command.Parameters.AddWithValue("@Nome", Nome);
                            command.Parameters.AddWithValue("@EstadoCivil", EstadoCivil);
                            command.Parameters.AddWithValue("@DataNascimento", DataNascimento);
                            command.Parameters.AddWithValue("@Rg", Rg);
                            command.Parameters.AddWithValue("@Cpf", Cpf);
                            command.Parameters.AddWithValue("@Sexo", Sexo);
                            command.Parameters.AddWithValue("@Endereco", Endereco);
                            command.Parameters.AddWithValue("@NumeroResidencia", NumeroResidencia);
                            command.Parameters.AddWithValue("@Estado", Estado);
                            command.Parameters.AddWithValue("@Municipio", Municipio);
                            command.Parameters.AddWithValue("@Bairro", Bairro);
                            command.Parameters.AddWithValue("@Cep", Cep);
                            command.Parameters.AddWithValue("@Telefone", Telefone);
                            command.Parameters.AddWithValue("@Beneficios", Beneficios);
                            command.Parameters.AddWithValue("@Cidade", Cidade);


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
    }
}
