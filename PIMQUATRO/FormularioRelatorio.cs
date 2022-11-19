using PIMQUATRO.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIMQUATRO
{
    public partial class FormularioRelatorio : Form
    {
        public FormularioRelatorio()
        {
            InitializeComponent();
        }

        private void btnGerarApolice_Click(object sender, EventArgs e)
        {
            GeraApolice();
        }

        private void btnGerarContrato_Click(object sender, EventArgs e)
        {
            GerarContrato();

        }

        protected void GeraApolice()
        {
            string cpfCliente = txtNumeroDocumento.Text;
            if (cpfCliente == "")
            {
                MessageBox.Show("Favor preencher o campo CPF");
            }
            else
            {
                Apolice ap = new Apolice(cpfCliente);
                if (ap.RetornaDadosPdfApolice())
                {
                    ap.GerarPdf();
                }
            }
        }

        protected void GerarContrato()
        {
            string cpfCliente = txtNumeroDocumento.Text;

            if (cpfCliente == "")
            {
                MessageBox.Show("Favor inserir o campo CPF");
            }
            else
            {
                Contrato cont = new Contrato(cpfCliente);
                if (cont.RetornaDadosPdfContrato())
                {
                    cont.GerarPdf();

                }
            }
        }
    }
}
