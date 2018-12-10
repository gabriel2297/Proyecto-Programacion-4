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

namespace Frontend
{
    public partial class Productos : Form
    {
        private IProductoDAL productoDAL = new ProductoDALImpl();
        public Productos()
        {
            InitializeComponent();
        }

        private void cargarProductos()
        {
            try
            {
                this.tablaProductos.DataSource = null;
                this.tablaProductos.DataSource = productoDAL.obtenerProductosObjetos();
            }
            catch (Exception)
            {

                throw;
            }
        }

        int idP;

        private void obtenerIDTabla(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                idP = Int32.Parse(tablaProductos.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        private void Productos_Load(object sender, EventArgs e)
        {
            cargarProductos();
        }

        private void agregarBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (FormsAgregar.agregarProducto form = new FormsAgregar.agregarProducto())
                {
                    form.ShowDialog(this);
                    cargarProductos();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void tablaProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int idProducto = Int32.Parse(tablaProductos.Rows[e.RowIndex].Cells[0].Value.ToString());
                using (FormsEditarEliminar.editarProducto form = new FormsEditarEliminar.editarProducto())
                {
                    PRODUCTO producto = new PRODUCTO();
                    producto = productoDAL.mostrarProducto(idProducto);
                    form.producto = producto;
                    form.ShowDialog(this);
                    cargarProductos();
                }
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
         {

            try
            {
                productoDAL.eliminarProducto(this.idP);
                MessageBox.Show("Producto eliminado");
                cargarProductos();
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un error");
            }
        }

        private void tablaProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
