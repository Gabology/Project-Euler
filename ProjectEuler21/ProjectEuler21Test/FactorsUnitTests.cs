using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectEuler21;
using System.Linq;

namespace ProjectEuler21Test
{
   [TestClass]
   public class FactorsUnitTests
   {
      [TestMethod]
      public void TestFactorsOfHundred()
      {
         int n = 100;
         int[] expected = new int[] { 2, 4, 5, 10, 20, 25, 50 };

         int[] actual = Program.GetFactors(n);

         CollectionAssert.AreEquivalent(expected, actual);
      }
   }
}
