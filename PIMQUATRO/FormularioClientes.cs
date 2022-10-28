using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PIMQUATRO
{
    public partial class FormularioClientes : Form
    {
        private Form frmAtivo;

        Thread t1;

        private void FormShow(Form frm)
        {
            ActiveForm.Close();
            frmAtivo = frm;
            frm.TopLevel = false;
            frm.BringToFront();
            frm.Show();

        }

      
        private void ActiveFormClose()
        {
            if (frmAtivo != null)
                frmAtivo.Close();

        }
        public FormularioClientes()
        {
            InitializeComponent();
            RetornaDataGridCliente();

        }

        private void Voltar_Click(object sender, EventArgs e)
        {

            this.Close();
            t1 = new Thread(abrirJanela);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();


           
        }

        private void abrirJanela(object obj)
        {
            Application.Run(new FormularioMenu());
        }

        private void BtnCadastrarCliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormularioCadastroClientes().ShowDialog();
        }

        public void RetornaDataGridCliente()
        {

            DataTable dt = new DataTable();
            SqlConnection Conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ToString());
            Conn.Open();
            SqlCommand cmd = new SqlCommand("Qry_WindowsForms_Cadastro_Cliente_RetornaCliente", Conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridViewCliente.DataSource = dt;
        }

        private void FormularioClientes_Load(object sender, EventArgs e)
        {

        }
    }
}

