using Backend.DAL;
using Backend.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.BLL
{
    public class ProductoBLLImplementacion : ProductoBLLInterface
    {
        IProductoDAL productoDAL;
        public ProductoBLLImplementacion()
        {
            productoDAL = new ProductoDALImplementacion();
        }
        public bool actualizarProducto(PRODUCTO producto)
        {
           
            try
            {
                productoDAL.actualizarProducto(producto);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            

        }

        public bool agregarProducto(PRODUCTO producto)
        {
            try
            {
                productoDAL.agregarProducto(producto);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool eliminarProducto(int ID_PRODUCTO)
        {
            try
            {
                productoDAL.eliminarProducto(ID_PRODUCTO);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public PRODUCTO mostrarProducto(int idProducto)
        {
            try
            {
                return productoDAL.mostrarProducto(idProducto);
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
