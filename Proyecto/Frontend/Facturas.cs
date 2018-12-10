using Backend.DAL;
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
            this.fACTURABindingSource.DataSource = facturaDAL.obtenerFacturas();
        }

        private void tablaFacturas_Click(object sender, DataGridViewCellEventArgs e)
        {
           idFactura = Int32.Parse(tablaFacturas.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        private void btnReporteFacturacion_Click(object sender, EventArgs e)
        {
            Reportes.reporteFacturaciones formReporteFacturaciones = new Reportes.reporteFacturaciones();

            formReporteFacturaciones.obtenerIDFactura(idFactura);

            formReporteFacturaciones.ShowDialog(this);
        }

       
    }
}
