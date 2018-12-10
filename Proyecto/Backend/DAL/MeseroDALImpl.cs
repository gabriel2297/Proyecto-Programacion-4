using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
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
                catch (SqlException)
                {                    
                    return false;
                }
            }
        }

        public bool deleteMesero(int idMesero)
        {
            MESERO m = this.obtenerMeseroPorID(idMesero);
            using (PROIVEntities db = new PROIVEntities())
            {
                try
                {
                    // remover de la tabla de meseros el mesero que tengael ID que se envio
                    db.MESEROS.Attach(m);
                    db.MESEROS.Remove(m);

                    // salvar los cambios
                    db.SaveChanges();
                    return true;
                }
                catch (SqlException)
                {
                    return false;
                }
            }
        }

        public MESERO obtenerMeseroPorID(int idMesero)
        {
            try
            {
                using (PROIVEntities db = new PROIVEntities())
                {

                    // obtener el mesero y guardarlo en una variable
                    MESERO mesero = (from s in db.MESEROS
                                     where s.ID_MESERO == idMesero
                                     select s).First();
                    return mesero;
                }
            }
            catch (System.Exception)
            {

                return null;
            }
           
        }

        public List<MESERO> obtenerMeseros()
        {
            List<MESERO> listaMeseros = new List<MESERO>();
            using(PROIVEntities db = new PROIVEntities())
            {
                listaMeseros = (from meseros in db.MESEROS
                                select meseros).ToList();
                if(listaMeseros.Count > 0)
                {
                    return listaMeseros;
                }
                else
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
                catch (SqlException)
                {
                    return false;
                }
            }
        }
    }
}
