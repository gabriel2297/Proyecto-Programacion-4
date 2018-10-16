using Backend.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.DAL
{
    public interface IMeseroDAL
    {
        /// <summary>
        /// Obtener un mesero por su ID
        /// </summary>
        /// <param name="idMesero">El ID del mesero que se quiere buscar</param>
        /// <returns>
        /// MESERO, si se encontro el mesero, de otra manera Null
        /// </returns>
        MESERO obtenerMeseroPorID(int idMesero);

        /// <summary>
        /// Agregar un nuevo mesero
        /// </summary>
        /// <param name="mesero">El mesero que se quiere agregar</param>
        /// <returns>
        /// True, si se agrego el mesero, de otra manera False.
        /// </returns>
        bool addMesero(MESERO mesero);

        /// <summary>
        /// Eliminar un mesero por ID
        /// </summary>
        /// <param name="idMesero">El ID del mesero que se quiere eliminar</param>
        /// <returns>
        /// True, si se elimino el mesero, de otra manera False.
        /// </returns>
        bool deleteMesero(int idMesero);

        /// <summary>
        /// Modificar un mesero
        /// </summary>
        /// <param name="mesero">El mesero con todos los datos a modificar</param>
        /// <returns>
        /// True, si se modifico el mesero, de otra manera False.
        /// </returns>
        bool updateMesero(MESERO mesero);
    }
}
