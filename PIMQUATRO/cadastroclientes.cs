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
    public partial class cadastroclientes : Form
    {
        public cadastroclientes()
        {
            InitializeComponent();
        }

        private void Voltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            new clientes().ShowDialog();
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
