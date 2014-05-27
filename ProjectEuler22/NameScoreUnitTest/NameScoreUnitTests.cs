using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectEuler22;

namespace NameScoreUnitTest
{
   [TestClass]
   public class NameScoreUnitTests
   {
      [TestMethod]
      public void TestNameBilly()
      {
         string name = "BILLY";
         int expected = 60;

         int actual = Program.GetNameScore(name);

         Assert.AreEqual(expected, actual);
      }
   }
}
