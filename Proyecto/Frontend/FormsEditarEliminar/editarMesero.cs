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
    public partial class editarMesero : Form
    {
        private IMeseroDAL meseroDAL = new MeseroDALImpl();
        public String nombreMesero { get; set; }
        public int idMesero { get; set; }


        private void cancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public editarMesero()
        {
            InitializeComponent();
        }

        private void editarBtn_Click(object sender, EventArgs e)
        {
            if (nombreTxt.Text.Length <= 0)
            {
                this.errorLbl.Visible = true;
            }
            else
            {
                this.errorLbl.Visible = false;

                MESERO meseroEditado = new MESERO();
                meseroEditado.ID_MESERO = idMesero;
                meseroEditado.NOMBRE_MESERO = nombreTxt.Text;

                if (meseroDAL.updateMesero(meseroEditado))
                {
                    MessageBox.Show("Mesero editado satisfactoriamente");
                    this.Close();
                }
            }
        }

        private void editarMesero_Load(object sender, EventArgs e)
        {
            nombreTxt.Text = nombreMesero;
        }
    }
}
