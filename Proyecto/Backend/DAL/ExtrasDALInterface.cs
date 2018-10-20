using Backend.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.DAL
{
    public interface ExtrasDALInterface
    {
        EXTRA obtenerExtra(int id_extra);
        bool agregarExtra(EXTRA extra);
        bool actualizarExtra(EXTRA extra);
        bool eliminarExtra(int id_extra);

    }
}
