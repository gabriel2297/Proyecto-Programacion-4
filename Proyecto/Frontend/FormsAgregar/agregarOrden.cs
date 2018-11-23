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
    public partial class agregarOrden : Form
    {
        public agregarOrden()
        {
            InitializeComponent();
        }

        public agregarOrden(string[] datos) {
            label1.Text = datos[0];
            //this.tablaProductos.DataSource = datos;
        }

        private void cancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void agregarBtn_Click(object sender, EventArgs e)
        {
            using(agregarProductosOrden form = new agregarProductosOrden())
            {
                form.ShowDialog(this);
            }
        }
   

        
    }
}
