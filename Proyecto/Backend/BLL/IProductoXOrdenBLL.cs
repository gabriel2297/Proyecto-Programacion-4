using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Backend.Model;

namespace Backend.BLL
{
    public interface IProductoXOrdenBLL
    {
        bool addProdxOrd(PRODUCTO_X_ORDEN prodxOrd);
        bool deleteProdxOrd(int idProd, int idOrd);
        bool updateProdxOrd(PRODUCTO_X_ORDEN prodxOrd);
        PRODUCTO_X_ORDEN getProdxOrd(int idProd, int idOrd);

    }
}
