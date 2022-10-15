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
        public string Nome { get; set; }
        public string Cnpj { get; set; }

        public Seguradora(string nome, string cnpj)
        {
            Nome = nome;
            Cnpj = cnpj;
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
                            command.Parameters.AddWithValue("@Nome", Nome);
                            command.Parameters.AddWithValue("@Cnpj", Cnpj);

                            connection.Open();
                            command.ExecuteNonQuery();

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
