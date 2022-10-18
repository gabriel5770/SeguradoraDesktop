using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIMQUATRO
{
    public partial class PageLogin : Form
    {
        public PageLogin()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Voltar_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            new FormularioInicio().ShowDialog();
        }

        private void PageLogin_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //recebe os valores dos textbox
            //textbox do email
            string Email = txtEmail.Text;
            //textbox da senha
            string Senha = txtSenha.Text;

            //Consulta a tabela de Login para ver se há registros de login

            var queryString = $"SELECT TOP(1) * FROM tbLogin WITH(NOLOCK) WHERE Email = '{Email}' AND SENHA ='{Senha}'";

            //Inicia string de conexão do banco de dados
            //obs.: A string "conn" é o nome que está no arquivo no app.config
            //lá está o caminho em que o código "puxa" os dados do banco SQL
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ToString()))
            {
                //Instancia o objeto sqlCommand , para obter os métodos de conexões com o sql
                //Da uma pesquisada sobre string de conexão
                SqlCommand command = new SqlCommand(queryString, connection);

                //Abre conexão com o banco de dados
                connection.Open();

                try
                {
                    //executeReader é o objeto que lê os resultados da consulta sql
                    //SELECT TOP(1) * FROM tbLogin WITH(NOLOCK) WHERE Email = '{Email}' AND SENHA ='{Senha}'


                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        //caso a consulta retorne linha (quer dizer que tem registro no banco de dados e pode acessar o sistema),
                        //ai ele fecha a página de login e avança para a página de menu
                        if (reader.HasRows)
                        {
                        this.Hide();
                        new FormularioMenu().ShowDialog();
                        }
                        else
                        {
                            lblDadosIncorretos.Visible = true;
                            lblDadosIncorretos.Text = "Dados incorretos";
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("erro: " + ex);
                }
            }
        }
        //Coisas para pesquisar para o entendimento:
        //string de conexão , consulta sql via c#, try catch , objeto SqlCommand;
    }

}