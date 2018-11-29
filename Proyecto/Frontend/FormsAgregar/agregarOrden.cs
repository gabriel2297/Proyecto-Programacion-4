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


        int c = 0;
       public void obtenerPorductosOrden(string[]datos)
        {
            c = c+1;
            int tamano = datos.Length;
            label1.Text = c.ToString();
         
            this.tablaProductos.Rows.Add(datos);
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
                this.Hide();
            }
        }
   

        
    }
}
