using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Backend.DAL;
using Backend.Model;

namespace Backend.BLL
{
    public class ExtrasBLLImpl : IExtrasBLL
    {
        IExtrasDAL extraDAL = new ExtrasDALImpl();
       
        public bool actualizarExtra(EXTRA extra)
        {
            try
            {
                extraDAL.actualizarExtra(extra);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool agregarExtra(EXTRA extra)
        {
            try
            {
                extraDAL.agregarExtra(extra);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool eliminarExtra(int id_extra)
        {
            try
            {
                extraDAL.eliminarExtra(id_extra);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public EXTRA GetEXTRA(int id_extra)
        {
            try
            {
                return extraDAL.obtenerExtra(id_extra);
                 
            }
            catch (Exception)
            {

                return null;
            }
        }

        public List<EXTRA> GetEXTRAS()
        {
            try
            {
                return extraDAL.obtenerExtras();
            }
            catch (Exception)
            {

                return null;
            }
        }
    }
}
