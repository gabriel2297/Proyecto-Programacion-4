using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Backend.Model;

namespace Backend.DAL
{
    public class ExtrasDALImpl : IExtrasDAL
    {
        PROIVEntities extraDB;

        public void actualizarExtra(EXTRA extra)
        {
            using (extraDB = new PROIVEntities())
            {
                // obtener el extra a modificar y guardarlo en una variable
                EXTRA extraModificar = extraDB.EXTRAS.Single(elExtra => elExtra.ID_EXTRA == extra.ID_EXTRA);

                // entity framework empieza a 'trackear' los cambios que se estan realizando, por lo que
                // nada mas hay que cambiar el nombre en el objeto donde guardamos el resultado del query de arriba
                extraModificar.NOMBRE_EXTRA = extra.NOMBRE_EXTRA;
                extraModificar.PRECIO_EXTRA = extra.PRECIO_EXTRA;
                // salvar los cambios
                extraDB.SaveChanges();
            }
        }
    
        public void agregarExtra(EXTRA extra)
        {
            using (extraDB = new PROIVEntities())
            {
                
                extraDB.EXTRAS.Add(extra);
                extraDB.SaveChanges();
                   
            }
        }

        public void eliminarExtra(int id_extra)
        {
            using(extraDB = new PROIVEntities())
            {

               
                extraDB.EXTRAS.Remove(extraDB.EXTRAS.Single(elExtra => elExtra.ID_EXTRA == id_extra));

                extraDB.SaveChanges();
                
              
            }
        }

        public EXTRA obtenerExtra(int id_extra)
        {
            using(extraDB = new PROIVEntities())
            {
                try
                {
                    EXTRA extraMostrar = extraDB.EXTRAS.Single(elExtra => elExtra.ID_EXTRA == id_extra);
                    return extraMostrar;
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }
    }
}
