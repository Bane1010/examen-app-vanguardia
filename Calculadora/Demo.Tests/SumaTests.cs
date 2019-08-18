using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculadora.Tests
{
    [TestClass]
   public class SumaTests
    {
        [TestMethod]

    public void Suma_ValoresValidos()
        {
            const int Sumado1 = 3;
            const int Sumado2 = 5;
            const int esperado = 8;

            var actual = Operaciones.Suma(Sumado1, Sumado2);
            Assert.AreEqual(esperado, actual);
        }



    }
}
