using System;
using System.Collections.Generic;
using System.Linq;
using Backend.DAL;
using Backend.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Pruebas
{
    [TestClass]
    public class PruebasMesero
    {
        [TestMethod]
        public void pruebaAgregar()
        {
            // instanciar un objeto de la interfaz de meseros
            IMeseroDAL meseroDAL = new MeseroDALImpl();
            // crear un nuevo mesero y asignarle nombre (no se necesita ID, SQL se encarga)
            MESERO mesero = new MESERO { NOMBRE_MESERO = "Ernesto estrada" };
            // verificar la insercion
            Assert.AreEqual(true, meseroDAL.addMesero(mesero));
        }

        [TestMethod]
        public void pruebaEliminar()
        {
            // instanciar un objeto de la interfaz de meseros
            IMeseroDAL meseroDAL = new MeseroDALImpl();
            // si metodo retorna true, se elimino
            Assert.AreEqual(true, meseroDAL.deleteMesero(6));
        }

        [TestMethod]
        public void pruebaModificar()
        {
            // instanciar un objeto de la interfaz de meseros
            IMeseroDAL meseroDAL = new MeseroDALImpl();
            // crear un nuevo mesero, asignarle nombre y ID (id porque lo vamos a necesitar para encontrarlo)
            MESERO mesero = new MESERO { ID_MESERO = 7, NOMBRE_MESERO = "HERNAN CHAVES" };
            // si metodo retorna true, se modifico
            Assert.AreEqual(true, meseroDAL.updateMesero(mesero));
        }

        [TestMethod]
        public void pruebaObtener()
        {
            // instanciar un objeto de la interfaz de meseros
            IMeseroDAL meseroDAL = new MeseroDALImpl();
            // si metodo retorna un mesero con el nombre que queremos, se obtuvo
            Assert.AreEqual("HERNAN CHAVES", meseroDAL.obtenerMeseroPorID(7).NOMBRE_MESERO);
        }

        [TestMethod]
        public void pruebaObtenerLista()
        {
            // instanciar un objeto de la interfaz de meseros
            IMeseroDAL meseroDAL = new MeseroDALImpl();
            // si metodo retorna un mesero con el nombre que queremos, se obtuvo
            Assert.AreEqual(14, meseroDAL.obtenerMeseros().Count);
        }


    }
}
