using iText.Layout.Properties;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIMQUATRO.Modelo
{
    public class Contrato
    {


        private int _numeroContrato { get; set; }
        private string _nomeCliente { get; set; }
        private string _NomeBeneficiario { get; set; }
        private string _tipoPlano { get; set; }
        private string _nomeSeguradora { get; set; }
        private string _cpfCliente { get;set; }
        private string _cnpjEmpresa { get; set; }

        public Contrato(int numeroContrato, string nomeCliente, string nomeBeneficiario, string tipoPlano, string nomeSeguradora, string cpfCliente, string cnpjEmpresa)
        {
            _numeroContrato = numeroContrato;
            _nomeCliente = nomeCliente;
            _NomeBeneficiario = nomeBeneficiario;
            _tipoPlano = tipoPlano;
            _nomeSeguradora = nomeSeguradora;
            _cpfCliente = cpfCliente;
            _cnpjEmpresa = cnpjEmpresa;
        }

        //public void RetornaDadosPdfApolice()
        //{

        //    using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ToString()))
        //    {
        //        connection.Open();

        //        using (var command = new SqlCommand($"SELECT top(1) tbclientes.nome, tbclientes.cpf,tbapolice.dataVigenciaInicial, tbapolice.dataVigenciaFinal,tbapolice.NumeroContrato, tbSeguradoras.Nome, tbSeguradoras.Cnpj FROM tbapolice inner join tbclientes ON tbapolice.id = tbclientes.idApolice  inner join tbseguradoras ON tbclientes.idSeguradora = tbseguradoras.id where tbclientes.cpf = {_cpf}", connection))

        //            try
        //            {
        //                SqlDataReader reader = command.ExecuteReader();
        //                while (reader.Read())
        //                {
        //                    _nome = reader.GetString(0);
                            
        //                }

        //            }
        //            catch (SqlException ex)
        //            {
        //                MessageBox.Show("Erro ao gerar apólice");
        //                MessageBox.Show("Erro encontrado: " + ex);

        //            }
        //    }
        //}
    }
}
