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
    public partial class cadastroclientes : Form
    {
        public cadastroclientes()
        {
            InitializeComponent();
        }

        private void Voltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            new clientes().ShowDialog();
        }



        private void cadastroclientes_Load(object sender, EventArgs e)
        {
            cmbBeneficiosCliente.Items.Add("Morte");
            cmbBeneficiosCliente.Items.Add("Invalidez");
            cmbBeneficiosCliente.Items.Add("Doenças Graves");
 
        }

        private void btnCadastrarCliente_Click_1(object sender, EventArgs e)
        {
            string Email = txtEmaiCliente.Text;
            string Nome = txtNomeCliente.Text;
            string EstadoCivil = txtEstadoCivilCliente.Text;
            DateTime DataNascimento = Convert.ToDateTime(txtDataNascimentoCliente.Text);
            string NumeroResidencia = txtNumeroResidenciaCliente.Text;
            string Rg = txtRgCliente.Text;
            string Cpf = txtCepCliente.Text;
            string Sexo = txtSexoCliente.Text;
            string Endereco = txtEnderecoCliente.Text;
            string Numero = txtNumeroResidenciaCliente.Text;
            string Cidade = txtCidade.Text;
            string Estado = txtEstadoCivilCliente.Text;
            string Municipio = txtMunicipioCliente.Text;
            string Bairro = txtBairroCliente.Text;
            string Cep = txtCepCliente.Text;
            string Telefone = txtTelefoneCliente.Text;
            string idBeneficiario = cmbBeneficiosCliente.Text;

             
           

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string Email = txtEmaiCliente.Text;
            string Nome = txtNomeCliente.Text;
            string EstadoCivil = txtEstadoCivilCliente.Text;
            DateTime DataNascimento = Convert.ToDateTime(txtDataNascimentoCliente.Text);
            string NumeroResidencia = txtNumeroResidenciaCliente.Text;
            string Rg = txtRgCliente.Text;
            string Cpf = txtCepCliente.Text;
            string Sexo = txtSexoCliente.Text;
            string Endereco = txtEnderecoCliente.Text;
            string Numero = txtNumeroResidenciaCliente.Text;
            string Cidade = txtCidade.Text;
            string Estado = txtEstadoCivilCliente.Text;
            string Municipio = txtMunicipioCliente.Text;
            string Bairro = txtBairroCliente.Text;
            string Cep = txtCepCliente.Text;
            string Telefone = txtTelefoneCliente.Text;
            string beneficios = cmbBeneficiosCliente.Text;


            Cliente cliente = new Cliente(Email, Nome, EstadoCivil, Rg, Sexo, Endereco, NumeroResidencia, Municipio, Bairro, Cep, Telefone, Estado, DataNascimento, Cpf, Cidade);

            this.Hide();
            new CadastroBeneficiario().ShowDialog();
        }
    }
}






