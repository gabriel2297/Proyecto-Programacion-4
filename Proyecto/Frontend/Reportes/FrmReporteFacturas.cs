using System;
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
    public partial class FrmReporteFacturas : Form
    {
        public FrmReporteFacturas()
        {
            InitializeComponent();
            monthCalendar1.Hide();
            btnFecha.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            btnFecha.Show();    
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
           

           // DateTime dt2 = Convert.ToDateTime(lblFecha);
            // TODO: This line of code loads data into the 'DataSet1.sp_obtenerfacturaporfecha' table. You can move, or remove it, as needed.
              this.sp_obtenerfacturaporfechaTableAdapter.Fill(this.DataSet1.sp_obtenerfacturaporfecha,monthCalendar1.SelectionStart);

              this.reportViewer1.RefreshReport();
            btnFecha.Hide();

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void btnReporteFacturacion_Click(object sender, EventArgs e)
        {
            monthCalendar1.Show();
        }
    }
}
