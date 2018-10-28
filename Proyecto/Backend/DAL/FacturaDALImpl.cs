using Backend.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Backend.DAL
{
    public class FacturaDALImpl : IFacturaDAL
    {
        public bool addFactura(FACTURA factura)
        {
            using (PROIVEntities db = new PROIVEntities())
            {
                try
                {
                    //agregar una nueva factura
                    db.FACTURAS.Add(factura);

                    //guardar los cambios
                    db.SaveChanges();
                    return true;
                }
                catch (Exception)
                {

                    return false;
                }
            }

        }

        public bool deleteFactura(int idFactura)
        {
            using (PROIVEntities db = new PROIVEntities())
            {
                try
                {
                    //remover de la tabla factura ,la factura que tenga el idFactura que se envio
                    db.FACTURAS.Remove(db.FACTURAS.Single(factura => factura.ID_FACTURA == idFactura));

                    //guardar los cambios
                    db.SaveChanges();

                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public FACTURA obtenerFacturaPorID(int idFactura)
        {
            using (PROIVEntities db = new PROIVEntities())
            {
                try
                {
                    //obtener la factura y gaurdarla en una variable
                    FACTURA factura = db.FACTURAS.Single(lafactura => lafactura.ID_FACTURA == idFactura);
                    return factura;
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }

        public bool updateFactura(FACTURA factura)
        {
            using (PROIVEntities db = new PROIVEntities())
            {
                try
                {
                    //obtener la factura a modificar y guardarlo en una variable
                    FACTURA facturaModificar = db.FACTURAS.Single(lafactura => lafactura.ID_FACTURA == factura.ID_FACTURA);
                    // entity framework empieza a 'trackear' los cambios que se estan realizando, por lo que
                    // nada mas hay que cambiar el nombre en el objeto donde guardamos el resultado del query de arriba
                    facturaModificar.PRECIO_UNIDAD = factura.PRECIO_UNIDAD;
                    facturaModificar.PRECIO_TOTAL = factura.PRECIO_TOTAL;
                    facturaModificar.METODO_PAGO = factura.METODO_PAGO;
                    facturaModificar.MENSAJE = factura.MENSAJE;
                    facturaModificar.NOMBRE_CAJERO = factura.NOMBRE_CAJERO;
                    facturaModificar.TOTAL_CANCELADO = factura.TOTAL_CANCELADO;
                    facturaModificar.VUELTO = factura.VUELTO;
                    facturaModificar.FECHA = factura.FECHA;
                    facturaModificar.ID_ORDEN = factura.ID_ORDEN;


                    //guardar los cambios
                    db.SaveChanges();

                    return true;
                }
                catch (Exception)
                {

                    return false;
                }
            }
        }
    }
}
