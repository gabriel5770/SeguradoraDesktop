using iText.IO.Font.Constants;
using iText.Kernel.Colors;
using iText.Kernel.Font;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using iText.StyledXmlParser.Jsoup.Nodes;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Document = iText.Layout.Document;
using Image = iText.Layout.Element.Image;

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
                document.SetFontSize(14);
                document.SetMargins(50, 50, 50, 50);
                document.SetCharacterSpacing((float)0.5);
                document.Add(new Paragraph("Apólice de seguro\n\n").SetFirstLineIndent
                    (150).SetFontSize(25));

                var logo = @"c:\dados\logoPim.png";
                Image img = new Image(iText.IO.Image.ImageDataFactory.Create(logo));
                img.ScaleAbsolute(70, 70);
                img.SetFixedPosition(50f, 750f);
                document.Add(img);

                //var timesNewRoman = PdfFontFactory.CreateFont(StandardFonts.TIMES_BOLD);
                //var p1 = new Paragraph();
                //p1.SetFont(timesNewRoman);
                //p1.SetFontSize(30);
                //p1.SetTextAlignment(TextAlignment.CENTER);
                //p1.SetFontColor(ColorConstants.RED);
                //p1.SetBackgroundColor(ColorConstants.LIGHT_GRAY);
                //p1.Add("APÓLICE");
                //document.Add(p1);

                document.Close();

                pdfDocument.Close();

                MessageBox.Show("Arquivo PDF gerado em" + arquivo);
            }

        }
    }
}

