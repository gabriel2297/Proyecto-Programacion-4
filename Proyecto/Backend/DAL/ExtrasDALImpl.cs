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
        PROIVEntities context;

        public void actualizarExtra(EXTRA extra)
        {
            using (context = new PROIVEntities())
            {
                // obtener el extra a modificar y guardarlo en una variable
                EXTRA extraModificar = context.EXTRAS.Single(elExtra => elExtra.ID_EXTRA == extra.ID_EXTRA);

                 // entity framework empieza a 'trackear' los cambios que se estan realizando, por lo que
                 // nada mas hay que cambiar el nombre en el objeto donde guardamos el resultado del query de arriba
                 extraModificar.NOMBRE_EXTRA = extra.NOMBRE_EXTRA;
                 extraModificar.PRECIO_EXTRA = extra.PRECIO_EXTRA;
                 // salvar los cambios
                 context.SaveChanges(); 
            }
        }
    
        public void agregarExtra(EXTRA extra)
        {
            using (context = new PROIVEntities())
            {
                
                context.EXTRAS.Add(extra);
                context.SaveChanges();
                   
            }
        }

        public void eliminarExtra(int id_extra)
        {
            EXTRA extra = this.obtenerExtra(id_extra);
            using(context = new PROIVEntities())
            {

                context.EXTRAS.Attach(extra);
                context.EXTRAS.Remove(extra);
                context.SaveChanges();

              /*  context.EXTRAS.Remove(context.EXTRAS.Single(elExtra => elExtra.ID_EXTRA == id_extra));

                context.SaveChanges();*/
                
              
            }
        }

        public EXTRA obtenerExtra(int id_extra)
        {
            EXTRA result;
            using(context = new PROIVEntities())
            {

                //EXTRA extraMostrar = context.EXTRAS.Single(elExtra => elExtra.ID_EXTRA == id_extra);
                //return extraMostra;

                result = (from c in context.EXTRAS where c.ID_EXTRA == id_extra select c).First();

                return result;
               
                
               
            }
        }

        public List<EXTRA> obtenerExtras()
        {
            List<EXTRA> result;
            using(context = new PROIVEntities())
            {
                result = (from c in context.EXTRAS select c).ToList();
                return result;
            }
        }
    }
}
