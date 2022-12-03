using PIMQUATRO.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIMQUATRO
{
    public partial class FormularioVendas : Form
    {
        public FormularioVendas()
        {
            InitializeComponent();
            AtualizarTabela();

        }
        private void FormularioVendas_Load(object sender, EventArgs e)
        {

        }
        public void AtualizarTabela() // atualiza o dataGridView
        {

            dataGridVendas.DataSource = Vendas.ConsultarVendas(); //passsa a consulta para o datagridview
        }

        private void ObterDadosVendas()
        {

            string Email = txtEmail.Text;
            string Nome = txtNome.Text;
            DateTime DataNascimento = Convert.ToDateTime(maskedNascimento.Text);
            string Cpf = maskedCpf.Text;
            string Sexo = cmbSexoVendas.Text;
            string Numero = maskedNascimento.Text;
            string Telefone = maskedTelefone.Text;
            string Seguro = cmdSeguro.Text;


            Vendas vendas = new Vendas(Nome,DataNascimento,Email,Telefone,Cpf,Sexo,Seguro);

            // validação dos dados
            List<ValidationResult> listErros = new List<ValidationResult>();//lista para capturar erros e armazenar
            ValidationContext contect = new ValidationContext(vendas); // passa o obj que sera validado
            bool validator = Validator.TryValidateObject(vendas, contect, listErros, true); // valida todos os erros

            try //validação ok
            {
                vendas.SalvarVendas();
                MessageBox.Show("Salvo com Sucesso");
            

            }
            catch (Exception ex)
            {
                StringBuilder sb = new StringBuilder(); // vai armazenar as mensagens de erro

                foreach (ValidationResult erro in listErros) // percorre a lista de erro e captura os erros
                {
                    sb.Append(erro.ErrorMessage + "\n"); // recebe as mensagens de erro

                }
                MessageBox.Show(sb.ToString());// passas as mensagens de erro para label
            }



          

           
        }

        private void btnCadastrarVendas_Click(object sender, EventArgs e)
        {
            ObterDadosVendas();
        }
    }
}
