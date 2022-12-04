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
        [Required] //torna o campo nome obrigatorio
        [StringLength(70, MinimumLength = 5)] // atribui um caracter maximo e um caracter minimo
        public string Nome { get; set; }
        [Required]
        public DateTime Nascimento { get; set; } 
        [Required, EmailAddress, StringLength(70, MinimumLength = 5)] // validação
        public string Email { get; set; }
        [Required]
        public string Telefone { get; set; }
        [Required]
        public string Cpf { get; set; }
        [Required]
        public string Sexo { get; set; }
        [Required]
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

                    comando.Parameters.AddWithValue("@Nome", Nome.Trim());
                    comando.Parameters.AddWithValue("@Email", Email.Trim());
                    comando.Parameters.AddWithValue("@DataNascimento", Nascimento);
                    comando.Parameters.AddWithValue("@Sexo",Sexo.Trim());
                    comando.Parameters.AddWithValue("@Telefone", Telefone.Trim());
                    comando.Parameters.AddWithValue("@Cpf", Cpf.Trim());
                    comando.Parameters.AddWithValue("@Seguro", Seguro.Trim()); 

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
