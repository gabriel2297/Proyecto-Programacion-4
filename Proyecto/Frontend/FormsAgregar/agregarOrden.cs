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
    public partial class agregarOrden : Form
    {
        private PROIVEntities context;
        agregarProductosOrden form = new agregarProductosOrden();
        private IOrdenDAL ordenGlob = new OrdenDALImpl();
        private IProductoDAL productoDAL = new ProductoDALImpl();
        private IMeseroDAL meseroGlob = new MeseroDALImpl();
        private IProductoXOrdenDAL pxoGlob = new ProductoXOrdenDALImpl();
        private IMesaDAL mesaGlob = new MesaDALImpl();
        string id, nombres, precio, descripcion;
        int idMesa, idMesero;
        string nombreOrden;
        int numerOrden;
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
        private void cargarMeseros()
        {
            cmbMesero.DisplayMember = "ID_MESERO";
            cmbMesero.ValueMember = "NOMBRE_MESERO";
            List<MESERO> meseros = meseroGlob.obtenerMeseros();

            cmbMesero.DataSource = meseros;
        }
        private void cargarMesas()
        {
            cmbMesa.DisplayMember = "ID_MESA";
            cmbMesa.ValueMember = "NOMBRE_MESA";
            List<int> mesas = mesaGlob.obtieneIdMesa();

            cmbMesa.DataSource = mesas;
        }

        private void terminarBtn_Click(object sender, EventArgs e)
        {
            try
            {
                idMesa = Int32.Parse(cmbMesa.Text);
                idMesero = Int32.Parse(cmbMesero.Text);

                MESERO mesero = meseroGlob.obtenerMeseroPorID(idMesero);
                ORDENE orden = new ORDENE
                {
                    ID_MESA = idMesa,
                    ID_MESERO = idMesero,
                    NOMBRE_ORDEN = mesero.NOMBRE_MESERO
                };
                    ordenGlob.addOrden(orden);
                using (context = new PROIVEntities())
                {
                    var num_orden = context.Database.SqlQuery<decimal>("SELECT IDENT_CURRENT('ORDENES')").FirstOrDefault();
                    numerOrden = (int)num_orden;
                }
                for (int i = 0; i < tablaProductos.RowCount; i++)
                {

                    int idProducto = Int32.Parse(tablaProductos.Rows[i].Cells[0].Value.ToString());

                    PRODUCTO_X_ORDEN pxo = new PRODUCTO_X_ORDEN
                    {
                        ID_ORDEN = numerOrden,
                        ID_PRODUCTO = idProducto,
                        CANTIDAD_PRODUCTO = 1
                    };
                        pxoGlob.addProdxOrd(pxo);
                }
                MessageBox.Show("Orden registrada");
                this.Close();

            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un error");
            }
            
        }

        private void agregarOrden_Load(object sender, EventArgs e)
        {
            this.cargarMeseros();
            this.cargarMesas();
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
