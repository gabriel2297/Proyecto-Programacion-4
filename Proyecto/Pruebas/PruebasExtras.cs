using System;
using Backend.BLL;
using Backend.DAL;
using Backend.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Pruebas
{
    [TestClass]
    public class PruebasExtras
    {
        IExtrasBLL extrasBLL = new ExtrasBLLImpl();
        EXTRA extra;
        [TestMethod]
        public void testAgregarExtra()
        {
            
            bool resultado = extrasBLL.agregarExtra(extra = new EXTRA()
            {
                NOMBRE_EXTRA = "Extra 3",
                PRECIO_EXTRA = 5200
            });
            Assert.AreEqual(true, resultado);
        }

        [TestMethod]
        public void testActualizarExtra()
        {
           
            bool resultado = extrasBLL.actualizarExtra(extra = new EXTRA() {
                ID_EXTRA = 6,
                NOMBRE_EXTRA="Extra 2",
                PRECIO_EXTRA = 450
            });

            Assert.AreEqual(true, resultado);
        }

        [TestMethod]

        public void testEliminarExtra()
        {
        

            bool resultado = extrasBLL.eliminarExtra(6);

            Assert.AreEqual(true, resultado);
        }

        [TestMethod]

        public void mostrarExtra()
        {
            
            string nombreExtra = extrasBLL.GetEXTRA(5).NOMBRE_EXTRA;

            Assert.AreEqual("Extra 1", nombreExtra);
        }

        [TestMethod]

        public void mostrarExtras()
        {

            int cantidad = extrasBLL.GetEXTRAS().Count;

            Assert.AreEqual(5, cantidad);
        }
    }
}
