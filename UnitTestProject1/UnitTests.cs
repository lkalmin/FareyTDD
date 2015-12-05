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
         string[] input = { "6" };
         int n = fs.AcceptInput(input);
         Assert.IsTrue(n > 0);
      }

   }
}
