
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Layout.Element;
using iText.StyledXmlParser.Jsoup.Nodes;
using System.Configuration;
using System.Data.SqlClient;
using Document = iText.Layout.Document;
using Image = iText.Layout.Element.Image;


namespace PIMQUATRO.Modelo
{
    public class Contrato
    {


        private string _nomeCliente { get; set; }
        private string _cpfCliente { get; set; }
        private string _cidadeCliente { get; set; }
        private string _estadoCliente { get; set; }
        private string _cepCliente { get; set; }
        private string _emailCliente { get; set; }


        private long _numeroContrato { get; set; }
        private long _numeroApolice { get; set; }

        //private string _tipoPlano { get; set; }
        //private string _nomeSeguradora { get; set; }
        //private string _cnpjEmpresa { get; set; }

        private string _nomeBeneficiario { get; set; }
        private string _cpfBeneficiario { get; set; }
        public string _cidadeBeneficiario { get; set; }
        public string _estadoBeneficiario { get; set; }
        public string _cepBeneficiario { get; set; }
        public string _emailBeneficiario { get; set; }



        public Contrato(string cpfCliente)
        {
            _cpfCliente = cpfCliente;
        }

        public bool RetornaDadosPdfContrato()
        {
            bool rtnValido = false;

            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ToString()))
            {
                connection.Open();

                using (var command = new SqlCommand($"select tbclientes.nome as 'nome cliente',tbclientes.cpf,tbclientes.cidade,tbclientes.estado,tbclientes.cep,tbbeneficiario.nome as 'nome beneficiario',tbbeneficiario.cpf , tbbeneficiario.cidade,tbbeneficiario.estado,tbbeneficiario.cep,tbapolice.NumeroContrato as 'NumeroApolice' ,tbcontrato.numerocontrato from tbcontrato inner join tbclientes on tbcontrato.idCli = tbclientes.id inner join tbapolice on tbapolice.id = tbcontrato.idapo inner join tbseguradoras on tbclientes.idseguradora = tbseguradoras.id inner join tbbeneficiario on tbclientes.idbeneficiario = tbbeneficiario.id where tbclientes.cpf = '{_cpfCliente}'", connection))

                    try
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            
                                _nomeCliente = reader.GetString(0);
                                _cpfCliente = reader.GetString(1);
                                _cidadeCliente = reader.GetString(2);
                                _estadoCliente = reader.GetString(3);
                                _cepCliente = reader.GetString(4);

                                _nomeBeneficiario = reader.GetString(5);
                                _cpfBeneficiario = reader.GetString(6);
                                _cidadeBeneficiario = reader.GetString(7);
                                _estadoBeneficiario = reader.GetString(8);
                                _cepBeneficiario = reader.GetString(9);
                                _numeroApolice = reader.GetInt64(10);
                                _numeroContrato = reader.GetInt64(11);

                            
                                        
                            rtnValido = true;
                        }

                        else
                        {
                            MessageBox.Show("Não foi encontrado registro com este CPF ou não foi vinculado o beneficiário");
                        }

                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Erro ao gerar Contrato");
                        MessageBox.Show("Erro encontrado: " + ex);
                    }
                return rtnValido;
            }
        }

        public void GerarPdf()
        {
            var arquivo = @$"c:\dados\NContrato[{_numeroContrato}].pdf";

            using (PdfWriter wpdf = new PdfWriter(arquivo, new WriterProperties().SetPdfVersion(PdfVersion.PDF_2_0)))
            {
                var pdfDocument = new PdfDocument(wpdf);

                var document = new Document(pdfDocument, PageSize.A4);
                document.SetFontSize(12);
                document.SetMargins(50, 50, 50, 50);
                document.SetCharacterSpacing((float)0.5);
                document.Add(new Paragraph("Contrato do seguro\n\n").SetFirstLineIndent
                    (150).SetFontSize(25));

                var logo = @"c:\dados\logoPim.png";
                Image img = new Image(iText.IO.Image.ImageDataFactory.Create(logo));
                img.ScaleAbsolute(70, 70);
                img.SetFixedPosition(50f, 750f);
                document.Add(img);

                document.Add(new Paragraph($"Nº contrato:{_numeroContrato}\n"));

                document.Add(new Paragraph($"Dados do segurado:\n"));

                document.Add(new Paragraph($"Nome:{_nomeCliente}\n"));
                document.Add(new Paragraph($"CPF:{_cpfCliente}\n"));
                document.Add(new Paragraph($"Cidade:{_cidadeCliente}\n"));
                document.Add(new Paragraph($"Estado:{_estadoCliente}\n"));
                document.Add(new Paragraph($"Cep:{_cepCliente}\n\n"));


                document.Add(new Paragraph($"Dados do Beneficiario:\n"));
                document.Add(new Paragraph($"Nome:{_nomeBeneficiario}\n"));
                document.Add(new Paragraph($"CPF:{_cpfBeneficiario}\n"));
                document.Add(new Paragraph($"Cidade:{_cidadeBeneficiario}\n"));
                document.Add(new Paragraph($"Estado:{_estadoBeneficiario}\n"));
                document.Add(new Paragraph($"Cep:{_cepBeneficiario}\n\n"));

                document.Add(new Paragraph($"A Dream Life Seguros LTDA, baseando-se nas informações constantes da proposta de contratação segurado acima mencionado e nos termos das condições gerais e condições especiais/particulares a ela vinculado, mediante o recebimento do prêmio de seguro obriga-se a indenizar aos beneficiarios, conforme condições gerais, condições especiais/árticulares da Apólice de seguro, as consequencias da cobertura designada Apólice Nº {_numeroApolice}\r\n \n"));
                document.Add(new Paragraph($"As condições de aceitação e demais especificações desta apólice são aquelas constantes nas condições gerais, condições especiais/particulares as quais fazem parte integrante e inseparável desta apólice.\r\nEm testemunho do que a Dream Life Seguros LTDA, neste ato assina está apólice \r\n\n"));






                document.Close();
                pdfDocument.Close();

                MessageBox.Show("Arquivo PDF gerado em" + arquivo);
            }

        }
    }
}
