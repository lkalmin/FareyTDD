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
      public void TestLength0()
      {
         var fs = new FareyTDD.FareySequence();
         string result = fs.Run(0);
         Assert.AreEqual("F0 = { 0/1 }", result);
      }

      [TestMethod]
      public void TestLength1()
      {
         var fs = new FareyTDD.FareySequence();
         string result = fs.Run(1);
         Assert.AreEqual("F1 = { 0/1 1/1 }", result);
      }

      [TestMethod]
      public void TestLengthNBeginning()
      {
         int n = 4;
         
         var fs = new FareyTDD.FareySequence();

         // Compose start of result string
         string seqStart = string.Format("F{0}", n);
         seqStart += "   = { 0/1";
         for (int i = n; i > 1; i--)
         {
            seqStart += string.Format(" 1/{0}", i);
         }
         var strLen = seqStart.Length;
         
         string result = fs.Run(n);

         Assert.AreEqual(seqStart, result.Substring(0, strLen));
      }
   }
}
