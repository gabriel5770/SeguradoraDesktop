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
    public partial class clientes : Form
    {
        public clientes()
        {
            InitializeComponent();
        }

        private void Voltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            new menu().ShowDialog();
        }

        private void BtnCadastrarCliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            new cadastroclientes().ShowDialog();
        }
    }
}
