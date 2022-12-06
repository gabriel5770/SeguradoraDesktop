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
    internal class Contato
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Mensagem{ get; set; }

        public Contato() { }

        public Contato(string nome, string email, string telefone, string mensagem)
        {
            Nome = nome;
            Email = email;
            Telefone = telefone;
            Mensagem = mensagem;
        }

        public static DataTable ConsultarContato()
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ToString()))
            {

                SqlDataAdapter da = new SqlDataAdapter("Select * from tbContato", con); // pega os dados da tabala funcionario

                DataSet ds = new DataSet(); // cria dataset

                da.Fill(ds); // preenche o dataset com os dados do banco

                return ds.Tables[0]; // retorna a primeira tabela do banco   
            }

        }



        public bool ExcluirContato(int id)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ToString()))
            {
                try
                {
                    string sql = " DELETE  FROM  [tbContato] where id= @id";

                    SqlCommand comando = new SqlCommand(sql, con); // realiza o comando no banco

                    comando.Parameters.AddWithValue("@id", id); // adiciono o id passado no metodo 



                    con.Open(); // abre o banco

                    comando.ExecuteNonQuery();

                    con.Close();
                    return true;
                }
                catch (Exception ex)
                {
                    string msg = ex.Message;
                    return false;
                }



            }

        }
    }
}

