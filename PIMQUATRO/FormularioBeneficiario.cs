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
    public partial class FormularioBeneficiario : Form
    {
        public FormularioBeneficiario()
        {
            InitializeComponent();
         }

        private void FormularioBeneficiario_Load(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormularioMenu().ShowDialog();

        }

        private void btnCadastrarBeneficiario_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormularioCadastroBeneficiario().ShowDialog();
        }       
    }
}
