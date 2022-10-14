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
    public partial class CadastroBeneficiario : Form
    {
        public CadastroBeneficiario()
        {
            InitializeComponent();
        }

        private void txtDataNascimentoCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSenhaBeneficiario_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCadastrarBeneficiario_Click(object sender, EventArgs e)
        {
            string Email = txtEmailBeneficiario.Text;
            string Nome = txtNomeBeneficiario.Text;
            string EstadoCivil = txtEstadoCivilBeneficiario.Text;
            DateTime DataNascimento = Convert.ToDateTime(txtDataNascimentoBeneficiario.Text);
            string NumeroResidencia = txtNumeroResidenciaBeneficiario.Text;
            string Rg = txtRgBeneficiario.Text;
            string Cpf = txtCepBeneficiario.Text;
            string Sexo = txtSexoBeneficiario.Text;
            string Endereco = txtEnderecoBeneficiario.Text;
            string Cidade = txtCidadeBeneficiario.Text;
            string Estado = txtEstadoCivilBeneficiario.Text;
            string Municipio = txtMunicipioBeneficiario.Text;
            string Bairro = txtBairroBeneficiario.Text;
            string Cep = txtCepBeneficiario.Text;
            string Telefone = txtTelefoneBeneficiario.Text;


            Beneficiario beneficiario = new Beneficiario(Email, Nome, EstadoCivil, Rg, Sexo, Endereco, NumeroResidencia, Municipio, Bairro, 
                Cep,Telefone, Estado, DataNascimento, Cpf, Cidade);

            if (beneficiario.Cadastro() != -1)
            {
                MessageBox.Show("cadastrado com sucesso");
                this.Hide();
                new cadastroclientes().ShowDialog();
            }
            else
            {
                MessageBox.Show("Não foi possível cadastrar");
            }           

        }

        private void txtEmaiBeneficiario_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new cadastroclientes().ShowDialog();
        }

        private void txtNomeBeneficiario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
