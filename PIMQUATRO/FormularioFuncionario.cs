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
    public partial class FormularioFuncionario : Form
    {
        private void Funcionario_Load(object sender, EventArgs e)
        {

        }
        public FormularioFuncionario()
        {
            InitializeComponent();
         }

        private void Voltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormularioMenu().ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormularioCadastroFuncionarios().ShowDialog();
        }
 
        private void FormularioFuncionario_Load(object sender, EventArgs e)
        {

        }

    }
}
