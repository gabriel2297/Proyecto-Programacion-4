using System;
using Backend.DAL;
using Backend.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Pruebas
{
    [TestClass]
    public class PruebasFactura
    {
        IFacturaDAL facturaDal = new FacturaDALImpl();
        [TestMethod]
        public void pruebaAgregar()
        {
           
            // crear una nueva factura e insertarle todos los datos(no se necesita ID, SQL se encarga)


            FACTURA factura = new FACTURA
            {
                PRECIO_UNIDAD = 30000,
                PRECIO_TOTAL = 30000,
                METODO_PAGO = "Efectivo",
                MENSAJE = "Gracias por su visita",
                NOMBRE_CAJERO = "Alexandra Martinez Garbanzo",
                TOTAL_CANCELADO = 31000,
                FECHA = System.DateTime.Now,
                ID_ORDEN = 6

            };
            // verificar la insercion
            Assert.AreEqual(true, facturaDal.addFactura(factura));

        }


        [TestMethod]
        public void pruebaEliminar()
        {
            // si metodo retorna true, se elimino
            Assert.AreEqual(true, facturaDal.deleteFactura(2));

        }

        [TestMethod]
        public void pruebaModificar()
        {
            // crear una nueva factura, asignarle todossus campos (por id porque lo vamos a necesitar para encontrarlo)
            FACTURA factura = new FACTURA {
                ID_FACTURA = 3,
                PRECIO_UNIDAD = 20000,
                PRECIO_TOTAL = 20000,
                METODO_PAGO = "Tarjeta de Credito",
                MENSAJE = "Gracias por su compra",
                NOMBRE_CAJERO = "Randall Herrera Gamez",
                TOTAL_CANCELADO = 20000,
                FECHA = System.DateTime.Now,
                ID_ORDEN = 2
                 };
            // si metodo retorna true, se modifico
            Assert.AreEqual(true, facturaDal.updateFactura(factura));
        }

        [TestMethod]
        public void pruebaObtener()
        {
            
            // si metodo retorna una factura con la factura que queremos, se obtuvo
            Assert.AreEqual(2, facturaDal.obtenerFacturaPorID(2).ID_FACTURA);
        }

    }
}
