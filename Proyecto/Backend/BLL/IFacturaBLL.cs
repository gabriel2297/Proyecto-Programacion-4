using Backend.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.BLL
{
    public interface IFacturaBLL
    {   
        
        
        /// <summary>
         /// MUESTRA FACTURA POR EL ID
        /// </summary>
        /// <param name="_idFactura">EL ID DE LA FACTURA QUE SE VA A BUSCAR</param>
        /// <returns>
        /// TRUE SI SE ENCONTRO , DE OTRO MODO FALSE
        /// </returns>     
        FACTURA obtenerFacturaPorID(int _idFactura);

        /// <summary>
        /// Agrega una nueva Factura
        /// </summary>
        /// <param name="factura">LA FACTURA QUE SE VA A AGREGAR</param>
        /// <returns>
        /// TRUE SI SE AGREGO , DE OTRO MODO FALSE
        /// </returns>
        bool addFactura(FACTURA factura);

        /// <summary>
        /// MODIFICAR UNA FACTURA
        /// </summary>
        /// <param name="factura">LAFACTURA QUE SE VA A MODIFICAR</param>
        /// <returns>
        /// TRUE SI SE MODIFICA,DE OTRO MODO FALSE
        /// </returns>
        bool updateFactura(FACTURA factura);

        /// <summary>
        /// ELIMINAR FACTURA POR SU ID
        /// </summary>
        /// <param name="idFactura">ID DE LA FACTURA A ELIMINAR </param>
        /// <returns>
        /// TRUE SI SE ELIMINA, DE OTRO MODO FALSE
        /// </returns>
        bool deleteFactura(int idFactura); 
    }
}
