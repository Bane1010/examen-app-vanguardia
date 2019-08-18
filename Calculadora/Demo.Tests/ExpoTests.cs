using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculadora.Tests
{
    [TestClass]
   public class ExpoTests
    {
        [TestMethod]

    public void Expo_Valor()
        {
            const int expo1 = 2;
            const int expo2 = 2;
            const int esperado = 4;

            var actual = Operaciones.Expo(expo1,expo2);
            Assert.AreEqual(esperado, actual);
        }



    }
}
