﻿using Backend.DAL;
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
        private IProductoDAL productoDAL = new ProductoDALImpl();
        agregarOrden formOrden;

        public agregarProductosOrden()
        {
            InitializeComponent();
        }

        private void cargarTabla()
        {
            this.tablaProductos.DataSource = null;
            if (nombreTxt.Text.Length > 0)
            {
                this.tablaProductos.DataSource = productoDAL.buscarProductos(nombreTxt.Text);
            }
        }

        private void nombreTxt_KeyUp(object sender, KeyEventArgs e)
        {
            cargarTabla();
        }

        private void cancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        string id;
        string nombre;
        string precio;
        string descripcion;
        string[] datos = new string[4];
        
        private void tablaPorductos_Click(object sender, DataGridViewCellEventArgs e)
        {
            id = tablaProductos.Rows[e.RowIndex].Cells[0].Value.ToString();
            nombre = tablaProductos.Rows[e.RowIndex].Cells[1].Value.ToString();
            precio = tablaProductos.Rows[e.RowIndex].Cells[2].Value.ToString();
            descripcion = tablaProductos.Rows[e.RowIndex].Cells[3].Value.ToString();


        }

      
        private void agregarBtn_Click(object sender, EventArgs e)
        {
            formOrden = new agregarOrden();

            /*datos[0] = id;
            datos[1] = nombre;
            datos[2] = precio;
            datos[3] = descripcion;*/

            DataGridViewRow fila = new DataGridViewRow();
            fila.CreateCells(formOrden.tablaProductos);
            fila.Cells[0].Value = id;
            fila.Cells[1].Value = nombre;
            fila.Cells[2].Value = precio;
            fila.Cells[3].Value = descripcion;
            formOrden.tablaProductos.Rows.Add(fila);


            //formOrden.tablaProductos.Rows.Add(datos);
            formOrden.ShowDialog(this);

            //formOrden.Visible = true;
            this.Close();
        }
    }
}