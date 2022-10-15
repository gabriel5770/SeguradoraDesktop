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
            string EstadoCivil = cmbEstadoCivil.Text;
            DateTime DataNascimento = Convert.ToDateTime(txtDataNascimentoBeneficiario.Text);
            string NumeroResidencia = txtNumeroResidenciaBeneficiario.Text;
            string Rg = txtRgBeneficiario.Text;
            string Cpf = txtCepBeneficiario.Text;
            string Sexo = cmbSexo.Text;
            string Endereco = txtEnderecoBeneficiario.Text;
            string Cidade = txtCidadeBeneficiario.Text;
            string Estado = cmbEstado.Text;
            string Municipio = txtMunicipioBeneficiario.Text;
            string Bairro = txtBairroBeneficiario.Text;
            string Cep = txtCepBeneficiario.Text;
            string Telefone = txtTelefoneBeneficiario.Text;
            string CpfCliente = txtCpfCliente.Text;



            Beneficiario beneficiario = new Beneficiario(Email,Nome,EstadoCivil,DataNascimento,NumeroResidencia,Rg,Cpf,Sexo,Endereco,Cidade,Estado,Municipio,Bairro,Cep,Telefone,CpfCliente);
            if (beneficiario.Cadastrar())
            {
                MessageBox.Show("Beneficiario cadastrado com sucesso");
                this.Hide();
                new cadastroclientes().ShowDialog();
            }
            else
            MessageBox.Show("Não foi possível cadastrar o Beneficiario");

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

        private void CadastroBeneficiario_Load(object sender, EventArgs e)
        {
            cmbEstadoCivil.Items.Add("Solteiro");
            cmbEstadoCivil.Items.Add("Casado");
            cmbEstadoCivil.Items.Add("Viúvo");

            cmbSexo.Items.Add("Masculino");
            cmbSexo.Items.Add("Feminino");

            cmbEstado.Items.Add("SP");
            cmbEstado.Items.Add("RJ");
            cmbEstado.Items.Add("MG");

        }
    }
}
