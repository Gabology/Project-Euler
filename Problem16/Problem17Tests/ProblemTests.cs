using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Problem17Tests
{
   [TestClass]
   public class ProblemTests
   {
      [TestMethod]
      public void ProblemExampleTest()
      {
         // Arrange
         int expected = 19;
         
         // Act
         int actual = (int)ProjectEuler17.Program.GetNumberLetterCounts(5);

         //Assert
         Assert.AreEqual(expected, actual);
      }
   }
}
