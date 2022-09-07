using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
