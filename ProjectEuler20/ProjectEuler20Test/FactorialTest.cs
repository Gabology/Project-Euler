using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectEuler20;
using System.Numerics;

namespace ProjectEuler20Test
{
   [TestClass]
   public class FactorialTest
   {
      [TestMethod]
      public void TestFactorial10()
      {
         // Arrange
         int n = 10;
         int expected = 3628800;
         // Act
         BigInteger actual = ProjectEuler20.Program.GetFactorial(n);
         // Assert
         Assert.AreEqual(expected, actual);
      }
   }
}
