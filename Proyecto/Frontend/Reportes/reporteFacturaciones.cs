﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frontend.Reportes
{
    public partial class reporteFacturaciones : Form
    {
        public reporteFacturaciones()
        {
            InitializeComponent();
        }

        private void reporteFacturaciones_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
            this.reportViewer2.RefreshReport();
        }

        private void btnRegresarFacturas_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
