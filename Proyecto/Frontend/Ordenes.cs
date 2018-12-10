using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Backend.DAL;
using Backend.Model;

namespace Frontend
{
    public partial class Ordenes : Form
    {
        IOrdenDAL ordenGlob = new OrdenDALImpl();       
        public Ordenes()
        {
            InitializeComponent();
        }
        public void cargarOrdenes()
        {
            oRDENESBindingSource.DataSource = null;
            oRDENESBindingSource.DataSource = ordenGlob.obtenerOrdenes();
        }

        private void agregarBtn_Click(object sender, EventArgs e)
        {
            using(FormsAgregar.agregarOrden form = new FormsAgregar.agregarOrden())
            {
                form.ShowDialog(this);
            }
        }

        private void Ordenes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'pROIVDataSet.ORDENES' Puede moverla o quitarla según sea necesario.
            this.oRDENESTableAdapter.Fill(this.pROIVDataSet.ORDENES);
            cargarOrdenes();
        }

        private void TablaOrdenes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
