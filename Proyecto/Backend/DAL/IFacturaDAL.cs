using Backend.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.DAL
{
   public interface IFacturaDAL
    {
        /// <summary>
        /// Obtener una factura por su id
        /// </summary>
        /// <param name="idFactura">El ID de la factura que se quiere buscar</param>
        /// <returns>
        /// MESERO, si se encontro el mesero, de otra manera Null
        /// </returns>
        FACTURA obtenerFacturaPorID(int idFactura);

        /// <summary>
        /// Agregar una nueva Factura
        /// </summary>
        /// <param name="factura">La factura que se quiere agregar</param>
        /// <returns>
        /// True, si se agrego la factura, de otra manera False.
        /// </returns>
        bool addFactura(FACTURA factura);

        /// <summary>
        /// Eliminar una factura por su ID
        /// </summary>
        /// <param name="idFactura">El ID de la factura que se quiere eliminar</param>
        /// <returns>
        /// True, si se elimino la factura, de otra manera False.
        /// </returns>
        bool deleteFactura(int idFactura);

        /// <summary>
        /// Modificar una factura
        /// </summary>
        /// <param name="factura">La factura con todos los datos a modificar</param>
        /// <returns>
        /// True, si se modifico la factura, de otra manera False.
        /// </returns>
        bool updateFactura(FACTURA factura);

        /// <summary>
        /// Obtener todas las facturas
        /// </summary>
        /// <returns>
        /// Una lista con facturas, null si no hay.
        /// </returns>
        List<FACTURA> obtenerFacturas();
    }
}
