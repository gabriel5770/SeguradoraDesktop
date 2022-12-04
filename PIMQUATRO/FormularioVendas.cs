using iText.Kernel.Pdf.Canvas.Wmf;
using PIMQUATRO.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
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

        private bool ValidaCampos()
        {
            if (txtEmail.Text == "" || txtNome.Text == "" || dateTimePickerVenda.Text == ""
                || maskedCpf.Text == "" || cmbSexoVendas.Text == "" 
                || maskedTelefone.Text == "" || cmdSeguro.Text == "") ;
             
            {
                MessageBox.Show("Há campos não preenchidos , revise");
                return false;
            }
            return true;
        }

        private void btnCadastrarVendas_Click(object sender, EventArgs e)
        {
            string Email = txtEmail.Text;
            string Nome = txtNome.Text;
            DateTime DataNascimento = Convert.ToDateTime(dateTimePickerVenda.Text);
            string Cpf = maskedCpf.Text;
            string Sexo = cmbSexoVendas.Text;
            string Telefone = maskedTelefone.Text;
            string Seguro = cmdSeguro.Text;

            if (ValidaCampos())
            {
                Vendas vendas = new Vendas(Nome, DataNascimento, Email, Telefone, Cpf, Sexo, Seguro);
                if (ValidaCampos())
                {
                    if (vendas.SalvarVendas())
                    {
                        MessageBox.Show("Venda cadastrada com sucesso");
                        AtualizarTabela();
                    }
                }
            }



  

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Vendas vendas = new Vendas();
            int id = (int)dataGridVendas.SelectedRows[0].Cells[0].Value; // pega o id do  dataGridView Selecionado
            vendas.ExcluirVendas(id);
            AtualizarTabela(); //atualizada a tabela depois de excluir
        }
    }
}
