﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PatronDiseño_MVC.Views
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClienteView frmCliente = ClienteView.obtenerInstancia();
            frmCliente.MdiParent = this;
            frmCliente.Show();
            frmCliente.BringToFront();
        }
    }
}
