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
            new inicio().ShowDialog();
        }

        private void PageLogin_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string Email = txtEmail.Text;
            string Senha = txtSenha.Text;


            var queryString = $"SELECT TOP(1) * FROM tbLogin WITH(NOLOCK) WHERE Email = '{Email}' AND SENHA ='{Senha}'";

            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ToString()))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();

                try
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                        this.Hide();
                        new menu().ShowDialog();
                        }                       
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("erro: " + ex);
                }
            }
        }
    }

}