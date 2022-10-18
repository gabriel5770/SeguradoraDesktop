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
    public partial class FuncionarioForm : Form
    {
        private void Funcionario_Load(object sender, EventArgs e)
        {

        }
        public FuncionarioForm()
        {
            InitializeComponent();
            RetornaDataGridFuncionario();
        }

        private void Voltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            new menu().ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new CadastroFuncionarios().ShowDialog();
        }
        public void RetornaDataGridFuncionario()
        {

            DataTable dt = new DataTable();
            SqlConnection Conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ToString());
            Conn.Open();
            SqlCommand cmd = new SqlCommand("Qry_WindowsForms_Cadastro_Funcionario_RetornaFuncionarios", Conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridViewFuncionario.DataSource = dt;
        }

    }
}
