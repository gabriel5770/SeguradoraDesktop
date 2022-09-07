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
    public partial class Funcionario : Form
    {
        private void Funcionario_Load(object sender, EventArgs e)
        {

        }
        public Funcionario()
        {
            InitializeComponent();
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
    }
}
