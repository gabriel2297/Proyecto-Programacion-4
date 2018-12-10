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
    public partial class editarCategoria : Form
    {
        private ICategoriaDAL categoriaDAL = new CategoriaDALImpl();
        public CATEGORIA categoria = new CATEGORIA();
        public string nombre, descripcion;
        public int idCategoria;

        private void cancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public editarCategoria()
        {
            InitializeComponent();
        }

        private void editarCategoria_Load(object sender, EventArgs e)
        {
            try
            {
                descripcionTxt.Text = descripcion;
                nombreTxt.Text = nombre;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void editarBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = this.nombreTxt.Text;
                string descripcion = this.descripcionTxt.Text;

                if (nombre.Length > 0 || descripcion.Length > 0)
                {
                    CATEGORIA categoria = new CATEGORIA();
                    categoria.ID_CATEGORIA = idCategoria;
                    categoria.DESCRIPCION = descripcion;
                    categoria.NOMBRE_CATEGORIA = nombre;
                    if (categoriaDAL.updateCategoria(categoria))
                    {
                        MessageBox.Show("Categoria modificada");
                        this.Close();
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            
        }

    }
}
