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
    public partial class Beneficiário : Form
    {
        public Beneficiário()
        {
            InitializeComponent();
        }

        private void LblEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void cadastrarBeneficiario_Click(object sender, EventArgs e)
        {
            string Email = LblEmailBeneficiario.Text;
            string Senha = LblSenhaBeneficiario.Text;
            string Nome = LblNomeBeneficiario.Text;
            string EstadoCivil = LblEstadoCivilBeneficiario.Text;
            string DataNascimento = LblDataDeNascimentoBeneficiario.Text;
            string Rg = LblRgBeneficiario.Text;
            string Cpf = LblCpfBeneficiario.Text;
            string Sexo = LblSexoBeneficiario.Text;
            string Endereco = LblEnderecoBeneficiario.Text;
            string NumResidencia = LblNumeroBeneficiario.Text;
            string Estado = LblEstadoBeneficiario.Text;
            string Municipio = LblMunicipioBeneficiario.Text;
            string Bairro = LblBairroBeneficiario.Text;
            string Cep = LblCepBeneficiario.Text;
            string Telefone = LblTelefoneBeneficiario.Text;
            string Logradouro = LblLogradouroBeneficiario.Text;
            string Complemento = LblComplementoBeneficiario.Text;

        }

        private void LblNomebeneficiario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
