using Backend.DAL;
using Backend.Model;
using System;
using System.Collections;
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
        private IOrdenDAL ordenGlob = new OrdenDALImpl();
        private IProductoDAL productoDAL = new ProductoDALImpl();
        private IProductoXOrdenDAL oxpGlob = new ProductoXOrdenDALImpl();
        agregarOrden formOrden;

        public agregarProductosOrden()
        {
            InitializeComponent();
        }

        private void cargarTabla()
        {
     
        }

        private void nombreTxt_KeyUp(object sender, KeyEventArgs e)
        {
        }

        private void cancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        string id;
        string nombre;
        string precio;
        string descripcion;

        private void tablaPorductos_Click(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                id = tablaProductos.Rows[e.RowIndex].Cells[0].Value.ToString();
                nombre = tablaProductos.Rows[e.RowIndex].Cells[1].Value.ToString();
                precio = tablaProductos.Rows[e.RowIndex].Cells[2].Value.ToString();
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
                PRODUCTO_X_ORDEN prodXOrd = new PRODUCTO_X_ORDEN
                {
                    ID_ORDEN = Int32.Parse(cmbOrdenes.Text),
                    ID_PRODUCTO = Int32.Parse(id),
                    CANTIDAD_PRODUCTO = 1
                };
                oxpGlob.addProdxOrd(prodXOrd);
                MessageBox.Show("Producto agregado a la orden");
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un error");
            }
            
        }
        private void cargarOrdenes()
        {
            try
            {
                cmbOrdenes.DisplayMember = "ID_ORDEN";
                cmbOrdenes.DisplayMember = "NOMBRE_ORDEN";
                List<int> ordenes = ordenGlob.obtenerIdOrdenes();

                cmbOrdenes.DataSource = ordenes;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void agregarProductosOrden_Load(object sender, EventArgs e)
        {
            try
            {
                cargarProductos();
                cargarOrdenes();
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void cargarProductos()
        {
            try
            {
                pRODUCTOBindingSource.DataSource = null;
                pRODUCTOBindingSource.DataSource = productoDAL.obtenerProductos();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
