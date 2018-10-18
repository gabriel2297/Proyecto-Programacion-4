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
        bool agregarProducto(PRODUCTO producto);
        bool actualizarProducto(PRODUCTO producto);
        bool eliminarProducto(int ID_PRODUCTO);
    }
}
