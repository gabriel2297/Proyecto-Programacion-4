using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Backend.DAL;
using Backend.Model;

namespace Backend.BLL
{
    public class FacturaBLLImpl : IFacturaBLL
    {
        private IFacturaDAL facturaDAL = new FacturaDALImpl();

        public bool addFactura(FACTURA factura)
        {
            try
            {
                return facturaDAL.addFactura(factura);
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool deleteFactura(int idFactura)
        {
            try
            {
                return facturaDAL.deleteFactura(idFactura);
            }
            catch (Exception)
            {

                return false;
            }
        }

        public FACTURA obtenerFacturaPorID(int _idFactura)
        {
            try
            {
                return obtenerFacturaPorID(_idFactura);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool updateFactura(FACTURA factura)
        {
            try
            {
                return facturaDAL.updateFactura(factura);
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
