﻿using Backend.DAL;
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
            this.tablaProductos.DataSource = null;
            this.tablaProductos.DataSource = productoDAL.obtenerProductosObjetos();
        }

        private void Productos_Load(object sender, EventArgs e)
        {
            cargarProductos();
        }

        private void agregarBtn_Click(object sender, EventArgs e)
        {
            using (FormsAgregar.agregarProducto form = new FormsAgregar.agregarProducto())
            {
                form.ShowDialog(this);
                cargarProductos();
            }
        }

        private void tablaProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
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
    }
}