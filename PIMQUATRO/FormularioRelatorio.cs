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
            string cpfCliente = txtCpfCliente.Text;
            Apolice ap = new Apolice(cpfCliente);
            ap.RetornaDadosPdfApolice();
            ap.GerarPdf();
        }
    }
}
