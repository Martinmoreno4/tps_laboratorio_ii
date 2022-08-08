using Biblioteca;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestUnitario
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ProbarValidacionesImplementos_CuandoSePonenDatosCorrectos_DevuelveTrue()
        {
            //Arrange
            AccesoSql sql = new AccesoSql();
            Implementos implemento = new Implementos("lapices",50);
            int isTrue = 0;

            //Act
             isTrue = sql.Insertar(implemento);

            //Assert
            Assert.IsTrue(isTrue == 1);
        }

        [ExpectedException(typeof(DatosInvalidosException))]
        [TestMethod]
        public void Test_DatosNoValidosException()
        {
            //Arrange
            AccesoSql sql = new AccesoSql();
            Implementos implemento = new Implementos();

            //Act
            implemento.Nombre = null;
            implemento.Cantidad = -1;

            //Assert
            sql.Insertar(implemento);
        }
    }
}
