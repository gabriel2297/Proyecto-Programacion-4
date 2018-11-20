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
    public partial class Categorias : Form
    {
        private ICategoriaDAL categoriaDAL = new CategoriaDALImpl();
        public Categorias()
        {
            InitializeComponent();
        }

        private void cargarCategorias()
        {
            this.tablaCategorias.DataSource = null;
            this.tablaCategorias.DataSource = categoriaDAL.obtenerCategorias();
        }

        private void Categorias_Load(object sender, EventArgs e)
        {
            cargarCategorias();
        }

        private void agregarBtn_Click(object sender, EventArgs e)
        {
            using (FormsAgregar.agregarCategoria form = new FormsAgregar.agregarCategoria())
            {
                form.ShowDialog(this);
                cargarCategorias();
            }

        }

        private void tablaCategorias_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int idCategoria = Int32.Parse(tablaCategorias.Rows[e.RowIndex].Cells[0].Value.ToString());
            using (FormsEditarEliminar.editarCategoria form = new FormsEditarEliminar.editarCategoria())
            {
                CATEGORIA categoria = new CATEGORIA();
                categoria = categoriaDAL.obtenerCategoriaPorID(idCategoria);
                form.categoria = categoria;
                form.idCategoria = categoria.ID_CATEGORIA;
                form.descripcion = categoria.DESCRIPCION;
                form.nombre = categoria.NOMBRE_CATEGORIA;
                form.ShowDialog(this);
                cargarCategorias();
            }
        }
    }
}
