using System;
using Backend.Model;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.DAL
{
    public interface IProductoXOrdenDAL
    {
        int addProdxOrd(PRODUCTO_X_ORDEN ProxOrd);
        int deleteProdxOrd(int idProd, int idOrd);
        int updateProdxOrd(PRODUCTO_X_ORDEN ProxOrd);
        PRODUCTO_X_ORDEN getProdxOrd(int idProd, int idOrd);
    }
}
