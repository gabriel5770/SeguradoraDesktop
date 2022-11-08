﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace PIMQUATRO.Modelo
{
    internal class Beneficiario : Cliente
    {
        public string Email { get; set; }
        public string Nome { get; set; }
        public string EstadoCivil { get; set; }
        public DateTime DataNascimento { get; set; }
        public string NumeroResidencia { get; set; }
        public string Rg { get; set; }
        public string Cpf { get; set; }
        public string Sexo { get; set; }
        public string Endereco { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Municipio { get; set; }
        public string Bairro { get; set; }
        public string Cep { get; set; }
        public string Telefone { get; set; }
        public string CpfCliente { get; set; }

        public Beneficiario(string email, string nome, string estadoCivil, DateTime dataNascimento, string numeroResidencia, string rg, string cpf, string sexo, string endereco, string cidade, string estado, string municipio, string bairro, string cep, string telefone, string cpfCliente)
        {
            Email = email;
            Nome = nome;
            EstadoCivil = estadoCivil;
            DataNascimento = dataNascimento;
            NumeroResidencia = numeroResidencia;
            Rg = rg;
            Cpf = cpf;
            Sexo = sexo;
            Endereco = endereco;
            Cidade = cidade;
            Estado = estado;
            Municipio = municipio;
            Bairro = bairro;
            Cep = cep;
            Telefone = telefone;
            CpfCliente = cpfCliente;
        }

        public Beneficiario()
        {

        }

        public bool Cadastrar()
        {
            bool rtnValido = false;
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ToString()))
            {
                using (var command = new SqlCommand
                {
                    Connection = connection,
                    CommandType = CommandType.StoredProcedure
                })
                {
                    command.CommandText = "Ins_WindowsForms_Cadastro_Beneficiario";
                    try
                    {
                        command.Parameters.AddWithValue("@Email", Email);
                        command.Parameters.AddWithValue("@Nome", Nome);
                        command.Parameters.AddWithValue("@EstadoCivil", EstadoCivil);
                        command.Parameters.AddWithValue("@DataNascimento", DataNascimento);
                        command.Parameters.AddWithValue("@Rg", Rg);
                        command.Parameters.AddWithValue("@Cpf", Cpf);
                        command.Parameters.AddWithValue("@Sexo", Sexo);
                        command.Parameters.AddWithValue("@Endereco", Endereco);
                        command.Parameters.AddWithValue("@NumeroResidencia", NumeroResidencia);
                        command.Parameters.AddWithValue("@Estado", Estado);
                        command.Parameters.AddWithValue("@Municipio", Municipio);
                        command.Parameters.AddWithValue("@Bairro", Bairro);
                        command.Parameters.AddWithValue("@Cep", Cep);
                        command.Parameters.AddWithValue("@Telefone", Telefone);
                        command.Parameters.AddWithValue("@Cidade", Cidade);
                        command.Parameters.AddWithValue("@CpfCliente", CpfCliente);

                        var returnParameter = command.Parameters.Add("@CpfValido", SqlDbType.Int);
                        returnParameter.Direction = ParameterDirection.ReturnValue;


                        connection.Open();
                        command.ExecuteNonQuery();

                        var result = (int)returnParameter.Value;


                        if (result == 1)
                        {
                            MessageBox.Show("Há um beneficiário cadastrado com este CPF");

                        }
                        else if (result == 2)
                        {
                            MessageBox.Show("Não há Cliente cadastrado com este CPF");

                        }
                        else
                            rtnValido = true;

                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Erro ao cadastrar Beneficiario");
                        MessageBox.Show("Erro encontrado: " + ex);
                        rtnValido = false;
                    }
                    return rtnValido;
                }
            }
        }

        public static bool ExcluiCadastro(string cpf)
        {
            bool rtnValido = false;
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ToString()))
            {
                using (var command = new SqlCommand
                {
                    Connection = connection,
                    CommandType = CommandType.StoredProcedure
                })
                {
                    command.CommandText = "Upd_WindowsForms_Cadastro_ExcluiCadastroBeneficiario";
                    try
                    {
                        command.Parameters.AddWithValue("@Cpf", cpf);

                        connection.Open();
                        command.ExecuteNonQuery();

                        rtnValido = true;
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Erro ao excluir cadastro");
                        MessageBox.Show("Erro encontrado: " + ex);
                    }
                }
            }
            return rtnValido;
        }
        public bool AtualizaCadastroBeneficiario(string cpf)
        {
            bool rtnValido = false;
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ToString()))
            {
                using (var command = new SqlCommand
                {
                    Connection = connection,
                    CommandType = CommandType.StoredProcedure
                })
                {
                    command.CommandText = "Upd_WindowsForms_Cadastro_AtualizaCadastroBeneficiario";
                    try
                    {
                        command.Parameters.AddWithValue("@Cpf", cpf);
                        command.Parameters.AddWithValue("@Email", Email);
                        command.Parameters.AddWithValue("@Nome", Nome);
                        command.Parameters.AddWithValue("@EstadoCivil", EstadoCivil);
                        command.Parameters.AddWithValue("@DataNascimento", Convert.ToDateTime(DataNascimento));
                        command.Parameters.AddWithValue("@Rg", Rg);
                        command.Parameters.AddWithValue("@Sexo", Sexo);
                        command.Parameters.AddWithValue("@Endereco", Endereco);
                        command.Parameters.AddWithValue("@NumeroResidencia", NumeroResidencia);
                        command.Parameters.AddWithValue("@Estado", Estado);
                        command.Parameters.AddWithValue("@Municipio", Municipio);
                        command.Parameters.AddWithValue("@Bairro", Bairro);
                        command.Parameters.AddWithValue("@Cep", Cep);
                        command.Parameters.AddWithValue("@Telefone", Telefone);
                        command.Parameters.AddWithValue("@Cidade", Cidade);

                        connection.Open();
                        command.ExecuteNonQuery();

                        rtnValido = true;
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Erro ao atualizar cadastro");
                        MessageBox.Show("Erro encontrado: " + ex);
                    }
                }
            }
            return rtnValido;
        }


    }
}
