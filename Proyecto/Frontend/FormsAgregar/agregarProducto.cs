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
    public partial class agregarProducto : Form
    {
        private ICategoriaDAL categoriaDAL = new CategoriaDALImpl();
        private IProductoDAL productoDAL = new ProductoDALImpl();
        public agregarProducto()
        {
            InitializeComponent();
            cargarComboBox();
        }

        public void cargarComboBox()
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

        private void cancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void agregarBtn_Click(object sender, EventArgs e)
        {
            CATEGORIA categoria = new CATEGORIA();
            if ((CATEGORIA)comboCB.SelectedItem != null)
            {
                categoria = (CATEGORIA)comboCB.SelectedItem;
                PRODUCTO producto = new PRODUCTO();
                producto.NOMBRE_PRODUCTO = nombreTxt.Text;
                producto.ID_CATEGORIA = categoria.ID_CATEGORIA;
                producto.PRECIO_PRODUCTO = Convert.ToInt32(precioSpnr.Value);
                productoDAL.agregarProducto(producto);
                MessageBox.Show("Producto agregado");
                this.Close();
            }
        }
    }
}
