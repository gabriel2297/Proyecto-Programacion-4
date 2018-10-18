using System;
using Backend.DAL;
using Backend.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Pruebas
{
    [TestClass]
    public class PruebasProducto
    {
        [TestMethod]
        public void actualizarProducto()
        {
            ProductoDALInterface productoDAL = new ProductoDALImplementacion();
            PRODUCTO producto;

            productoDAL.actualizarProducto(producto = new PRODUCTO() {
                ID_PRODUCTO = 2,
                NOMBRE_PRODUCTO = "Arroz blanco"
            });
        }
    }
}
