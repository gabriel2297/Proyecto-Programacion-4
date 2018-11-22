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

namespace Frontend.FormsAgregar
{
    public partial class agregarProductosOrden : Form
    {
        private IProductoDAL productoDAL = new ProductoDALImpl();
        public agregarProductosOrden()
        {
            InitializeComponent();
        }

        private void cargarTabla()
        {
            this.tablaProductos.DataSource = null;
            if(nombreTxt.Text.Length > 0)
            {
                this.tablaProductos.DataSource = productoDAL.buscarProductos(nombreTxt.Text);
            }
        }

        private void nombreTxt_KeyUp(object sender, KeyEventArgs e)
        {
            cargarTabla();
        }

        private void cancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        int id;
        string nombre;
        double precio;
        string descripcion;
        private void tablaPorductos_Click(object sender, DataGridViewCellEventArgs e)
        {
             id = Int32.Parse(tablaProductos.Rows[e.RowIndex].Cells[0].Value.ToString());
             nombre = tablaProductos.Rows[e.RowIndex].Cells[1].Value.ToString();
             precio = double.Parse(tablaProductos.Rows[e.RowIndex].Cells[2].Value.ToString());
             descripcion = tablaProductos.Rows[e.RowIndex].Cells[3].Value.ToString();


        }

        private void agregarBtn_Click(object sender, EventArgs e)
        {
            agregarOrden formOrden = new agregarOrden();
            formOrden.
        }
    }
}
