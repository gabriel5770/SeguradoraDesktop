﻿using System;
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
    public partial class FormularioRelatorioClientes : Form
    {
        public FormularioRelatorioClientes()
        {
            InitializeComponent();

            reportViewer1.LocalReport.ReportEmbeddedResource =
                "PIMQUATRO.RelatorioClientes.rdlc";

            reportViewer1.RefreshReport();
        }
    }
}