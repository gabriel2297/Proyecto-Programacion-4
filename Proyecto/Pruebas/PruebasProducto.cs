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
            bool resultado;
            resultado = productoDAL.actualizarProducto(producto = new PRODUCTO() {
                ID_PRODUCTO =2,
                NOMBRE_PRODUCTO = "Pan blanco 3kg",
                PRECIO_PRODUCTO = 4500,
                CANTIDAD_VENTAS = 20,
                ID_EXTRA = null,
                ID_CATEGORIA = null
            });
            Assert.AreEqual(true, resultado);
        }
    }
}
