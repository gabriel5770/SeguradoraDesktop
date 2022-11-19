using iText.Kernel.Pdf.Canvas.Wmf;
using iText.StyledXmlParser.Jsoup.Nodes;
using Microsoft.Reporting.Map.WebForms.BingMaps;
using PIMQUATRO.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace PIMQUATRO
{
    public partial class FormularioCadastroClientes : Form
    {
        public FormularioCadastroClientes()
        {
            InitializeComponent();
        }

        private void cadastroclientes_Load(object sender, EventArgs e)
        {
            PreencheComboCadastroCliente();
            PopulaComboSeguradora();
        }


        private void btnCadastrarCliente_Click_1(object sender, EventArgs e)
        {
            ObtemDadosCliente();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormularioCadastroBeneficiario().ShowDialog();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            PesquisaCadastroCliente();
        }
        private void btnAtualizar_Click_1(object sender, EventArgs e)
        {
           AtualizaCadastroCliennte();
        }

        private void btnExcluirCliente_Click(object sender, EventArgs e)
        {
            ExcluiCadastroCliente();
        }

        private void PopulaComboSeguradora()
        {
            cmbSeguradorasDisponiveis.Items.Add("Porto Seguro");
        }

        private void PreencheComboCadastroCliente()
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

        private bool ValidaCampos()
        {
            if (txtEmaiCliente.Text == "" || textSenhaCliente.Text == "" || txtNomeCliente.Text == ""
                || cmbEstadoCivil.Text == "" || txtNumeroResidenciaCliente.Text == "" || TxtCidade.Text == ""
                || cmbEstado.Text == "" || txtMunicipioCliente.Text == "" || txtBairroCliente.Text == ""
                || maskedTextCepCliente.Text == "" || maskedTelefoneCliente.Text == "" || cmbBeneficiosCliente.Text == "")
            {
                MessageBox.Show("Há campos não preenchidos , revise");
                return false;
            }
            return true;
        }


        private void ObtemDadosCliente()
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
            string Telefone = maskedTelefoneCliente.Text;
            string beneficios = cmbBeneficiosCliente.Text;
            string DataVigenciaInicial = txtDataVigenciaInicial.Text;
            string DataVigenciaFinal = txtDataVigenciaFinal.Text;
            string NomeSeguradora = cmbSeguradorasDisponiveis.Text;


            if (ValidaCampos())
            {
                Cliente cliente = new Cliente(Email, Senha, Nome, EstadoCivil, Rg, Sexo, Endereco, NumeroResidencia, Municipio, Bairro, Cep, Telefone, Estado, DataNascimento, Cpf, beneficios, Cidade, DataVigenciaInicial, DataVigenciaFinal, NomeSeguradora);
                if (ValidaCampos())
                {
                    if (cliente.Cadastrar())
                    {
                        MessageBox.Show("Cliente cadastrado com sucesso");
                        this.Hide();
                        new FormularioCadastroClientes().ShowDialog();
                    }
                }
            }
        }



        private bool RetornaPesquisaCpf()
        {
            bool rtnValido = false;
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ToString()))
            {
                connection.Open();

                using (var command = new SqlCommand(
                                    $"select nome,rg,cpf,sexo,DataNascimento,EstadoCivil,Cidade,Endereco,NumereoResidencia,Bairro," +
                                    $"Municipio,Estado,cep,email,telefone,senha,tbBeneficios.Descricao from tbClientes inner join " +
                                    $"tbBeneficios on tbClientes.idBeneficio = tbBeneficios.Id where cpf = {maskedTextClienteCpf.Text} ", connection))

                    try
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            txtNomeCliente.Text = reader.GetString(0);
                            maskedTextRgCliente.Text = reader.GetString(1);
                            maskedTextClienteCpf.Text = reader.GetString(2);
                            cmbSexoCliente.Text = reader.GetString(3);
                            dateTimePickerCliente.Text = reader.GetDateTime(4).ToString();
                            cmbEstadoCivil.Text = reader.GetString(5);
                            TxtCidade.Text = reader.GetString(6);
                            txtEnderecoCliente.Text = reader.GetString(7);
                            txtNumeroResidenciaCliente.Text = reader.GetString(8);
                            txtBairroCliente.Text = reader.GetString(9);
                            txtMunicipioCliente.Text = reader.GetString(10);
                            cmbEstado.Text = reader.GetString(11);
                            maskedTextCepCliente.Text = reader.GetString(12);
                            txtEmaiCliente.Text = reader.GetString(13);
                            maskedTelefoneCliente.Text = reader.GetString(14);
                            textSenhaCliente.Text = reader.GetString(15);
                            cmbBeneficiosCliente.Text = reader.GetString(16);

                            rtnValido = true;
                            return rtnValido;
                        }

                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Erro ao buscar funcionário");
                        MessageBox.Show("Erro encontrado: " + ex);

                    }
                return rtnValido;
            }
        }

        private bool ExcluiCadastroCliente()
        {
            bool rtnValido = false;
            if (ValidaCampos())
            {
                DialogResult = MessageBox.Show("Deseja excluir o cadastro?", "ATENÇÃO", MessageBoxButtons.YesNo);
                if (DialogResult == DialogResult.Yes)
                {
                    if (Cliente.ExcluiCadastro(maskedTextClienteCpf.Text))
                    {
                        MessageBox.Show("Cadastro excluido com sucesso");
                        this.Hide();
                        new FormularioCadastroFuncionarios().ShowDialog();
                        rtnValido = true;

                    }
                    else
                    {
                        MessageBox.Show("Não foi possível excluir o cadastro");
                    }
                }
            }
            else
            {
                MessageBox.Show("Pesquise o CPF a ser excluido");
            }
            return rtnValido;
        }



        private void AtualizaCadastroCliennte()
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
            string Telefone = maskedTelefoneCliente.Text;
            string Beneficios = cmbBeneficiosCliente.Text;


            if (ValidaCampos())
            {
                DialogResult = MessageBox.Show("Deseja atualizar o cadastro?", "ATENÇÃO", MessageBoxButtons.YesNo);

                if (DialogResult == DialogResult.Yes)
                {
                    Cliente func = new Cliente(Email, Senha, Nome, EstadoCivil, Rg, Sexo, Endereco, NumeroResidencia, Municipio, Bairro, Cep, Telefone, Estado, DataNascimento, Cpf, Beneficios, Cidade);
                    if (func.AtualizaCadastro())
                    {
                        MessageBox.Show("Cadastro atualizado com sucesso");
                    }
                    else
                    {
                        MessageBox.Show("Não foi possíevl atualizar o cadastro");
                    }
                }      
            }
            else
            {
                MessageBox.Show("Pesquise o CPF a ser Atualizado");
            }
        }

        private void PesquisaCadastroCliente()
        {
            if (maskedTextClienteCpf.Text == "")
            {
                MessageBox.Show("Por favor , insira um valor no campo CPF");
            }
            else if (RetornaPesquisaCpf())

            {
                MessageBox.Show("Cadastro encontrado!");
            }
            else
            {
                MessageBox.Show("Não foi possível encontrar cadastro com este CPF");
            }
        }
    }
}







