﻿using PIMQUATRO.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
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

        private void cadastroclientes_Load(object sender, EventArgs e)
        {
            PreencheComboCadastroCliente();
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

        private  bool  ValidaCampos()
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

        protected void ObtemDadosCliente()  
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

            if (ValidaCampos())
            {
                Cliente cliente = new Cliente(Email, Senha, Nome, EstadoCivil, Rg, Sexo, Endereco, NumeroResidencia, Municipio, Bairro, Cep, Telefone, Estado, DataNascimento, Cpf, beneficios, Cidade);
                if (cliente.Cadastrar())
                {
                    MessageBox.Show("Cliente cadastrado com sucesso");
                    this.Hide();
                    new FormularioCadastroClientes().ShowDialog();
                }
            }            
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (RetornaPesquisaCpf())
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

                using (var command = new SqlCommand($"Select * from tbClientes where cpf = '{maskedTextClienteCpf.Text}'", connection))

                    try
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            txtNomeCliente.Text = reader.GetString(1);
                            maskedTextRgCliente.Text = reader.GetString(2);
                            maskedTextClienteCpf.Text = reader.GetDateTime(3).ToString();
                            cmbSexoCliente.Text = reader.GetString(4);
                            dateTimePickerCliente.Text = reader.GetString(5);
                            cmbEstadoCivil.Text = reader.GetString(6);
                            TxtCidade.Text = reader.GetString(8);
                            txtEnderecoCliente.Text = reader.GetString(9);
                            txtNumeroResidenciaCliente.Text = reader.GetString(10);
                            txtBairroCliente.Text = reader.GetString(11);
                            txtMunicipioCliente.Text = reader.GetString(12);
                            cmbEstado.Text = reader.GetString(13);
                            maskedTextCepCliente.Text = reader.GetString(14);
                         
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

    
    }
}






