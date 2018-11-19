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
    public partial class Meseros : Form
    {
        private IMeseroDAL meseroDAL = new MeseroDALImpl();
        public Meseros()
        {
            InitializeComponent();
        }

        private void Meseros_Load(object sender, EventArgs e)
        {
            this.mESEROBindingSource.DataSource = meseroDAL.obtenerMeseros();
        }
    }
}
