using System;
using Backend;
using Backend.Model;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.DAL
{
    public interface IMesaDAL
    {
        MESA obtenerMesaPorId(int idMesa);

        bool addMesa(MESA mesa);

        bool deleteMesa(int idMesa);

        bool updateMesa(MESA mesa);
    }
}
