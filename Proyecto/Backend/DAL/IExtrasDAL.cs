using Backend.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.DAL
{
    public interface IExtrasDAL
    {
        EXTRA obtenerExtra(int id_extra);
        void agregarExtra(EXTRA extra);
        void actualizarExtra(EXTRA extra);
        void eliminarExtra(int id_extra);

    }
}
