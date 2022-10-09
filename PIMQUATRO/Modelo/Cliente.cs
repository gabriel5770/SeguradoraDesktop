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
        public string Cpf { get; set; }

        public Cliente(string email, string nome, string estadoCivil, string rg, string sexo, string endereco, string numeroResidencia, string municipio, string bairro, string cep, string telefone, string estado, DateTime dataNascimento, string cpf)
        {
            Email = email;
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
                            command.Parameters.AddWithValue("@Nome", Nome);
                            command.Parameters.AddWithValue("@EstadoCivil", EstadoCivil);
                            command.Parameters.AddWithValue("@DataNascimento", Convert.ToDateTime(DataNascimento));
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

                            connection.Open();
                            command.ExecuteNonQuery();

                            return true;
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
