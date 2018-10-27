using System;
using Backend.DAL;
using Backend.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Pruebas
{
    [TestClass]
    public class PruebasMesa
    {
        IMesaDAL mesaDAL;
        MESA mesa;
        [TestMethod]
        public void PruebaAgregar()
        {
            mesaDAL = new MesaDALImpl();
            bool resultado = mesaDAL.addMesa(mesa = new MESA()
            {
                ID_MESA = 2,
                CAPACIDAD = 6,
                ID_ESTADO = 2
            });
            Assert.AreEqual(true, resultado);
        }

        [TestMethod]
        public void pruebaActualizar()
        {
            mesaDAL = new MesaDALImpl();
            bool resultado = mesaDAL.updateMesa(mesa = new MESA()
            {
                ID_MESA = 2,
                CAPACIDAD = 5,
                ID_ESTADO = 1
            });

            Assert.AreEqual(true, resultado);
        }

        [TestMethod]

        public void pruebaEliminar()
        {
            mesaDAL = new MesaDALImpl();
            bool resultado = mesaDAL.deleteMesa(6);
            Assert.AreEqual(true, resultado);
        }

        [TestMethod]

        public void pruebaObtener()
        {
            mesaDAL = new MesaDALImpl();
            int idMesa = mesaDAL.obtenerMesaPorId(2).ID_MESA;

            Assert.AreEqual(2, idMesa);
        }
    }
}
