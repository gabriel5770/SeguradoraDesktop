using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

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

        public  bool SalvarVendas()
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ToString()))
            {
                //comando para ser usado no banco
                string sql = "INSERT INTO [tbVendas] (Nome, Email, DataNascimento, Sexo, Telefone, Sexo, Cpf, Seguro) VALUES (@Nome, @Email, @DataNascimento, @Sexo, @Telefone, @Sexo, @Cpf, @Seguro)";



                try
                {
                  
                    SqlCommand comando = new SqlCommand(sql, con);

                    comando.Parameters.AddWithValue("@Nome", Nome);
                    comando.Parameters.AddWithValue("@Email", Email);
                    comando.Parameters.AddWithValue("@DataNascimento", Nascimento);
                    comando.Parameters.AddWithValue("@Sexo",Sexo);
                    comando.Parameters.AddWithValue("@Telefone", Telefone);
                    comando.Parameters.AddWithValue("@Cpf", Cpf);
                    comando.Parameters.AddWithValue("@Seguro", Seguro); 

                    con.Open(); // abre o banco

                    if (comando.ExecuteNonQuery() > 0)// ele retorna um inteiro equivalente ao numero de linhas que foi afetada
                    {
                        con.Close(); // fecha
                        return true;

                    }
                    else
                    {
                        con.Close(); // fecha
                        return false;
                    }
                }
                catch (Exception ex) 
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }

            }

        }
     
        public  bool AtualizarVendas()
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ToString()))
            {

                //comando para ser usado no banco
                string sql = " UPDATE [Vendas] SET Nome = @Nome,Email= @Email,Salario = @Salario, Sexo = @Sexo,TipoContrato = @TipoContrato," +
                "DataAtualizacao = @DataAtualizacao WHERE iD = @id";

                SqlCommand comando = new SqlCommand(sql, con); // passa o comando ao banco e a string de conexão

                comando.Parameters.AddWithValue("@Nome", Nome);
                comando.Parameters.AddWithValue("@Email", Email);
                comando.Parameters.AddWithValue("@DataNascimento", Nascimento);
                comando.Parameters.AddWithValue("@Sexo", Sexo);
                comando.Parameters.AddWithValue("@Telefone", Telefone);
                comando.Parameters.AddWithValue("@Cpf", Cpf);
                comando.Parameters.AddWithValue("@Seguro", Seguro);

                con.Open(); // abre o banco

                if (comando.ExecuteNonQuery() > 0)// ele retorna um inteiro equivalente ao numero de linhas que foi afetada ,'
                {
                    con.Close(); // fecha
                    return true;

                }
                else
                {
                    con.Close(); // fecha
                    return false;
                }
            }

        }
        public static bool ExcluirFuncionario(int id)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ToString()))
            {
                string sql = " DELETE FROM  [Vendas] where Id= @id"; // dou um select no banco de dados e retorno os dados do id que foi passado

                SqlCommand comando = new SqlCommand(sql, con); // realiza o comando no banco

                comando.Parameters.Add("@id", (SqlDbType)id); // adiciono o id passado no metodo 



                con.Open(); // abre o banco

                if (comando.ExecuteNonQuery() > 0)// ele retorna um inteiro equivalente ao numero de linhas que foi afetada
                {
                    con.Close(); // fecha
                    return true;

                }
                else
                {
                    con.Close(); // fecha
                    return false;
                }

            }

        }
    }
}
