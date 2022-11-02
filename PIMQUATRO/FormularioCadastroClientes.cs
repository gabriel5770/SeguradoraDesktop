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
    public partial class FormularioCadastroClientes : Form
    {
        public FormularioCadastroClientes()
        {
            InitializeComponent();
        }

        private void Voltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormularioClientes().ShowDialog();
        }



        private void cadastroclientes_Load(object sender, EventArgs e)
        {
            cmbBeneficiosCliente.Items.Add("Morte");
            cmbBeneficiosCliente.Items.Add("Invalidez");
            cmbBeneficiosCliente.Items.Add("Doenças Graves");

            cmbEstadoCivil.Items.Add("Solteiro");
            cmbEstadoCivil.Items.Add("Casado");
            cmbEstadoCivil.Items.Add("Viúvo");

            cmbSexoCliente.Items.Add("Masculino");
            cmbSexoCliente.Items.Add("Feminino");

            cmbEstado.Items.Add("SP");
            cmbEstado.Items.Add("RJ");
            cmbEstado.Items.Add("MG");


        }

        private void btnCadastrarCliente_Click_1(object sender, EventArgs e)
        {
            string Email = txtEmaiCliente.Text;
            string Senha = textSenhaCliente.Text;
            string Nome = txtNomeCliente.Text;
            string EstadoCivil = cmbEstadoCivil.Text;
            DateTime DataNascimento = Convert.ToDateTime(dateTimePickerCliente.Text);
            string NumeroResidencia = txtNumeroResidenciaCliente.Text;
            string Rg = maskedTextRgCliente.Text;
            string Cpf = maskedTextClienteCpf.Text;
            string Sexo = cmbSexoCliente.Text;
            string Endereco = txtEnderecoCliente.Text;
            string Numero = txtNumeroResidenciaCliente.Text;
            string Cidade = TxtCidade.Text;
            string Estado = cmbEstado.Text;
            string Municipio = txtMunicipioCliente.Text;
            string Bairro = txtBairroCliente.Text;
            string Cep = maskedTextCepCliente.Text;
            string Telefone = txtTelefoneCliente.Text;
            string beneficios = cmbBeneficiosCliente.Text;


            Cliente cliente = new Cliente(Email, Senha, Nome, EstadoCivil, Rg, Sexo, Endereco, NumeroResidencia, Municipio, Bairro, Cep, Telefone, Estado, DataNascimento, Cpf, beneficios, Cidade);
            if (cliente.Cadastrar())
            {
                MessageBox.Show("Cliente cadastrado com sucesso");
                this.Hide();
                new FormularioCadastroClientes().ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormularioCadastroBeneficiario().ShowDialog();
        }
    }
}






