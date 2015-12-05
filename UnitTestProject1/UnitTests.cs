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
      }

      [TestMethod]
      public void TestAcceptInput()
      {
         var fs = new FareyTDD.FareySequence();
         string[] input = { "6" };
         int n = fs.AcceptInput(input);
         Assert.IsTrue(n > 0);
      }

      [TestMethod]
      public void TestLenght0()
      {
         var fs = new FareyTDD.FareySequence();
         string result = fs.Run(0);
         Assert.AreSame("", "F0 = { 0/0 }");

      }
   }
}
