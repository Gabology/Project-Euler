using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectEuler17;

namespace Problem17Tests
{
   [TestClass]
   public class NumberReaderTests
   {
      [TestMethod]
      public void CheckHundredNumber()
      {
         // Arrange
         string expected = "two hundred and three";
         int number = 203;
         // Act
         string actual = NumberReader.GetNumberToString(number);
         // Assert
         Assert.AreEqual(expected, actual);
      }

      [TestMethod]
      public void CheckMixedHundredNumber()
      {
         // Arrange
         string expected = "four hundred and ten";
         int number = 410;
         // Act
         string actual = NumberReader.GetNumberToString(number);
         // Assert
         Assert.AreEqual(expected, actual);
      }

      [TestMethod]
      public void CheckTensNumber()
      {
         // Arrange
         string expected = "fifty-four";
         int number = 54;
         // Act
         string actual = NumberReader.GetNumberToString(number);
         // Assert
         Assert.AreEqual(expected, actual);
      }

      [TestMethod]
      public void CheckOnesNumber()
      {
         // Arrange
         string expected = "twelve";
         int number = 12;
         // Act
         string actual = NumberReader.GetNumberToString(number);
         // Assert
         Assert.AreEqual(expected, actual);
      }
   }
}
