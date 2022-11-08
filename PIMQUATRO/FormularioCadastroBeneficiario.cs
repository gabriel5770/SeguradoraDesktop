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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace PIMQUATRO
{
    public partial class FormularioCadastroBeneficiario : Form
    {
        public FormularioCadastroBeneficiario()
        {
            InitializeComponent();
        }


        private void CadastroBeneficiario_Load(object sender, EventArgs e)
        {
            PreencheComboCadastroBeneficiario();
        }

        private void btnCadastrarBeneficiario_Click(object sender, EventArgs e)
        {
            ObtemDadosBeneficiario();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormularioCadastroClientes().ShowDialog();
        }


        private bool ValidaCampos()
        {
            if (txtEmailBeneficiario.Text == " " || txtNomeBeneficiario.Text == "" || cmbEstadoCivilBeneficiario.Text == "" ||
                txtNumeroResidenciaBeneficiario.Text == "" || maskedTextRgBeneficiario.Text == "" || maskedTextCpfBeneficiario.Text == "" ||
                cmbSexoBeneficiario.Text == "" || txtEnderecoBeneficiario.Text == "" || txtCidadeBeneficiario.Text == "" || cmbEstadoBeneficiario.Text == "" ||
                txtMunicipioBeneficiario.Text == "" || txtBairroBeneficiario.Text == "" || maskedTextCepBeneficiario.Text == "" || maskedTelefoneBeneficiario.Text == ""
                || txtCpfCliente.Text == "")
            {
                MessageBox.Show("Há campos que não foram preenchidos , revise");
                return false;
            }
            return true;
        }


        private void PreencheComboCadastroBeneficiario()
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

        private void ObtemDadosBeneficiario()
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
            string Telefone = maskedTelefoneBeneficiario.Text;
            string CpfCliente = txtCpfCliente.Text;


            if (ValidaCampos())
            {
                Beneficiario beneficiario = new Beneficiario(Email, Nome, EstadoCivil, DataNascimento, NumeroResidencia, Rg, Cpf, Sexo, Endereco, Cidade, Estado, Municipio, Bairro, Cep, Telefone, CpfCliente);
                if (beneficiario.Cadastrar())
                {
                    MessageBox.Show("Beneficiario cadastrado com sucesso");
                    this.Hide();
                    new FormularioCadastroClientes().ShowDialog();
                }
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (maskedTextCpfBeneficiario.Text == "")
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

        private bool RetornaPesquisaCpf()
        {
            bool rtnValido = false;
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ToString()))
            {
                connection.Open();

                using (var command = new SqlCommand(
                                    $"select * from tbBeneficiario inner join tbclientes on tbclientes.idbeneficiario " +
                                    $"= tbbeneficiario.id where tbbeneficiario.cpf = '{maskedTextCpfBeneficiario.Text}'", connection))

                    try
                    {
                         SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            txtNomeBeneficiario.Text = reader.GetString(1);
                            maskedTextCpfBeneficiario.Text = reader.GetString(2);
                            maskedTextRgBeneficiario.Text = reader.GetString(3);
                            dateTimePickerBeneficiario.Text = reader.GetDateTime(4).ToString();
                            cmbSexoBeneficiario.Text = reader.GetString(5);
                            cmbEstadoCivilBeneficiario.Text = reader.GetString(6);
                            txtEmailBeneficiario.Text = reader.GetString(7);
                            txtEnderecoBeneficiario.Text = reader.GetString(8);
                            txtNumeroResidenciaBeneficiario.Text = reader.GetString(9);
                            cmbEstadoBeneficiario.Text = reader.GetString(10);
                            txtMunicipioBeneficiario.Text = reader.GetString(11);
                            txtBairroBeneficiario.Text = reader.GetString(12);
                            txtCidadeBeneficiario.Text = reader.GetString(13);
                            maskedTextCepBeneficiario.Text = reader.GetString(14);
                            maskedTelefoneBeneficiario.Text = reader.GetString(15);
                            txtCpfCliente.Text = reader.GetString(19);



                            rtnValido = true;
                            return rtnValido;
                        }

                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Erro ao buscar beneficiário");
                        MessageBox.Show("Erro encontrado: " + ex);

                    }
                return rtnValido;
            }
        }

        private void btnExcluirBeneficiario_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Deseja excluir o cadastro?", "ATENÇÃO", MessageBoxButtons.YesNo);
            if (DialogResult == DialogResult.Yes)
            {
                if (Beneficiario.ExcluiCadastro(maskedTextCpfBeneficiario.Text))
                {
                    MessageBox.Show("Cadastro excluido com sucesso");
                    this.Hide();
                    new FormularioCadastroBeneficiario().ShowDialog();

                }
                else
                {
                    MessageBox.Show("Não foi possível excluir o cadastro");
                }
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
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
            string Telefone = maskedTelefoneBeneficiario.Text;
            string CpfCliente = txtCpfCliente.Text;




            DialogResult = MessageBox.Show("Deseja atualizar o cadastro?", "ATENÇÃO", MessageBoxButtons.YesNo);
            if (DialogResult == DialogResult.Yes)
            {
                Beneficiario beneficiaro = new Beneficiario(Email,Nome, EstadoCivil, DataNascimento, NumeroResidencia, Rg, Cpf, Sexo, Endereco, Cidade, Estado, Municipio, Bairro, Cep, Telefone, CpfCliente);
                 if (beneficiaro.AtualizaCadastroBeneficiario(Cpf))
                {
                    MessageBox.Show("Cadastro atualizado com sucesso");
                }
                else
                {
                    MessageBox.Show("Não foi possíevl atualizar o cadastro");
                }
            }
        }
    }
}
