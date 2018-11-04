using System;
using Backend.BLL;
using Backend.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Pruebas.BLL
{
    [TestClass]
    public class PruebasFacturaBLL
    {
        IFacturaBLL facturaBLL = new FacturaBLLImpl();
        [TestMethod]
        public void pruebaAgregar()
        {

            // crear una nueva factura e insertarle todos los datos(no se necesita ID, SQL se encarga)


            FACTURA factura = new FACTURA
            {
                PRECIO_UNIDAD = 4500,
                PRECIO_TOTAL = 4500,
                METODO_PAGO = "Efectivo",
                MENSAJE = "Gracias por su visita",
                NOMBRE_CAJERO = "Wendy Martinez Garbanzo",
                TOTAL_CANCELADO = 5000,
                FECHA = System.DateTime.Now,
                ID_ORDEN = 2

            };
            // verificar la insercion
            Assert.AreEqual(true, facturaBLL.addFactura(factura));

        }


        [TestMethod]
        public void pruebaEliminar()
        {
            // si metodo retorna true, se elimino
            Assert.AreEqual(true, facturaBLL.deleteFactura(4));

        }

        [TestMethod]
        public void pruebaModificar()
        {
            // crear una nueva factura, asignarle todossus campos (por id porque lo vamos a necesitar para encontrarlo)
            FACTURA factura = new FACTURA
            {
                ID_FACTURA = 3,
                PRECIO_UNIDAD = 20000,
                PRECIO_TOTAL = 20000,
                METODO_PAGO = "Tarjeta de Credito",
                MENSAJE = "Gracias por su compra",
                NOMBRE_CAJERO = "Pedro Herrera Galeano",
                TOTAL_CANCELADO = 20000,
                FECHA = System.DateTime.Now,
                ID_ORDEN = 2
            };
            // si metodo retorna true, se modifico
            Assert.AreEqual(true, facturaBLL.updateFactura(factura));
        }

   /*     [TestMethod]
        public void pruebaObtener()
        {
            Assert.AreEqual(2,facturaBLL.obtenerFacturaPorID(2).ID_FACTURA);
        }*/
    }
}
