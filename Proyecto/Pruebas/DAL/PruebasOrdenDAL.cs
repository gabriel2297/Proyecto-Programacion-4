using System;
using Backend.DAL;
using Backend.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Pruebas.DAL
{
    [TestClass]
    public class PruebasOrdenDAL
    {
        IOrdenDAL ordGlob = new OrdenDALImpl();
        [TestMethod]
        public void Add()
        {
            ORDENE or = new ORDENE
            {
                NOMBRE_ORDEN = "OrdenPrueba",
                ID_MESA = 1,
                ID_MESERO = 4
            };
            Assert.AreEqual(ordGlob.addOrden(or),1);     
        }

        [TestMethod]
        public void search()
        {
            ORDENE ord = ordGlob.getOrder(3);          
            Assert.AreEqual(ord.ID_ORDEN, 3);
        }

        [TestMethod]
        public void delete()
        {
            ORDENE or = new ORDENE
            {
                NOMBRE_ORDEN = "OrdenPrueba",
                ID_MESA = 1,
                ID_MESERO = 4
            };
            ordGlob.addOrden(or);
            Assert.AreEqual(1, ordGlob.deleteOrden(or.ID_ORDEN));
        }
        [TestMethod]
        public void update()
        {
            ORDENE or = new ORDENE
            {
                ID_ORDEN = 5,
                NOMBRE_ORDEN = "OrdenPrueba",
                ID_MESA = 1,
                ID_MESERO = 4
            };
            ordGlob.addOrden(or);
            ORDENE ord = new ORDENE
            {
                ID_ORDEN = 5,
                NOMBRE_ORDEN = "PruebaUpdate",
                ID_MESA = 2,
                ID_MESERO = 3
            };
            Assert.AreEqual(1, ordGlob.updateOrden(ord));
        }
    }
}
