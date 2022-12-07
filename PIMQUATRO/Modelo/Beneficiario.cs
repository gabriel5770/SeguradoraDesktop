using System;
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
    internal class Beneficiario
    {
        private string _email { get; set; }
        private string _nome { get; set; }
        private string _estadoCivil { get; set; }
        private DateTime _dataNascimento { get; set; }
        private string _numeroResidencia { get; set; }
        private string _rg { get; set; }
        private string _cpf { get; set; }
        private string _sexo { get; set; }
        private string _endereco { get; set; }
        private string _cidade { get; set; }
        private string _estado { get; set; }
        private string _municipio { get; set; }
        private string _bairro { get; set; }
        private string _cep { get; set; }
        private string _telefone { get; set; }
        private string _cpfCliente { get; set; }

        public Beneficiario(string email, string nome, string estadoCivil, DateTime dataNascimento, string numeroResidencia, string rg, string cpf, string sexo, string endereco, string cidade, string estado, string municipio, string bairro, string cep, string telefone, string cpfCliente)
        {
            _email = email;
            _nome = nome;
            _estadoCivil = estadoCivil;
            _dataNascimento = dataNascimento;
            _numeroResidencia = numeroResidencia;
            _rg = rg;
            _cpf = cpf;
            _sexo = sexo;
            _endereco = endereco;
            _cidade = cidade;
            _estado = estado;
            _municipio = municipio;
            _bairro = bairro;
            _cep = cep;
            _telefone = telefone;
            _cpfCliente = cpfCliente;
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
                        command.Parameters.AddWithValue("@Email", _email);
                        command.Parameters.AddWithValue("@Nome", _nome);
                        command.Parameters.AddWithValue("@EstadoCivil", _estadoCivil);
                        command.Parameters.AddWithValue("@DataNascimento", _dataNascimento);
                        command.Parameters.AddWithValue("@Rg", _rg);
                        command.Parameters.AddWithValue("@Cpf", _cpf);
                        command.Parameters.AddWithValue("@Sexo", _sexo);
                        command.Parameters.AddWithValue("@Endereco", _endereco);
                        command.Parameters.AddWithValue("@NumeroResidencia", _numeroResidencia);
                        command.Parameters.AddWithValue("@Estado", _estado);
                        command.Parameters.AddWithValue("@Municipio", _municipio);
                        command.Parameters.AddWithValue("@Bairro", _bairro);
                        command.Parameters.AddWithValue("@Cep", _cep);
                        command.Parameters.AddWithValue("@Telefone", _telefone);
                        command.Parameters.AddWithValue("@Cidade", _cidade);
                        command.Parameters.AddWithValue("@CpfCliente", _cpfCliente);

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
                            MessageBox.Show("Há um beneficiário cadastrado com este RG");

                        }
                        else if (result == 3)
                        {
                            MessageBox.Show("Há um beneficiário cadastrado com este EMAIL");

                        }
                        else if (result == 4)
                        {
                            MessageBox.Show("Não há cliente cadastrado com este CPF");

                        }
                        else
                            rtnValido = true;

                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Erro ao cadastrar Beneficiario");
                        MessageBox.Show("Erro encontrado: " + ex);
 
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
                        command.Parameters.AddWithValue("@Email", _email);
                        command.Parameters.AddWithValue("@Nome", _nome);
                        command.Parameters.AddWithValue("@EstadoCivil", _estadoCivil);
                        command.Parameters.AddWithValue("@DataNascimento", Convert.ToDateTime(_dataNascimento));
                        command.Parameters.AddWithValue("@Rg", _rg);
                        command.Parameters.AddWithValue("@Sexo", _sexo);
                        command.Parameters.AddWithValue("@Endereco", _endereco);
                        command.Parameters.AddWithValue("@NumeroResidencia", _numeroResidencia);
                        command.Parameters.AddWithValue("@Estado", _estado);
                        command.Parameters.AddWithValue("@Municipio", _municipio);
                        command.Parameters.AddWithValue("@Bairro", _bairro);
                        command.Parameters.AddWithValue("@Cep", _cep);
                        command.Parameters.AddWithValue("@Telefone", _telefone);
                        command.Parameters.AddWithValue("@Cidade", _cidade);

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
