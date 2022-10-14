using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace PIMQUATRO.Modelo
{
     class Cliente : Cadastrar
    {
   
        public int idBeneficiario { get; set; }
        public  Cliente()
        {
        }

        public Cliente (string email, string nome, string estadoCivil, string rg, string sexo, string endereco, string numeroResidencia, string municipio, string bairro,
       string cep, string telefone, string estado, DateTime dataNascimento, string cpf, string cidade) : base
         (email, nome, estadoCivil, rg, sexo, endereco, numeroResidencia, municipio, bairro, cep, telefone, estado, dataNascimento, cpf, cidade)
        {
           idBeneficiario = idBeneficiario;
        }

        public override int Cadastro()
        {
            return base.Cadastro();
        }

    }
}
