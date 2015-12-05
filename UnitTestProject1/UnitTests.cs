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

      /// <summary>
      /// Test beginning of sequence for numbers 4 and under (still added in sequence)
      /// </summary>
      [TestMethod]
      public void TestLength4Beginning()
      {
         int n = 4;
         
         var fs = new FareyTDD.FareySequence();

         // Compose start of result string
         string seqStart = string.Format("F{0}", n);
         seqStart += " = { 0/1";
         for (int i = n; i > 1; i--)
         {
            seqStart += string.Format(" 1/{0}", i);
         }
         var strLen = seqStart.Length;
         
         string result = fs.Run(n);

         Assert.AreEqual(seqStart, result.Substring(0, strLen));
      }

      /// <summary>
      /// Test sequence of length 9
      /// </summary>
      [TestMethod]
      public void TestLength9()
      {
         var fs = new FareyTDD.FareySequence();

         string result = fs.Run(9);
         string expected =
            "F9 = { 0/1 1/9 1/8 1/7 1/6 1/5 2/9 1/4 2/7 1/3 3/8 2/5 3/7 4/9 1/2 5/9 4/7 3/5 5/8 2/3 5/7 3/4 7/9 4/5 5/6 6/7 7/8 8/9 1/1 }";
         Assert.AreEqual(expected, result);
      }
   }
}
