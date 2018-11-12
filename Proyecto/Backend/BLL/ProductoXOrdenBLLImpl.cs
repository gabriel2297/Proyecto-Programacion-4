using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Backend.Model;
using Backend.DAL;

namespace Backend.BLL
{
    public class ProductoXOrdenBLLImpl : IProductoXOrdenBLL
    {
        IProductoXOrdenDAL glob = new ProductoXOrdenDALImpl();
        public bool addProdxOrd(PRODUCTO_X_ORDEN prodxOrd)
        {
            try
            {
                int prueb = glob.addProdxOrd(prodxOrd);
                if (prueb == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool deleteProdxOrd(int idProd, int idOrd)
        {
            try
            {
                int prueb = glob.deleteProdxOrd(idProd, idOrd);
                if (prueb == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public PRODUCTO_X_ORDEN getProdxOrd(int idProd, int idOrd)
        {
            try
            {
                return glob.getProdxOrd(idProd, idOrd);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool updateProdxOrd(PRODUCTO_X_ORDEN prodxOrd)
        {
            try
            {
                int prueb = glob.updateProdxOrd(prodxOrd);
                if (prueb == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
