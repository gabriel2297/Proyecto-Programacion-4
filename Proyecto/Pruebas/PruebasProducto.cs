using System;
using Backend.BLL;
using Backend.DAL;
using Backend.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Pruebas
{
    [TestClass]
    public class PruebasProducto
    {
        ProductoBLLInterface productoBLL = new ProductoBLLImplementacion();
        PRODUCTO producto;
       
        [TestMethod]
        public void actualizarProducto()
        {
            bool resultado;
            resultado = productoBLL.actualizarProducto(producto = new PRODUCTO() {
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
            resultado = productoBLL.agregarProducto(producto = new PRODUCTO() {
                NOMBRE_PRODUCTO = "Melon",
                PRECIO_PRODUCTO = 120,
                CANTIDAD_VENTAS = 85,
                ID_EXTRA = null,
                ID_CATEGORIA = null
            });
            Assert.AreEqual(true, resultado);
        }

        [TestMethod]

        public void eliminarProducto()
        {
            bool resultado = productoBLL.eliminarProducto(7);
            Assert.AreEqual(true, resultado);
        }

        [TestMethod]
        public void obtenerProducto()
        {
            int resultado = productoBLL.mostrarProducto(2).ID_PRODUCTO;
            Assert.AreEqual(2, resultado);
        }
    }
}
