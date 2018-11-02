using Backend.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.BLL
{
    public interface IExtrasBLL
    {
        bool agregarExtra(EXTRA extra);
        bool actualizarExtra(EXTRA extra);
        bool eliminarExtra(int id_extra);
        List<EXTRA> GetEXTRAS();
        EXTRA GetEXTRA(int id_extra);

    }
}
