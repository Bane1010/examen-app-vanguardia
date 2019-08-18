using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculadora.Tests
{
    [TestClass]
    public class MultiTest
    {
        [TestMethod]
        public void Multi_Val()
        {
            const int res1 = 2;
            const int res2 = 3;
            const int esperado = 6;

            var actual = Operaciones.Mul(res1, res2);
            Assert.AreEqual(esperado, actual);
        }
    }
}
