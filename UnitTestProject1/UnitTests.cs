using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FareyTDD;

namespace UnitTests
{
   [TestClass]
   public class UnitTests
   {
      [TestMethod]
      public void TestClassCreation()
      {
         var fs = new FareyTDD.FareySequence();

         bool result = fs.Run();
         Assert.IsTrue(result);
      }

      [TestMethod]
      public void TestAcceptInput()
      {
         var fs = new FareyTDD.FareySequence();
         int n = fs.AcceptInput("6");
         Assert.IsTrue(n > 0);
      }

   }
}
