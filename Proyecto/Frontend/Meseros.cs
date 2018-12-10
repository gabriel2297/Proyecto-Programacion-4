using Backend.DAL;
using Frontend.FormsAgregar;
using Frontend.FormsEditarEliminar;
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
    public partial class Meseros : Form
    {
        private IMeseroDAL meseroDAL = new MeseroDALImpl();
        int idMesero;
        public Meseros()
        {
            InitializeComponent();
        }

        private void cargarMeseros() {
            try
            {
                this.mESEROBindingSource.DataSource = null;
                this.mESEROBindingSource.DataSource = meseroDAL.obtenerMeseros();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void Meseros_Load(object sender, EventArgs e)
        {
            cargarMeseros();
        }

        private void agregarBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (agregarMesero form = new agregarMesero())
                {
                    form.ShowDialog(this);
                    cargarMeseros();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void tablaDatos_Click(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                using (editarMesero form = new editarMesero())
                {
                    int id = Int32.Parse(tablaDatos.Rows[e.RowIndex].Cells[0].Value.ToString());
                    form.nombreMesero = meseroDAL.obtenerMeseroPorID(id).NOMBRE_MESERO;
                    form.idMesero = id;
                    form.ShowDialog(this);
                    cargarMeseros();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void tablaDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                meseroDAL.deleteMesero(this.idMesero);
                MessageBox.Show("Mesero eliminado");
                cargarMeseros();
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un error");
            }
        }

        private void tablaDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                idMesero = Int32.Parse(tablaDatos.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
