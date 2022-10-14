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
    internal class Beneficiario : Cadastrar
    {
        public Beneficiario(string email, string nome, string estadoCivil, string rg, string sexo, string endereco, string numeroResidencia, string municipio, string bairro,
            string cep, string telefone, string estado, DateTime dataNascimento, string cpf, string cidade) : base
         (email, nome, estadoCivil, rg, sexo, endereco, numeroResidencia, municipio, bairro, cep, telefone, estado, dataNascimento, cpf, cidade)
        {

        }

        public Beneficiario()
        {

        }

        public override int Cadastro()
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ToString()))
            {
                using (var command = new SqlCommand
                {
                    Connection = connection,
                    CommandType = CommandType.StoredProcedure
                })
                {
                    command.CommandText = "Ins_WindowsForms_Cadastro_Beneficiario";
                    try
                    {
                        command.Parameters.AddWithValue("@Email", Email);
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
                        command.Parameters.AddWithValue("@Cidade", Cidade);

                        SqlParameter parametroRetorno = command.Parameters.Add("@idBeneficiario", SqlDbType.Int);
                        parametroRetorno.Direction = ParameterDirection.ReturnValue;


                        connection.Open();
                        command.ExecuteNonQuery();


                        return Convert.ToInt32(parametroRetorno);

                    }
                    catch (SqlException ex)
                    {

                        MessageBox.Show("Erro ao cadastrar Cliente");
                        MessageBox.Show("Erro encontrado: " + ex);
                        return -1; // corrigir
                    }

                }
            }

        }
    }
}
