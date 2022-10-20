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
    public partial class FormularioMenu : Form
    {
        private Form frmAtivo;
        public FormularioMenu()
        {
            InitializeComponent();
        }

        private void FormShow(Form frm)
        {
            ActiveFormClose();
            frmAtivo = frm;
            frm.TopLevel = false;
            panelForms.Controls.Add(frm);
            frm.BringToFront();
            frm.Show(); 

        }

        private void ActiveFormClose()
        {
            if (frmAtivo != null)
                frmAtivo.Close();

        }

        private void ActiveButton(Button frmAtivo)
        {
            foreach (Control crtl in panelPrincipal.Controls)
                crtl.ForeColor = Color.White;

            frmAtivo.ForeColor = Color.Red;
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            
            ActiveButton(btnClientes);
            FormShow(new FormularioClientes());
            
        }

        private void btnFuncionarios_Click(object sender, EventArgs e)
        {
            ActiveButton(btnFuncionarios);
            FormShow(new FormularioFuncionario());
        }

        private void btnSeguradoras_Click(object sender, EventArgs e)
        {
            ActiveButton(btnSeguradoras);
            FormShow(new FormularioSeguradora());
        }

        private void btnVendas_Click(object sender, EventArgs e)
        {
            ActiveButton(btnVendas);
            FormShow(new FormularioVendas());
        }

        private void btnDuvidas_Click(object sender, EventArgs e)
        {
            ActiveButton(btnDuvidas);
            FormShow(new FormularioDuvidas());
        }

        private void btnCadastrarBeneficiario_Click(object sender, EventArgs e)
        {
            ActiveButton(btnDuvidas);
            FormShow(new FormularioBeneficiario());
        }

        private void panelLogo_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
