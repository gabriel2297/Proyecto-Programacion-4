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

        public bool updateMesa(MESA mesa)
        {
            using (PROIVEntities db = new PROIVEntities())
            {
                try
                {
                    MESA mesaModificar = db.MESAS.Single(lamesa => lamesa.ID_MESA == mesa.ID_MESA);
                    mesaModificar.ID_ESTADO = mesa.ID_ESTADO;

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
