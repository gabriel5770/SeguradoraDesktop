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

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void LblEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void LblLogradouroClin_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void cadastroclientes_Load(object sender, EventArgs e)
        {

        }

        private void LblCpfCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void LblSexoCliente_TextChanged(object sender, EventArgs e)
        {

        }
        public int MyProperty { get; set; }
        private void button1_Click(object sender, EventArgs e)
        {
            string Email = LblEmail.Text;
            string Senha = LblSenhaCliente.Text;
            string Nome = LblNomeCliente.Text;
            string EstadoCivil = LblEstadoCivilCliente.Text;
            string DataNascimento = LblDataDeNascimentoCliente.Text;
            string Rg = LblRgCliente.Text;
            string Cpf = LblCpfCliente.Text;
            string Sexo = LblSexoCliente.Text;
            string Endereco = LblEnderecoCliente.Text;
            string NumResidencia = LblNumeroCliente.Text;
            string Estado = LblEstadoCliente.Text;
            string Municipio = LblMunicipioCliente.Text;
            string Bairro = LblBairroCliente.Text;
            string Cep = LblCepCliente.Text;
            string Telefone = LblTelefoneCliente.Text;
            string Logradouro = LblLogradouroCliente.Text;
            string Complemento = LblComplementoCliente.Text;



            if (CadastroCliente.CadastroClientes(Email, Senha, Nome, EstadoCivil, DataNascimento, Rg, Cpf, Sexo, Endereco, NumResidencia, Estado,
                Municipio, Bairro, Cep, Telefone, Logradouro, Complemento))
            {
                this.Hide();
                new menu().ShowDialog();
            }
        }
    }
}
