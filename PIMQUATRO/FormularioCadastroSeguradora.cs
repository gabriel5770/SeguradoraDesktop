using PIMQUATRO.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
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



        private void btnCadastrarCliente_Click(object sender, EventArgs e)
        {
            ObtemDadosSeguradora();
        }

        private void btnEditarCliente_Click(object sender, EventArgs e)
        {

        }


        private void ObtemDadosSeguradora()
        {
            string NomeSeguradora = txtNomeSeguradora.Text.Trim();
            string CnpjSeguradora = txtCnpjSeguradora.Text.Trim();


            Seguradora seg = new Seguradora(CnpjSeguradora, NomeSeguradora);

            if (ValidaCampos())
            {
                if (seg.Cadastrar())
                {
                    MessageBox.Show("Seguradora Cadastrada com sucessso");
                }
            }
        }


        private bool ValidaCampos()
        {
            if (txtNomeSeguradora.Text == "" || txtCnpjSeguradora.Text == "")
            {
                MessageBox.Show("Há campos não preenchidos , revise");
                return false;
            }
            return true;
        }
    }
}

