using System;
using Backend.DAL;
using Backend.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Pruebas
{
    [TestClass]
    public class PruebasExtras
    {
        IExtrasDAL extrasDAL;
        EXTRA extra;
        [TestMethod]
        public void testAgregarExtra()
        {
            extrasDAL = new ExtrasDALImpl();
            bool resultado = extrasDAL.agregarExtra(extra = new EXTRA()
            {
                NOMBRE_EXTRA = "Extra 1",
                PRECIO_EXTRA = 500
            });
            Assert.AreEqual(true, resultado);
        }

        [TestMethod]
        public void testActualizarExtra()
        {
            extrasDAL = new ExtrasDALImpl();
            bool resultado = extrasDAL.actualizarExtra(extra = new EXTRA() {
                ID_EXTRA = 2,
                NOMBRE_EXTRA="Extra 2",
                PRECIO_EXTRA = 450
            });

            Assert.AreEqual(true, resultado);
        }

        [TestMethod]

        public void testEliminarExtra()
        {
            extrasDAL = new ExtrasDALImpl();

            bool resultado = extrasDAL.eliminarExtra(3);

            Assert.AreEqual(true, resultado);
        }

        [TestMethod]

        public void mostrarExtra()
        {
            extrasDAL = new ExtrasDALImpl();
            string nombreExtra = extrasDAL.obtenerExtra(2).NOMBRE_EXTRA;

            Assert.AreEqual("Extra 2", nombreExtra);
        }
    }
}
