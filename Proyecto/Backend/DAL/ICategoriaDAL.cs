using System;
using Backend;
using Backend.Model;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.DAL
{
    public interface ICategoriaDAL
    {

        CATEGORIA obtenerCategoriaPorID(int idCategoria);

        bool addCategoria(CATEGORIA categoria);

        bool deleteCategoria(int idCategoria);

        bool updateCategoria(CATEGORIA categoria);
    }
}
