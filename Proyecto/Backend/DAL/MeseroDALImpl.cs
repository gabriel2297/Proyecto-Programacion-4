using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Backend.Model;

namespace Backend.DAL
{
    public class MeseroDALImpl : IMeseroDAL
    {
        public bool addMesero(MESERO mesero)
        {
            using (PROIVEntities db = new PROIVEntities())
            {
                try
                {
                    // agregar un nuevo mesero
                    db.MESEROS.Add(mesero);

                    // guardar los cambios
                    db.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public bool deleteMesero(int idMesero)
        {
            using (PROIVEntities db = new PROIVEntities())
            {
                try
                {
                    // remover de la tabla de meseros el mesero que tengael ID que se envio
                    db.MESEROS.Remove(db.MESEROS.Single(mesero => mesero.ID_MESERO == idMesero));

                    // salvar los cambios
                    db.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public MESERO obtenerMeseroPorID(int idMesero)
        {
            using (PROIVEntities db = new PROIVEntities())
            {
                try
                {
                    // obtener el mesero y guardarlo en una variable
                    MESERO mesero = db.MESEROS.Single(elMesero => elMesero.ID_MESERO == idMesero);
                    return mesero;
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }

        public bool updateMesero(MESERO mesero)
        {
            using (PROIVEntities db = new PROIVEntities())
            {
                try
                {
                    // obtener el mesero a modificar y guardarlo en una variable
                    MESERO meseroModificar = db.MESEROS.Single(elMesero => elMesero.ID_MESERO == mesero.ID_MESERO);

                    // entity framework empieza a 'trackear' los cambios que se estan realizando, por lo que
                    // nada mas hay que cambiar el nombre en el objeto donde guardamos el resultado del query de arriba
                    meseroModificar.NOMBRE_MESERO = mesero.NOMBRE_MESERO;

                    // salvar los cambios
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
