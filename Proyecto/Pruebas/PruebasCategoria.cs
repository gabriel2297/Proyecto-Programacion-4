using System;
using System.Collections.Generic;
using System.Linq;
using Backend.DAL;
using Backend.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Pruebas
{
    [TestClass]
    public class PruebasCategoria
    {
        ICategoriaDAL categoriaDAL;
        CATEGORIA categoria;
        [TestMethod]
        public void PruebaAgregar()
        {
            categoriaDAL = new CategoriaDALImpl();
            bool resultado = categoriaDAL.addCategoria(categoria = new CATEGORIA()
            {
                ID_CATEGORIA = 2,
                NOMBRE_CATEGORIA = "REFRESCOS",
                DESCRIPCION = "NATURALES"
            });
            Assert.AreEqual(true, resultado);
        }

        [TestMethod]
        public void pruebaActualizar()
        {
            categoriaDAL = new CategoriaDALImpl();
            bool resultado = categoriaDAL.updateCategoria(categoria = new CATEGORIA()
            {
                ID_CATEGORIA = 2,
                NOMBRE_CATEGORIA = "REFRESCOS",
                DESCRIPCION = "GASEOSOS"
            });

            Assert.AreEqual(true, resultado);
        }

        [TestMethod]

        public void pruebaEliminar()
        {
            categoriaDAL = new CategoriaDALImpl();
            bool resultado = categoriaDAL.deleteCategoria(3);
            Assert.AreEqual(true, resultado);
        }

        [TestMethod]

        public void pruebaObtener()
        {
            categoriaDAL = new CategoriaDALImpl();
            int idCategoria = categoriaDAL.obtenerCategoriaPorID(3).ID_CATEGORIA;

            Assert.AreEqual(3, idCategoria);
        }
    }
}
