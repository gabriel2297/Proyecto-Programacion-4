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
    public partial class agregarOrden : Form
    {
        agregarProductosOrden form = new agregarProductosOrden();
        private IProductoDAL productoDAL = new ProductoDALImpl();
        string id, nombres, precio, descripcion;
        public agregarOrden()
        {
            InitializeComponent();
        }

        private void cancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void table_buscar_producto_Click(object sender, DataGridViewCellEventArgs e)
        {
            id = table_buscar_producto.Rows[e.RowIndex].Cells[0].Value.ToString();
            nombres = table_buscar_producto.Rows[e.RowIndex].Cells[1].Value.ToString();
            precio = table_buscar_producto.Rows[e.RowIndex].Cells[2].Value.ToString();
            descripcion = table_buscar_producto.Rows[e.RowIndex].Cells[3].Value.ToString();
        }
        private void agregarBtn_Click(object sender, EventArgs e)
        {

            tablaProductos.Rows.Add(id,nombres,precio,descripcion);
        }
        
        private void cargarTabla()
        {
            this.tablaProductos.DataSource = null;
            if (txtBuscarProducto.Text.Length > 0)
            {
                this.table_buscar_producto.DataSource = productoDAL.buscarProductos(txtBuscarProducto.Text);
            }
        }

        private void txtBuscarProducto_KeyUp(object sender, KeyEventArgs e)
        {
            cargarTabla();
        }

    }
}
