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
    public partial class FormularioCadastroBeneficiario : Form
    {
        public FormularioCadastroBeneficiario()
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
            string EstadoCivil = cmbEstadoCivilBeneficiario.Text;
            DateTime DataNascimento = Convert.ToDateTime(dateTimePickerBeneficiario.Text);
            string NumeroResidencia = txtNumeroResidenciaBeneficiario.Text;
            string Rg = maskedTextRgBeneficiario.Text;
            string Cpf = maskedTextCpfBeneficiario.Text;
            string Sexo = cmbSexoBeneficiario.Text;
            string Endereco = txtEnderecoBeneficiario.Text;
            string Cidade = txtCidadeBeneficiario.Text;
            string Estado = cmbEstadoBeneficiario.Text;
            string Municipio = txtMunicipioBeneficiario.Text;
            string Bairro = txtBairroBeneficiario.Text;
            string Cep = maskedTextCepBeneficiario.Text;
            string Telefone = txtTelefoneBeneficiario.Text;
            string CpfCliente = txtCpfCliente.Text;



            Beneficiario beneficiario = new Beneficiario(Email,Nome,EstadoCivil,DataNascimento,NumeroResidencia,Rg,Cpf,Sexo,Endereco,Cidade,Estado,Municipio,Bairro,Cep,Telefone,CpfCliente);
            if (beneficiario.Cadastrar())
            {
                MessageBox.Show("Beneficiario cadastrado com sucesso");
                this.Hide();
                new FormularioCadastroClientes().ShowDialog();
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
            new FormularioCadastroClientes().ShowDialog();
        }

        private void txtNomeBeneficiario_TextChanged(object sender, EventArgs e)
        {

        }

        private void CadastroBeneficiario_Load(object sender, EventArgs e)
        {
            cmbEstadoCivilBeneficiario.Items.Add("Solteiro");
            cmbEstadoCivilBeneficiario.Items.Add("Casado");
            cmbEstadoCivilBeneficiario.Items.Add("Viúvo");

            cmbSexoBeneficiario.Items.Add("Masculino");
            cmbSexoBeneficiario.Items.Add("Feminino");

            cmbEstadoBeneficiario.Items.Add("SP");
            cmbEstadoBeneficiario.Items.Add("RJ");
            cmbEstadoBeneficiario.Items.Add("MG");

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtEmailBeneficiario_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
