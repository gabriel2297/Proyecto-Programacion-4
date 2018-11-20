using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Backend.Model;

namespace Backend.DAL
{
    public class CategoriaDALImpl : ICategoriaDAL
    {
        public bool addCategoria(CATEGORIA categoria)
        {
            using (PROIVEntities db = new PROIVEntities())
            {
                try
                {
                    db.CATEGORIAS.Add(categoria);

                    db.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public bool deleteCategoria(int idCategoria)
        {
            using (PROIVEntities db = new PROIVEntities())
            {
                try
                {
                    db.CATEGORIAS.Remove(db.CATEGORIAS.Single(categoria => categoria.ID_CATEGORIA == idCategoria));

                    db.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public CATEGORIA obtenerCategoriaPorID(int idCategoria)
        {
            using (PROIVEntities db = new PROIVEntities())
            {
                try
                {
                    CATEGORIA categoria = db.CATEGORIAS.Single(lacategoria => lacategoria.ID_CATEGORIA == idCategoria);
                    return categoria;
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }

        public List<CATEGORIA> obtenerCategorias()
        {
            using(PROIVEntities db = new PROIVEntities())
            {
                try
                {
                    List<CATEGORIA> lista = new List<CATEGORIA>();
                    lista = (from categorias in db.CATEGORIAS
                             select categorias).ToList();
                    if(lista.Count > 0)
                    {
                        return lista;
                    }
                    else
                    {
                        return null;
                    }
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }

        public bool updateCategoria(CATEGORIA categoria)
        {
            using (PROIVEntities db = new PROIVEntities())
            {
                try
                {
                    CATEGORIA categoriaModificar = db.CATEGORIAS.Single(lacategoria => lacategoria.ID_CATEGORIA == categoria.ID_CATEGORIA);
                    categoriaModificar.NOMBRE_CATEGORIA = categoria.NOMBRE_CATEGORIA;
                    categoriaModificar.DESCRIPCION = categoria.DESCRIPCION;
                    db.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
    }
}
