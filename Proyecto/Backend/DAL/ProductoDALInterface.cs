using Backend.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.DAL
{
    public interface ProductoDALInterface
    {
        PRODUCTO mostrarProducto(int ID_PRODUCTO);
        void agregarProducto(PRODUCTO producto);
        void actualizarProducto(PRODUCTO producto);
        void eliminarProducto(int ID_PRODUCTO);
    }
}
