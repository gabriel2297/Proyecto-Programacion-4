using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Backend.DAL;
using Backend.Model;

namespace Backend.BLL
{
    public class MeseroBLLImpl : IMeseroBLL
    {
        private IMeseroDAL meseroDAL = new MeseroDALImpl();

        public bool addMesero(MESERO mesero)
        {
            try
            {
                return meseroDAL.addMesero(mesero);
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool deleteMesero(int idMesero)
        {
            try
            {
                return meseroDAL.deleteMesero(idMesero);
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool obtenerMeseroPorID(int idMesero)
        {
            try
            {
                return obtenerMeseroPorID(idMesero);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool updateMesero(MESERO mesero)
        {
            try
            {
                return meseroDAL.updateMesero(mesero);
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
