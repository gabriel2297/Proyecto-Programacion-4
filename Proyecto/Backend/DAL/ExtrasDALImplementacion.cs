using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Backend.Model;

namespace Backend.DAL
{
    public class ExtrasDALImplementacion : ExtrasDALInterface
    {
        PROIVEntities extraDB;

        public bool actualizarExtra(EXTRA extra)
        {
            throw new NotImplementedException();
        }

        public bool agregarExtra(EXTRA extra)
        {
            using (extraDB = new PROIVEntities())
            {
                try
                {
                    extraDB.EXTRAS.Add(extra);
                    extraDB.SaveChanges();
                    return true;
                }
                catch (Exception)
                {

                    return false;
                }
            }
        }

        public bool eliminarExtra(int id_extra)
        {
            throw new NotImplementedException();
        }

        public EXTRA obtenerExtra(int id_extra)
        {
            throw new NotImplementedException();
        }
    }
}
