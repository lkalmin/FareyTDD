using System;
using System.Globalization;


namespace FareyTDD
{
   /// <summary>
   /// The farey sequence.
   /// </summary>
   public class FareySequence
   {
      public string Run(int n)
      {
         string result = "F" + n.ToString(CultureInfo.InvariantCulture) + " = { ";
         return result;
      }

      public int AcceptInput(string[] input)
      {
         if (input.Length == 0) return -1;
         var n = Convert.ToInt32(input[0]);
         return n;
      }
   }
}
