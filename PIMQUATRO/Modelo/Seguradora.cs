using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace PIMQUATRO.Modelo
{
    public class Seguradora
    {
        private string _nome { get; set; }
        private string _cnpj { get; set; }

        public Seguradora(string cnpj, string nome = "")
        {
            _nome = nome;
            _cnpj = cnpj;
        }

        public Seguradora()
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
                        command.CommandText = "Ins_WindowsForms_Cadastro_Seguradora";
                        try
                        {
                            command.Parameters.AddWithValue("@Nome", _nome);
                            command.Parameters.AddWithValue("@Cnpj", _cnpj);

                          var returnParameter = command.Parameters.Add("@CadastroValido", SqlDbType.Int);
                            returnParameter.Direction = ParameterDirection.ReturnValue;

                            connection.Open();
                            command.ExecuteNonQuery();

                            var result = (int)returnParameter.Value;

                            if (result == 1)
                            {
                                MessageBox.Show("Há um cadastro com este CNPJ!");
                                return false;

                            }
                            return true;

                        }
                        catch (SqlException ex)
                        {
                            MessageBox.Show("Erro ao cadastrar seguradora");
                            MessageBox.Show("Erro encontrado: " + ex);
                            return false;
                        }
                    }
                }
            }
        }
    }
}
