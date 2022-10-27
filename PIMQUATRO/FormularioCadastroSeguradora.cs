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
    public partial class FormularioCadastroSeguradora : Form
    {
        public FormularioCadastroSeguradora()
        {
            InitializeComponent();
        }

        private void Voltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormularioMenu().ShowDialog();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string Nome = txtNome.Text;
            string Cnpj = txtCnpj.Text;

            Seguradora seguradora = new Seguradora(Nome, Cnpj);
            if (seguradora.Cadastrar())
            {
                MessageBox.Show("Seguradora cadastrado com sucesso");
                this.Hide();
                new FormularioCadastroSeguradora().ShowDialog();
            }

            MessageBox.Show("Não foi possível cadastrar o Cliente");
        }

    }
}

