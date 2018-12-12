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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.sp_ObtenerFacturaPorFecha' table. You can move, or remove it, as needed.
            //this.sp_ObtenerFacturaPorFechaTableAdapter.Fill(this.DataSet1.sp_ObtenerFacturaPorFecha);

            this.reportViewer1.RefreshReport();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.sp_ObtenerFacturaPorFecha' table. You can move, or remove it, as needed.
            this.sp_ObtenerFacturaPorFechaTableAdapter.Fill(this.DataSet1.sp_ObtenerFacturaPorFecha, monthCalendar1.SelectionStart);

            this.reportViewer1.RefreshReport();
        }
    }
}
