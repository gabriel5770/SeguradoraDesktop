using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.StyledXmlParser.Jsoup.Nodes;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Document = iText.Layout.Document;

namespace PIMQUATRO.Modelo
{

    public class Apolice
    {
        private string _nome { get; set; }
        private string _cpf { get; set; }
        public string _DataVigenciaInicial { get; set; }
        private string _DataVigenciaFinal { get; set; }
        private string _numeroContrato { get; set; }

        public Apolice(string cpf)
        {
             _cpf = cpf;
           
        }

        public Apolice()
        {

        }

        public void RetornaDadosPdfApolice()
        {

             using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ToString()))
            {
                connection.Open();

                using (var command = new SqlCommand(
                                    $"SELECT tbclientes.nome, tbclientes.cpf, tbapolice.dataVigenciaInicial, tbapolice.dataVigenciaFinal, tbapolice.NumeroContrato " +
                                    $" FROM tbapolice inner join tbclientes ON tbapolice.id = tbclientes.idApolice where tbclientes.cpf = {_cpf}", connection))

                    try
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            _nome = reader.GetString(0);
                            _cpf = reader.GetString(1);
                            _DataVigenciaInicial = Convert.ToString(reader.GetDateTime(2));
                            _DataVigenciaFinal = Convert.ToString(reader.GetDateTime(3));
                            _numeroContrato = Convert.ToString(reader.GetInt64(4));

                          }

                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Erro ao gerar apólice");
                        MessageBox.Show("Erro encontrado: " + ex);

                    }
             }
        }

        public void GerarPdf()
        {
            var arquivo = @"c:\dados\Apolice.pdf";

            using (PdfWriter wpdf = new PdfWriter(arquivo, new WriterProperties().SetPdfVersion
        (PdfVersion.PDF_2_0)))
            {
                var pdfDocument = new PdfDocument(wpdf);

                var document = new Document(pdfDocument, PageSize.A4);
                document.Add(new Paragraph($"nome = {_nome}"));
                document.Close();

                pdfDocument.Close();

                MessageBox.Show("Arquivo PDF gerado em" + arquivo);
            }

        }
    }
}

