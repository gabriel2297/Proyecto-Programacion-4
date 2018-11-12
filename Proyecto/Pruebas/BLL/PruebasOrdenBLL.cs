using System;
using Backend.BLL;
using Backend.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Pruebas.BLL
{
    [TestClass]
    public class PruebasOrdenBLL
    {
        IOrdenBLL glob = new OrdenBLLImpl();
        [TestMethod]
        public void add()
        {
            ORDENE or = new ORDENE
            {
                NOMBRE_ORDEN = "OrdenPrueba",
                ID_MESA = 1,
                ID_MESERO = 4
            };
            Assert.AreEqual(true, glob.addOrden(or));
        }

        [TestMethod]
        public void search()
        {
            ORDENE or = glob.getOrden(1);
            Assert.AreEqual("Gabriel", or.NOMBRE_ORDEN);
        }

        [TestMethod]
        public void delete()
        {
            ORDENE or = new ORDENE
            {
                NOMBRE_ORDEN = "PruebaDelete",
                ID_MESA = 1,
                ID_MESERO = 4
            };
            glob.addOrden(or);
            Assert.AreEqual(true, glob.deleteOrden(or.ID_ORDEN));
        }

        [TestMethod]
        public void update()
        {
            ORDENE or = new ORDENE
            {
                ID_ORDEN = 5,
                NOMBRE_ORDEN = "Ignacio",
                ID_MESA = 2,
                ID_MESERO = 1
            };
            Assert.AreEqual(true, glob.updateOrden(or));
        }
    }
}
