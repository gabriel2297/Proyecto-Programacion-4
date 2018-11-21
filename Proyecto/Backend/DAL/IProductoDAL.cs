using Backend.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.DAL
{
    public interface IProductoDAL
    {
        PRODUCTO mostrarProducto(int ID_PRODUCTO);
        void agregarProducto(PRODUCTO producto);
        void actualizarProducto(PRODUCTO producto);
        void eliminarProducto(int ID_PRODUCTO);
        List<PRODUCTO> obtenerProductos();
        List<Object> obtenerProductosObjetos();
        List<object> buscarProductos(String busqueda);
    }
}
