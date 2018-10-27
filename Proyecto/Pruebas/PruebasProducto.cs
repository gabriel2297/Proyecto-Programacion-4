using System;
using Backend.DAL;
using Backend.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Pruebas
{
    [TestClass]
    public class PruebasProducto
    {
        ProductoDALInterface productoDAL = new ProductoDALImplementacion();
        PRODUCTO producto;
       
        [TestMethod]
        public void actualizarProducto()
        {
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

        [TestMethod]
        public void agregarProducto()
        {
            bool resultado;
            resultado = productoDAL.agregarProducto(producto = new PRODUCTO() {
                NOMBRE_PRODUCTO = "Frijoles negros tio pelon",
                PRECIO_PRODUCTO = 1500,
                CANTIDAD_VENTAS = 85,
                ID_EXTRA = null,
                ID_CATEGORIA = null
            });
            Assert.AreEqual(true, resultado);
        }

        [TestMethod]

        public void eliminarProducto()
        {
            bool resultado = productoDAL.eliminarProducto(3);
            Assert.AreEqual(true, resultado);
        }

        [TestMethod]
        public void obtenerProducto()
        {
            int resultado = productoDAL.mostrarProducto(2).ID_PRODUCTO;
            Assert.AreEqual(2, resultado);
        }
    }
}
