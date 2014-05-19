using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectEuler18;

namespace ProjectEuler18Tests
{
   [TestClass]
   public class UnitTest1
   {
      [TestMethod]
      public void ProblemExampleTest()
      {
         //A
         int expected = 23;
         var pyramid = new NumberTriangle();
         pyramid.AddRow(3);
         pyramid.AddRow(7, 4);
         pyramid.AddRow(2, 4, 6);
         pyramid.AddRow(8, 5, 9, 3);
         //A
         int actual = pyramid.GetMaximumPathSum();
         //A
         Assert.AreEqual(expected, actual);
      }
   }
}
