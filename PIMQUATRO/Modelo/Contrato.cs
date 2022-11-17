 
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Layout.Element; 
using System.Configuration;
using System.Data.SqlClient;
using Document = iText.Layout.Document;
using Image = iText.Layout.Element.Image;


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

        public Contrato(int numeroContrato)
        {
            _numeroContrato = numeroContrato;
        }

        public void RetornaDadosPdfApolice()
        {

            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ToString()))
            {
                connection.Open();

                using (var command = new SqlCommand($"select tbclientes.nome as 'nome cliente',tbclientes.cpf,tbclientes.cidade,tbclientes.estado,tbclientes.endereco,tbclientes.NumereoResidencia,tbclientes.bairro,tbclientes.Municipio,tbclientes.Email,tbbeneficiario.nome as 'nome beneficiario',tbbeneficiario.cpf from tbcontrato inner join tbclientes on tbcontrato.idCli = tbclientes.id inner join tbapolice on tbapolice.id = tbcontrato.idapo inner join tbseguradoras on tbclientes.idseguradora = tbseguradoras.id inner join tbbeneficiario on tbclientes.idbeneficiario = tbbeneficiario.id where tbContrato.NumeroContrato = {_numeroContrato}", connection))

                    try
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            _nomeCliente = reader.GetString(0);

                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Erro ao gerar Contrato");
                        MessageBox.Show("Erro encontrado: " + ex);
                    }
            }
        }

        public void GerarPdf()
        {
            var arquivo = @$"c:\dados\NContrato[{_numeroContrato}].pdf";

            using (PdfWriter wpdf = new PdfWriter(arquivo, new WriterProperties().SetPdfVersion(PdfVersion.PDF_2_0)))
            {
                var pdfDocument = new PdfDocument(wpdf);

                var document = new Document(pdfDocument, PageSize.A4);
                document.SetFontSize(14);
                document.SetMargins(50, 50, 50, 50);
                document.SetCharacterSpacing((float)0.5);
                document.Add(new Paragraph("Contrato do seguro\n\n").SetFirstLineIndent
                    (150).SetFontSize(25));

                var logo = @"c:\dados\logoPim.png";
                Image img = new Image(iText.IO.Image.ImageDataFactory.Create(logo));
                img.ScaleAbsolute(70, 70);
                img.SetFixedPosition(50f, 750f);
                document.Add(img);

                document.Add(new Paragraph($"Nome:{_nomeCliente}\n"));
            


                document.Close();
                pdfDocument.Close();

                MessageBox.Show("Arquivo PDF gerado em" + arquivo);
            }

        }
    }
}
