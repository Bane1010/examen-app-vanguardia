using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculadora.Tests
{
    [TestClass]
   public class RaizTests
    {
        [TestMethod]

    public void Raiz_Valor()
        {
            const int raiz1 = 9;
            const int raiz2 = 9;
            const int esperado = 3;

            var actual = Operaciones.Raiz(raiz1, raiz2);
            Assert.AreEqual(esperado, actual);
        }



    }
}
