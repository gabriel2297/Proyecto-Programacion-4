using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Backend.Model;
using System.Threading.Tasks;

namespace Backend.BLL
{
    public interface IOrdenBLL
    {
        bool addOrden(ORDENE orden);
        bool deleteOrden(int idOrden);
        bool updateOrden(ORDENE orden);
        ORDENE getOrden(int idOrden);
    }
}
