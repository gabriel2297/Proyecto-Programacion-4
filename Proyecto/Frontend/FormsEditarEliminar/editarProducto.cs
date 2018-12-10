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
    public partial class editarProducto : Form
    {
        public PRODUCTO producto = new PRODUCTO();
        private ICategoriaDAL categoriaDAL = new CategoriaDALImpl();
        private IProductoDAL productoDAL = new ProductoDALImpl();

        public editarProducto()
        {
            InitializeComponent();
        }

        private void editarProducto_Load(object sender, EventArgs e)
        {
            inicializarComponentes();
        }

        public void cargarComboBox()
        {
            try
            {
                var dataSource = new List<CATEGORIA>();
                dataSource = categoriaDAL.obtenerCategorias();
                this.comboCB.DataSource = null;
                this.comboCB.Items.Clear();
                this.comboCB.DataSource = dataSource;
                this.comboCB.DisplayMember = "DESCRIPCION";
                this.comboCB.ValueMember = "ID_CATEGORIA";
                this.comboCB.Refresh();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void inicializarComponentes()
        {
            try
            {
                nombreTxt.Text = producto.NOMBRE_PRODUCTO;
                precioSpnr.Value = (decimal)producto.PRECIO_PRODUCTO;
                cargarComboBox();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void cancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void agregarBtn_Click(object sender, EventArgs e)
        {
            try
            {
                PRODUCTO productoEditado = new PRODUCTO();
                CATEGORIA categoria = new CATEGORIA();

                String nuevaDescripcion = nombreTxt.Text;
                int nuevoPrecio = (int)precioSpnr.Value;
                categoria = (CATEGORIA)comboCB.SelectedItem;

                productoEditado.ID_PRODUCTO = producto.ID_PRODUCTO;
                productoEditado.ID_CATEGORIA = categoria.ID_CATEGORIA;
                productoEditado.NOMBRE_PRODUCTO = nuevaDescripcion;
                productoEditado.PRECIO_PRODUCTO = nuevoPrecio;

                productoDAL.actualizarProducto(productoEditado);

                this.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
