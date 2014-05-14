using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problem16;

namespace Problem16Test
{
   [TestClass]
   public class Problem16Test
   {
      [TestMethod]
      public void TestPowerDigitSumExample()
      {
         //Arrange
         int number = 2;
         int power = 15;
         double expected = 26.0;
         //Act
         double actual = Program.GetPowerDigitSum(number, power);
         //Assert
         Assert.AreEqual(expected, actual);
      }

      [TestMethod]
      public void TestPowerDigitSumProblem()
      {
         //Arrange
         int number = 2;
         int power = 1000;
         double expected = 1366;
         //Act
         double actual = Program.GetPowerDigitSum(number, power);
         //Assert
         Assert.AreEqual(expected, actual);
      }
   }
}
