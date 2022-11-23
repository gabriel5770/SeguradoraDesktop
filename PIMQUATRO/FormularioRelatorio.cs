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
            string html = "<!DOCTYPE html>\r\n<html>\r\n<head>\r\n<style>\r\n\r\ntable {\r\n  border-collapse: collapse;\r\n  width: 100%;\r\n}\r\n\r\nth, td {\r\n  text-align: left;\r\n  padding: 8px;\r\n}\r\nh2 {\r\n    text-align: center;\r\n}\r\n\r\ntr:nth-child(even) {\r\n  background-color: #90cefb;\r\n}\r\n</style>\r\n</head>\r\n<body>\r\n\r\n<h2>Relatorio Cliente</h2>\r\n\r\n<table>\r\n  <tr>\r\n    <th>Nome</th>\r\n    <th>RG</th>\r\n    <th>CPF</th>\r\n    <th>Sexo</th>\r\n    <th>Data Nascimento</th>\r\n    <th>Estado Civil</th>\r\n    <th>Cidade</th>\r\n    <th>e-mail</th>\r\n  </tr>\r\n\r\n  <tr>\r\n    <td></td>\r\n    <td></td>\r\n    <td></td>\r\n    <td></td>\r\n    <td></td>\r\n    <td></td>\r\n    <td></td>\r\n    <td></td>\r\n  </tr>\r\n  \r\n</table>\r\n\r\n</body>\r\n</html>\r\n";
            return html;
        }
    }
}
