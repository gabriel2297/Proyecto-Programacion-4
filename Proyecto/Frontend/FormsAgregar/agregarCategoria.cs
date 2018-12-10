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
    public partial class agregarCategoria : Form
    {
        private ICategoriaDAL categoriaDAL = new CategoriaDALImpl();
        public agregarCategoria()
        {
            InitializeComponent();
        }

        private void cancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void agregarBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = this.nombreTxt.Text;
                string descripcion = this.descripcionTxt.Text;

                if (nombre.Length > 0 || descripcion.Length > 0)
                {
                    CATEGORIA categoria = new CATEGORIA();
                    categoria.DESCRIPCION = descripcion;
                    categoria.NOMBRE_CATEGORIA = nombre;
                    if (categoriaDAL.addCategoria(categoria))
                    {
                        MessageBox.Show("Categoria agregada");
                        this.Close();
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void agregarCategoria_Load(object sender, EventArgs e)
        {

        }
    }
}
