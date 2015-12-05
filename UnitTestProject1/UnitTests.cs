using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FareyTDD;

namespace UnitTests
{
   [TestClass]
   public class UnitTests
   {
      [TestMethod]
      public void TestMethod1()
      {
         var fs = new FareyTDD.FareySequence();

         bool result = fs.Run();
         Assert.IsTrue(result);
      }
   }
}
