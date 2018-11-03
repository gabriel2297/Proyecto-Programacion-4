using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Backend.Model;

namespace Backend.BLL
{
    public class ExtrasBLLImpl : IExtrasBLL
    {
        IExtrasBLL extraBLL = new ExtrasBLLImpl();
        EXTRA extra;
        public bool actualizarExtra(EXTRA extra)
        {
            try
            {
                extraBLL.actualizarExtra(extra);
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
                extraBLL.agregarExtra(extra);
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
                extraBLL.eliminarExtra(id_extra);
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
                return extraBLL.GetEXTRA(id_extra);
                 
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
                return extraBLL.GetEXTRAS();
            }
            catch (Exception)
            {

                return null;
            }
        }
    }
}
