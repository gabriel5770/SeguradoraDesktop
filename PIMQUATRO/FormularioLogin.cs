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

        private void Voltar_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            new FormularioInicio().ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            string Email = txtEmail.Text;
            string Senha = txtSenha.Text;

            if (VerificaCampoSenha())
            {

                var queryString = $"SELECT TOP(1) * FROM tbLogin WITH(NOLOCK) WHERE Email = '{Email}' AND SENHA ='{Senha}'";

                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ToString()))
                {

                    SqlCommand command = new SqlCommand(queryString, connection);

                    //Abre conexão com o banco de dados
                    connection.Open();
                    command.ExecuteNonQuery();

                    try
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

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
                        connection.Close();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("erro: " + ex);

                    }
                }
            }
        }

        private bool VerificaCampoSenha()
        {
            if (txtEmail.Text == "" || txtSenha.Text == "")
            {
                MessageBox.Show("Há campos que não foram preenchidos , revise");
                return false;
            }
            return true;
        }

        private void PageLogin_Load(object sender, EventArgs e)
        {

        }
    }
}