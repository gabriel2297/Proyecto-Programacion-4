using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Backend.Model;

namespace Backend.DAL
{
    public class ProductoXOrdenDALImpl : IProductoXOrdenDAL
    {
        private PROIVEntities context;
        public int addProdxOrd(PRODUCTO_X_ORDEN ProxOrd)
        {
            try
            {
                using (context = new PROIVEntities())
                {
                    context.PRODUCTO_X_ORDEN.Add(ProxOrd);
                    context.SaveChanges();
                }
                return 1;
            }
            catch (Exception e)
            {

                return 0;
            }
        }

        public int deleteProdxOrd(int idProd, int idOrd)
        {
            try
            {
                PRODUCTO_X_ORDEN temp = this.getProdxOrd(idProd, idOrd);
                using (context = new PROIVEntities())
                {
                    context.PRODUCTO_X_ORDEN.Attach(temp);
                    context.PRODUCTO_X_ORDEN.Remove(temp);
                    context.SaveChanges();
                }
                return 1;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public PRODUCTO_X_ORDEN getProdxOrd(int idProd, int idOrd)
        {
            PRODUCTO_X_ORDEN temp;
            try
            {
                using (context = new PROIVEntities())
                {
                    temp = (from c in context.PRODUCTO_X_ORDEN
                            where c.ID_ORDEN == idOrd && c.ID_PRODUCTO == idProd
                            select c).First();
                }
                return temp;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int updateProdxOrd(PRODUCTO_X_ORDEN ProxOrd)
        {
            try
            {
                using (context = new PROIVEntities())
                {
                    context.Entry(ProxOrd).State = System.Data.Entity.EntityState.Modified;
                    context.SaveChanges();
                }
                return 1;
            }
            catch (Exception)
            {
                return 0;
            }
        }
    }
}
