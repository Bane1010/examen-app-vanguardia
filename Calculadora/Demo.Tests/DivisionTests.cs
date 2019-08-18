using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculadora.Tests
{
    [TestClass]
   public  class DivisionTests
    {
    [TestMethod]

    public void Division_Valida()
        {
            const int div1 = 4;
            const int div2 = 2;
            const int esperado = 2;
            var actual = Operaciones.Division(div1,div2);
            Assert.AreEqual(actual, esperado);
        }
    }
}

