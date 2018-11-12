using Backend.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.DAL
{
    public interface IOrdenDAL
    {
        int addOrden(ORDENE orden);
        int deleteOrden(int id);
        int updateOrden(ORDENE order);
        ORDENE getOrder(int id);


    }
}
