using PIMQUATRO.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIMQUATRO
{
    public partial class FormularioContato : Form
    {
        public FormularioContato()
        {
            InitializeComponent();
            AtualizarTabela();
        }
        public void AtualizarTabela() // atualiza o dataGridView
        {

            dataGridContato.DataSource = Contato.ConsultarContato(); //passsa a consulta para o datagridview
        }

        private void FormularioContato_Load(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Contato contato = new Contato();
            int id = (int)dataGridContato.SelectedRows[0].Cells[0].Value; // pega o id do  dataGridView Selecionado
            contato.ExcluirContato(id);
            AtualizarTabela(); //atualizada a tabela depois de excluir
        }
    }
}
