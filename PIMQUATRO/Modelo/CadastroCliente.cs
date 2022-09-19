using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIMQUATRO.Modelo
{
    public class CadastroCliente
    {
        protected string Telefone { get; set; }

        public CadastroCliente()
        {
        }

        public static bool CadastroClientes(string email, string senha, string nome, string estadoCivil, string dataNascimento,
                           string rg, string cpf, string sexo, string endereco, string numResidencia, string estado,
                           string municipio, string bairro, string cep, string telefone, string logradouro, string complemento)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ToString()))
            {
                using (var command = new SqlCommand
                {
                    Connection = connection,
                    CommandType = CommandType.StoredProcedure
                })
                {
                    command.CommandText = "Ins_WindowsForms_Cadastro_Clientes";
                    try
                    {
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@Senha", senha);
                        command.Parameters.AddWithValue("@Nome", nome);
                        command.Parameters.AddWithValue("@EstadoCivil", estadoCivil);
                        command.Parameters.AddWithValue("@DataNascimento", dataNascimento);
                        command.Parameters.AddWithValue("@Rg", rg);
                        command.Parameters.AddWithValue("@Cpf", cpf);
                        command.Parameters.AddWithValue("@Sexo", sexo);
                        command.Parameters.AddWithValue("@Endereco", endereco);
                        command.Parameters.AddWithValue("@Logradouro", logradouro);
                        command.Parameters.AddWithValue("@Complemento", complemento);
                        command.Parameters.AddWithValue("@NumeroResidencia", numResidencia);
                        command.Parameters.AddWithValue("@Estado", estado);
                        command.Parameters.AddWithValue("@Municipio", municipio);
                        command.Parameters.AddWithValue("@Bairro", bairro);
                        command.Parameters.AddWithValue("@Cep", cep);
                        command.Parameters.AddWithValue("@Telefone", telefone);

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
