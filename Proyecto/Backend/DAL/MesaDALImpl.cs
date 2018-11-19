using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Backend.Model;

namespace Backend.DAL
{
    public class MesaDALImpl : IMesaDAL
    {
        public bool addMesa(MESA mesa)
        {
            using (PROIVEntities db = new PROIVEntities())
            {
                try
                {
                    db.MESAS.Add(mesa);

                    db.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public bool deleteMesa(int idMesa)
        {
            using (PROIVEntities db = new PROIVEntities())
            {
                try
                {
                    db.MESAS.Remove(db.MESAS.Single(mesa => mesa.ID_MESA == idMesa));

                    db.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

        public string obtenerEstadoMesaPorIdMesa(int idMesa)
        {
            String estadoMesa;
            using(PROIVEntities db = new PROIVEntities())
            {
                estadoMesa = (from mesa in db.MESAS
                              join estados in db.ESTADO_MESAS on mesa.ID_ESTADO equals estados.ID_ESTADO
                              where mesa.ID_MESA == idMesa
                              select estados.ESTADO).First().ToString();
                if(estadoMesa.Length > 0)
                {
                    return estadoMesa;
                }
                else
                {
                    return null;
                }
            }
        }

        public List<ESTADO_MESAS> obtenerEstados()
        {
            List<ESTADO_MESAS> lista = new List<ESTADO_MESAS>();
            using(PROIVEntities db = new PROIVEntities())
            {
                lista = (from estados in db.ESTADO_MESAS
                         select estados).ToList();
                if(lista.Count > 0)
                {
                    return lista;
                }
                else
                {
                    return null;
                }
            }
        }

        public MESA obtenerMesaPorId(int idMesa)
        {
            using (PROIVEntities db = new PROIVEntities())
            {
                try
                {
                    MESA mesa = db.MESAS.Single(lamesa => lamesa.ID_MESA == idMesa);
                    return mesa;
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }

        public List<Object> obtenerMesas()
        {
            using (PROIVEntities db = new PROIVEntities())
            {
                var listaMesas = (from mesas in db.MESAS
                                  join estado_mesas in db.ESTADO_MESAS on mesas.ID_ESTADO equals estado_mesas.ID_ESTADO
                                  select new
                                  {
                                      Mesa = mesas.ID_MESA,
                                      Capacidad = mesas.CAPACIDAD,
                                      Estado = estado_mesas.ESTADO
                                  }
                                  ).ToList<Object>();
                if(listaMesas.Count > 0)
                {
                    return listaMesas;
                }
                else
                {
                    return null;
                }
            }
        }

        public bool updateMesa(MESA mesa)
        {
            using (PROIVEntities db = new PROIVEntities())
            {
                try
                {
                    MESA mesaModificar = db.MESAS.Single(lamesa => lamesa.ID_MESA == mesa.ID_MESA);
                    mesaModificar.ID_ESTADO = mesa.ID_ESTADO;
                    mesaModificar.CAPACIDAD = mesa.CAPACIDAD;
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
