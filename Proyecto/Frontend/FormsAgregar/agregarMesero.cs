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
    public partial class agregarMesero : Form
    {
        private IMeseroDAL meseroDAL = new MeseroDALImpl();
        public agregarMesero()
        {
            InitializeComponent();
        }

        private void cancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void agregarBtn_Click(object sender, EventArgs e)
        {
            try
            {
                String nombre = this.nombreTxt.Text;
                if (nombre.Length <= 0)
                {
                    this.errorLbl.Visible = true;
                }
                else
                {
                    this.errorLbl.Visible = false;

                    MESERO mesero = new MESERO();
                    mesero.NOMBRE_MESERO = nombre;

                    if (meseroDAL.addMesero(mesero))
                    {
                        MessageBox.Show("Mesero agregado");
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
