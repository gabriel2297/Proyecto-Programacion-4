using System;
using Backend.BLL;
using Backend.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Pruebas.BLL
{
    [TestClass]
    public class PruebasProductoXOrdenBLL
    {
        IProductoXOrdenBLL glob = new ProductoXOrdenBLLImpl();
        [TestMethod]
        public void add()
        {
            PRODUCTO_X_ORDEN temp = new PRODUCTO_X_ORDEN
            {
                ID_ORDEN = 4,
                ID_PRODUCTO = 2,
                CANTIDAD_PRODUCTO = 4
            };
            Assert.AreEqual(true, glob.addProdxOrd(temp));
        }
        
        [TestMethod]
        public void search()
        {
            PRODUCTO_X_ORDEN temp = glob.getProdxOrd(1, 2);
            Assert.AreEqual(4, temp.CANTIDAD_PRODUCTO);
        }

        [TestMethod]
        public void delete()
        {
            Assert.AreEqual(true, glob.deleteProdxOrd(5,3));
        }

        [TestMethod]
        public void update()
        {
            PRODUCTO_X_ORDEN temp = new PRODUCTO_X_ORDEN
            {
                ID_ORDEN = 1,
                ID_PRODUCTO = 3,
                CANTIDAD_PRODUCTO = 3
            };
            Assert.AreEqual(true, glob.updateProdxOrd(temp));
        }
    }
}
