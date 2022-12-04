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

        private void btnExcluirCliente_Click(object sender, EventArgs e)
        {
            ExcluiCadastroSeguradora();
        }

        private void btnEditarCliente_Click(object sender, EventArgs e)
        {

        }



        private void ExcluiCadastroSeguradora()
        {
            string NomeSeguradora = txtNomeSeguradora.Text.Trim();
            string CnpjSeguradora = txtCnpjSeguradora.Text.Trim();

            Seguradora seg = new Seguradora(CnpjSeguradora, NomeSeguradora);

            DialogResult = MessageBox.Show("Deseja excluir o cadastro?", "ATENÇÃO", MessageBoxButtons.YesNo);
            if (DialogResult == DialogResult.Yes)
            {
                if (ValidaCampos())
                {
                    if (seg.ExcluiCadastroSeguradora())
                    {
                        MessageBox.Show("Seguradora excluída com sucessso");
                    }
                }
            }
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

