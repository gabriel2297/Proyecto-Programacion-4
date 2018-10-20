using System;
using Backend.DAL;
using Backend.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Pruebas
{
    [TestClass]
    public class PruebasExtras
    {
        ExtrasDALInterface extrasDAL;
        EXTRA extra;
        [TestMethod]
        public void testAgregarExtra()
        {
            extrasDAL = new ExtrasDALImplementacion();
            bool resultado = extrasDAL.agregarExtra(extra = new EXTRA()
            {
                NOMBRE_EXTRA = "Extra 1",
                PRECIO_EXTRA = 500
            });
            Assert.AreEqual(true, resultado);
        }
    }
}
