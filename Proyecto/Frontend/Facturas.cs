﻿using Backend.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frontend
{
    public partial class Facturas : Form
    {
        private IFacturaDAL facturaDAL = new FacturaDALImpl();
        int idFactura ;
        public Facturas()
        {
            InitializeComponent();
        }

        private void Facturas_Load(object sender, EventArgs e)
        {
            try
            {
                this.fACTURABindingSource.DataSource = facturaDAL.obtenerFacturas();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void tablaFacturas_Click(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                idFactura = Int32.Parse(tablaFacturas.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnReporteFacturacion_Click(object sender, EventArgs e)
        {
            try
            {
                Reportes.FrmReporteFacturas formReporteFacturaciones = new Reportes.FrmReporteFacturas();


                formReporteFacturaciones.ShowDialog(this);
            }
            catch (Exception)
            {

                throw;
            }

        }

       
    }
}
