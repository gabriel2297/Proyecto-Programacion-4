using Backend.DAL;
using Backend.Model;
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
    public partial class Mesas : Form
    {
        int idMesa;
        private IMesaDAL mesaDAL = new MesaDALImpl();
        public Mesas()
        {
            InitializeComponent();
        }

        private void cargarMesas()
        {
            try
            {
                this.tablaMesas.DataSource = null;
                this.tablaMesas.DataSource = mesaDAL.obtenerMesas();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void Mesas_Load(object sender, EventArgs e)
        {
            cargarMesas();
        }

        private void agregarBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (FormsAgregar.agregarMesa form = new FormsAgregar.agregarMesa())
                {
                    form.ShowDialog(this);
                    cargarMesas();
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void tablaMesas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int idMesa = Int32.Parse(tablaMesas.Rows[e.RowIndex].Cells[0].Value.ToString());
                using (editarMesa form = new editarMesa())
                {
                    MESA mesa = new MESA();
                    mesa = mesaDAL.obtenerMesaPorId(idMesa);
                    form.mesa = mesa;
                    form.ShowDialog(this);
                    cargarMesas();
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                mesaDAL.deleteMesa(idMesa);
                MessageBox.Show("La mesa se ha eliminado");
                this.cargarMesas();
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un error");
            }
        }

        private void tablaMesas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                idMesa = Int32.Parse(tablaMesas.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        private void tablaMesas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
