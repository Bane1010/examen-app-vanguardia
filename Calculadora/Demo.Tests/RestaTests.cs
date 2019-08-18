using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculadora.Tests
{
    [TestClass]
    public class RestaTests
    {
        [TestMethod]
        public void Resta_Val()
        {
            const int res1=2; 
            const int res2=3;
            const int esperado= -1;
           
            var actual = Operaciones.Res(res1,res2);
            Assert.AreEqual(esperado, actual);

        }
    }
}
