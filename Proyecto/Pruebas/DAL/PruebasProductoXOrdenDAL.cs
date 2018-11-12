using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Backend.Model;
using Backend.DAL;
namespace Pruebas.DAL
{
    [TestClass]
    public class PruebasProductoXOrdenDAL
    {
        IProductoXOrdenDAL glob = new ProductoXOrdenDALImpl();

        [TestMethod]
        public void add()
        {
            PRODUCTO_X_ORDEN temp = new PRODUCTO_X_ORDEN
            {
                ID_ORDEN = 4,
                ID_PRODUCTO = 4,
                CANTIDAD_PRODUCTO = 4
            };
            Assert.AreEqual(1, glob.addProdxOrd(temp));
        }

        [TestMethod]
        public void search()
        {
            PRODUCTO_X_ORDEN temp = glob.getProdxOrd(1,2);
            Assert.AreEqual(2, temp.CANTIDAD_PRODUCTO);
        }

        [TestMethod]
        public void delete()
        {
            PRODUCTO_X_ORDEN temp = new PRODUCTO_X_ORDEN
            {
                ID_ORDEN = 5,
                ID_PRODUCTO = 4,
                CANTIDAD_PRODUCTO = 3
            };
            glob.addProdxOrd(temp);
            Assert.AreEqual(1, glob.deleteProdxOrd(temp.ID_PRODUCTO, temp.ID_ORDEN));
        }
        [TestMethod]
        public void update()
        {
            PRODUCTO_X_ORDEN temp = new PRODUCTO_X_ORDEN
            {
                ID_PRODUCTO = 1,
                ID_ORDEN = 2,
                CANTIDAD_PRODUCTO = 4
            };
            Assert.AreEqual(1, glob.updateProdxOrd(temp));
        }
    }
}
