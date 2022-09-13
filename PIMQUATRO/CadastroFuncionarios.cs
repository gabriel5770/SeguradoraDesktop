using PIMQUATRO.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace PIMQUATRO
{
    public partial class CadastroFuncionarios : Form
    {
        private void CadastroFuncionarios_Load(object sender, EventArgs e)
        {

        }
        public CadastroFuncionarios()
        {
            InitializeComponent();
        }

        private void Voltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            new menu().ShowDialog();
        }
        private void label15_Click(object sender, EventArgs e)
        {

        }

        public int MyProperty { get; set; }

        private void btnCadastrarFuncionario_Click(object sender, EventArgs e)
        {
            string Email = lblEmailFunc.Text;
            string Senha = lblSenhaFunc.Text;
            string Nome = lblNomeFunc.Text;
            string EstadoCivil = lblEstadoCivilfunc.Text;
            string DataNascimento = lblDataNascimentofunc.Text;
            string Rg = lblRGfunc.Text;
            string Cpf = lblCpfFunc.Text;
            string Sexo = lblSexoFunc.Text;
            string Endereco = lblEnderecoFunc.Text;
            string NumResidencia = lblNumeroFunc.Text;
            string Estado = lblEstadoFunc.Text;
            string Municipio = lblMunicipioFunc.Text;
            string Bairro = lblBairroFunc.Text;
            string Cep = lblCepFunc.Text;
            string Telefone = lblTelefoneFunc.Text;



            if (new Cadastro().EfetuaCadastro(Email,Senha,Nome,EstadoCivil,DataNascimento,Rg,Cpf,Sexo,Endereco,NumResidencia,Estado,Municipio,Bairro,Cep,Telefone))
            {
                this.Hide();
                new menu().ShowDialog();
                MessageBox.Show("Funcionário cadastrado com sucesso");
            }
        }
    }
}


