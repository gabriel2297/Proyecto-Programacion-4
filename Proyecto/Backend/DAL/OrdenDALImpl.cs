using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Backend.Model;

namespace Backend.DAL
{
    public class OrdenDALImpl : IOrdenDAL
    {
        private PROIVEntities context;
        public int addOrden(ORDENE orden)
        {
            try
            {
                using (context = new PROIVEntities())
                {
                    context.ORDENES.Add(orden);
                    context.SaveChanges();
                }
                return 1;
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        public int deleteOrden(int id)
        {
            try
            {
                ORDENE or = this.getOrder(id);
                using (context = new PROIVEntities())
                {
                    context.ORDENES.Attach(or);
                    context.ORDENES.Remove(or);
                    context.SaveChanges();
                }
                return 1;
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        public ORDENE getOrder(int id)
        {
            try
            {
                ORDENE or;
                using (context = new PROIVEntities())
                {
                    or = (from c in context.ORDENES
                          where c.ID_ORDEN == id
                          select c).First();
                }
                return or;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<ORDENE> obtenerOrdenes()
        {
            List<ORDENE> listaOrdenes = new List<ORDENE>();
            using  (context = new PROIVEntities())
            {
                listaOrdenes = (from o in context.ORDENES
                                select o).ToList();
                if (listaOrdenes.Count > 0)
                {
                    return listaOrdenes;
                }
                else
                {
                    return null;
                }
            }
        }

        public int updateOrden(ORDENE order)
        {
            try
            {
                using (context = new PROIVEntities())
                {
                    context.Entry(order).State = System.Data.Entity.EntityState.Modified;
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
