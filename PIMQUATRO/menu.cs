using PIMQUATRO.Modelo;
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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }


        private void Clientes_Click(object sender, EventArgs e)
        {
            this.Hide();
            new clientes().ShowDialog();
        }

        private void Funcionarios_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FuncionarioForm().ShowDialog();
        }

        private void Seguradoras_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormularioSeguradora().ShowDialog();
        }

        private void Vendas_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Vendas().ShowDialog();
        }

        private void Duvidas_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Duvidas().ShowDialog();
        }

        private void btnCadastrarBeneficiario_Click(object sender, EventArgs e)
        {
            this.Hide();
            new CadastroBeneficiario().ShowDialog();
        }
    }
}
