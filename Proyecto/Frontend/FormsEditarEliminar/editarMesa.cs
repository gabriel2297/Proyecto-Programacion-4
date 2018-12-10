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

namespace Frontend.FormsEditarEliminar
{
    public partial class editarMesa : Form
    {
        public MESA mesa = new MESA();
        private IMesaDAL mesaDAL = new MesaDALImpl();
        public editarMesa()
        {
            InitializeComponent();
        }

        public void cargarComboBox()
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

        private void cancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editarMesa_Load(object sender, EventArgs e)
        {
            capacidadSpnr.Value = (decimal) mesa.CAPACIDAD;
            cargarComboBox();
        }

        private void editarBtn_Click(object sender, EventArgs e)
        {
            try
            {
                ESTADO_MESAS estado = new ESTADO_MESAS();
                if ((ESTADO_MESAS)comboCB.SelectedItem != null)
                {
                    estado = (ESTADO_MESAS)comboCB.SelectedItem;
                    MESA laMesa = new MESA();
                    laMesa.ID_MESA = mesa.ID_MESA;
                    laMesa.ID_ESTADO = estado.ID_ESTADO;
                    laMesa.CAPACIDAD = Convert.ToInt32(capacidadSpnr.Value);
                    if (mesaDAL.updateMesa(laMesa))
                    {
                        MessageBox.Show("Mesa modificada");
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
