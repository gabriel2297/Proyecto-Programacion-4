using Backend.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.BLL
{
    public interface IProductoBLL
    {
        PRODUCTO mostrarProducto(int ID_PRODUCTO);
        bool agregarProducto(PRODUCTO producto);
        bool actualizarProducto(PRODUCTO producto);
        bool eliminarProducto(int ID_PRODUCTO);
    }
}
