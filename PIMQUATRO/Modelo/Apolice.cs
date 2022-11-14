using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIMQUATRO.Modelo
{

    public class Apolice
    {
        private string _nome { get; set; }
        private string _cpf { get; set; }
        public string _DataVigenciaInicial { get; set; }
        private string _DataVigenciaFinal { get; set; }
        private string _numeroContrato { get; set; }

        public Apolice(string nome, string cpf, string dataVigenciaInicial, string dataVigenciaFinal, string numeroContrato)
        {
            _nome = nome;
            _cpf = cpf;
            _DataVigenciaInicial = dataVigenciaInicial;
            _DataVigenciaFinal = dataVigenciaFinal;
            _numeroContrato = numeroContrato;
        }

        public Apolice()
        {

        }

        public void GerarPdf()
        {
            var arquivo = @"c:\dados\Apolice.pdf";

            using (PdfWriter wpdf = new PdfWriter(arquivo, new WriterProperties().SetPdfVersion
        (PdfVersion.PDF_2_0)))
            {
                var pdfDocument = new PdfDocument(wpdf);

                var document = new Document(pdfDocument, PageSize.A4);
                document.Add(new Paragraph("TESTE DOS DEUSES , FUNCIONA PELO AMOR DE DEUS"));
                document.Close();

                pdfDocument.Close();

                MessageBox.Show("Arquivo PDF gerado em"+ arquivo);
            }

        }
    }
}

