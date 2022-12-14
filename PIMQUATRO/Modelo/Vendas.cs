using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.ComponentModel.DataAnnotations;

namespace PIMQUATRO.Modelo
{
    public class Vendas
    {
      
        public string Nome { get; set; }
       
        public DateTime Nascimento { get; set; } 
   
        public string Email { get; set; }
      
        public string Telefone { get; set; }
       
        public string Cpf { get; set; }
       
        public string Sexo { get; set; }
       
        public string Seguro { get; set; }

        public Vendas() { }
        public Vendas(string nome, DateTime nascimento, string email, string telefone, string cpf, string sexo, string seguro)
        {
            Nome = nome;
            Nascimento = nascimento;
            Email = email;
            Telefone = telefone;
            Cpf = cpf;
            Sexo = sexo;
            Seguro = seguro;
        }

      
        public static DataTable ConsultarVendas()
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ToString()))
            {

                SqlDataAdapter da = new SqlDataAdapter("Select * from tbVenda", con); // pega os dados da tabala funcionario

                DataSet ds = new DataSet(); // cria dataset

                da.Fill(ds); // preenche o dataset com os dados do banco

                return ds.Tables[0]; // retorna a primeira tabela do banco   
            }

        }

     
   
        public bool ExcluirVendas(int id)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ToString()))
            {
                try
                {
                    string sql = " DELETE  FROM  [tbVenda] where id= @id";

                    SqlCommand comando = new SqlCommand(sql, con); // realiza o comando no banco

                    comando.Parameters.AddWithValue("@id", id); // adiciono o id passado no metodo 



                    con.Open(); // abre o banco

                    comando.ExecuteNonQuery();

                    con.Close();
                    return true;
                }
                catch(Exception ex) 
                {
                    string msg = ex.Message;
                    return false;
                }
             
              

            }

        }
    }
}
