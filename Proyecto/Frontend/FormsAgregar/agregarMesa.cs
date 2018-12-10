using Backend.DAL;
using Backend.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frontend.FormsAgregar
{
    public partial class agregarMesa : Form
    {
        private IMesaDAL mesaDAL = new MesaDALImpl();
        public agregarMesa()
        {
            InitializeComponent();
            cargarComboBox();
        }

        private void cancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void cargarComboBox()
        {
            try
            {
                var dataSource = new List<ESTADO_MESAS>();
                dataSource = mesaDAL.obtenerEstados();
                this.comboCB.DataSource = null;
                this.comboCB.Items.Clear();
                this.comboCB.DataSource = dataSource;
                this.comboCB.DisplayMember = "ESTADO";
                this.comboCB.ValueMember = "ID_ESTADO";
                this.comboCB.Refresh();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void agregarBtn_Click(object sender, EventArgs e)
        {
            try
            {
                ESTADO_MESAS estado = new ESTADO_MESAS();
                if ((ESTADO_MESAS)comboCB.SelectedItem != null)
                {
                    estado = (ESTADO_MESAS)comboCB.SelectedItem;
                    MESA mesa = new MESA();
                    mesa.ID_ESTADO = estado.ID_ESTADO;
                    mesa.CAPACIDAD = Convert.ToInt32(capacidadSpnr.Value);
                    if (mesaDAL.addMesa(mesa))
                    {
                        MessageBox.Show("Mesa agregada");
                        this.Close();
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            
        }
    }
}
