using PIMQUATRO.Modelo;
using IronPdf;
using System;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Parsing;
using System.Drawing;
using System.Diagnostics;

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

        private void btnGerarRelatorio_Click(object sender, EventArgs e)
        {
            System.Environment.CurrentDirectory = "D:\\";
            Cliente cliente = new Cliente();
            
            var resultado = cliente.GetTodosClientes();

            var renderPdf = new ChromePdfRenderer();

            var html = GetHtml();
            string abreColuna = "<tr>";
            string fechaColuna = "</tr>";
            string abreLinha = "<td style=\"color:blue;\">";
            string fechaLinha = "</td>";

            foreach (var client in resultado)
            {
                html += abreColuna;
                html += abreLinha + $"{client._nome}" + fechaLinha;
                html += abreLinha + $"{client._rg}" + fechaLinha;
                html += abreLinha + $"{client._cpf}" + fechaLinha;
                html += abreLinha + $"{client._sexo}" + fechaLinha;
                html += abreLinha + $"{client._dataNascimento.ToString("dd/MM/yy")}" + fechaLinha;
                html += abreLinha + $"{client._estadoCivil}" + fechaLinha;
                html += abreLinha + $"{client._cidade}" + fechaLinha;
                html += abreLinha + $"{client._email}" + fechaLinha;

                html += fechaColuna;
            }

            html += "</tbody><table/>";

            var pdf = renderPdf.RenderHtmlAsPdf(html);

            var caminhoPdf = $"D:\\RelatorioCliente_{DateTime.Now.ToString("dd-MM-yy")}.pdf";
            pdf.SaveAs(caminhoPdf);

            Process.Start(new ProcessStartInfo { FileName = caminhoPdf, UseShellExecute = true });
        }

        private string GetHtml()
        {
            string html = "<h2>Relatorio Clientes</h2><table><thead><tr><th>Nome</th><th>Rg</th><th>Cpf</th><th>Sexo</th><th>Data Nascimento</th><th>Estado Civil</th><th>Cidade</th><th>Email</th></tr><thead><tbody>";
            return html;
        }
    }
}
