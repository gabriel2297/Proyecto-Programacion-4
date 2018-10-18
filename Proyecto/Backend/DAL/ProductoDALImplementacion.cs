using Backend.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.DAL
{
    public class ProductoDALImplementacion : ProductoDALInterface
    {
        
        PROIVEntities productoDB;

        public ProductoDALImplementacion()
        {
         
            
        }

        public bool actualizarProducto(PRODUCTO producto)
        {
            using (productoDB = new PROIVEntities())
            {
                try
                {
                     // obtener el mesero a modificar y guardarlo en una variable
                    PRODUCTO productoModificar = productoDB.PRODUCTOS.Single(elProducto => elProducto.ID_PRODUCTO==producto.ID_PRODUCTO);

                    // entity framework empieza a 'trackear' los cambios que se estan realizando, por lo que
                    // nada mas hay que cambiar el nombre en el objeto donde guardamos el resultado del query de arriba
                    productoModificar.NOMBRE_PRODUCTO= producto.NOMBRE_PRODUCTO;
                    // salvar los cambios
                    productoDB.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
            
        }

        public bool agregarProducto(PRODUCTO producto)
        {
            using (productoDB = new PROIVEntities())
            {
                try
                {
                    return true;

                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        public bool eliminarProducto(int ID_PRODUCTO)
        {
            using (productoDB = new PROIVEntities())
            {
                try
                {
                    return true;
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        public PRODUCTO mostrarProducto(int ID_PRODUCTO)
        {
            using (productoDB = new PROIVEntities())
            {
                try
                {
                    
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }
    }
}
