using System;
using Backend.DAL;
using Backend.Model;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.BLL
{
    public class OrdenBLLImpl : IOrdenBLL
    {
        IOrdenDAL glob = new OrdenDALImpl();
        public bool addOrden(ORDENE orden)
        {
            try
            {
                int prueb = glob.addOrden(orden);
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

        public bool deleteOrden(int idOrden)
        {
            try
            {
                int prueb = glob.deleteOrden(idOrden);
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

        public ORDENE getOrden(int idOrden)
        {
            try
            {
                return glob.getOrder(idOrden);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool updateOrden(ORDENE orden)
        {
            try
            {
                int prueb = glob.updateOrden(orden);
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
