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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace PIMQUATRO
{
    public partial class CadastroFuncionarios : Form
    {
        private void CadastroFuncionarios_Load(object sender, EventArgs e)
        {

        }
        public CadastroFuncionarios()
        {
            InitializeComponent();
        }

        private void Voltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            new menu().ShowDialog();
        }
        private void label15_Click(object sender, EventArgs e)
        {

        }



        private void btnCadastrarFuncionario_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ToString()))
            {
                using (var command = new SqlCommand
                {
                    Connection = connection,
                    CommandType = CommandType.StoredProcedure
                })
                {
                    command.CommandText = "Ins_WindowsForms_Cadastro_Funcionario";
                    try
                    {
                        command.Parameters.AddWithValue("@Email", lblEmailFunc.Text);
                        command.Parameters.AddWithValue("@Senha", lblSenhaFunc.Text);
                        command.Parameters.AddWithValue("@Nome", lblNomeFunc.Text);
                        command.Parameters.AddWithValue("@EstadoCivil", lblEstadoCivilfunc.Text);
                        command.Parameters.AddWithValue("@DataNascimento", lblDataNascimentofunc.Text);
                        command.Parameters.AddWithValue("@Rg", lblRGfunc.Text);
                        command.Parameters.AddWithValue("@Cpf", lblCpfFunc.Text);
                        command.Parameters.AddWithValue("@Sexo", lblSexoFunc.Text);
                        command.Parameters.AddWithValue("@Endereco", lblEnderecoFunc.Text);
                        command.Parameters.AddWithValue("@NumeroResidencia", lblNumeroFunc.Text);
                        command.Parameters.AddWithValue("@Estado", lblEstadoFunc.Text);
                        command.Parameters.AddWithValue("@Municipio", lblMunicipioFunc.Text);
                        command.Parameters.AddWithValue("@Bairro", lblBairroFunc.Text);
                        command.Parameters.AddWithValue("@Cep", lblCepFunc.Text);
                        command.Parameters.AddWithValue("@Telefone", lblTelefoneFunc.Text);

                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("erro: " + ex);
                    }
                }
            }
        }

    }
}


