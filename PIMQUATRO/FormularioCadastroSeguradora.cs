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

        protected void ObtemDadosSeguradora()
        {
            string NomeSeguradora = txtNomeSeguradora.Text;
            string CnpjSeguradora = txtCnpjSeguradora.Text;


            Seguradora seg = new Seguradora(NomeSeguradora, CnpjSeguradora);


            if (seg.Cadastrar())
            {
                MessageBox.Show("Seguradora Cadastrada com sucessso");
                this.Hide();
            }
        }

        private void btnExcluirCliente_Click(object sender, EventArgs e)
        {

        }

        private void btnEditarCliente_Click(object sender, EventArgs e)
        {

        }
    }
}

