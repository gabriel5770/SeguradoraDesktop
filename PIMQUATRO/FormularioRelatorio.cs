using PIMQUATRO.Modelo;
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
    public partial class FormularioRelatorio : Form
    {
        public FormularioRelatorio()
        {
            InitializeComponent();
        }

        private void btnGerarApolice_Click(object sender, EventArgs e)
        {
            //if (RetornaPdfApolice())
            //{
            //    MessageBox.Show("Apólice criado com sucesso");
            //};

            Apolice ap = new Apolice();
            ap.GerarPdf();
        }

           
        private bool RetornaPdfApolice()
        {
            string Nome = "";
            string Cpf = "";
            string DataVigenciaInicial = "";
            string DataVigenciaFinal = "";
            string NumeroContrato = "";

            bool rtnValido = false;
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ToString()))
            {
                connection.Open();

                using (var command = new SqlCommand(
                                    $"SELECT tbclientes.nome, tbclientes.cpf, tbapolice.dataVigenciaInicial, tbapolice.dataVigenciaFinal, tbapolice.NumeroContrato  FROM tbapolice inner join tbclientes ON tbapolice.id = tbclientes.idApolice where tbclientes.cpf = {txtCpfCliente.Text}", connection))

                    try
                    {
                         SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            Nome = reader.GetString(0);
                            Cpf = reader.GetString(1);
                            DataVigenciaInicial = Convert.ToString(reader.GetDateTime(2));
                            DataVigenciaFinal = Convert.ToString(reader.GetDateTime(3));
                            NumeroContrato = Convert.ToString(reader.GetInt64(4));


                            rtnValido = true;
                            return rtnValido;
                        }

                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Erro ao gerar apólice");
                        MessageBox.Show("Erro encontrado: " + ex);

                    }
                return rtnValido;
            }
        }

        private void GerarPdf()
        {

        }

    }
}
