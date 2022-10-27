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
    public partial class FormularioSeguradora : Form
    {
        public FormularioSeguradora()
        {
            InitializeComponent();
            RetornaDataGridSeguradoras();
        }

        private void FormularioSeguradora_Load(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormularioMenu().ShowDialog();

        }

        private void btnCadastrarSeguradora_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormularioCadastroSeguradora().ShowDialog();
        }

        public void RetornaDataGridSeguradoras()
        {

            DataTable dt = new DataTable();
            SqlConnection Conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ToString());
            Conn.Open();
            SqlCommand cmd = new SqlCommand("Qry_WindowsForms_Cadastro_Seguradora_RetornaSeguradoras", Conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridViewSeguradora.DataSource = dt;
        }
    }
}
