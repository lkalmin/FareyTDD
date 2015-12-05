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

         int a = 0;
         int b = 1;
         int c = 1;
         int d = n;
         result += string.Format("{0}/{1} ", a, b);

         // Compute successive terms
         while (c <= n)
         {
            var k = (int)((n + b) / d);
            int aa = a;
            int bb = b;

            a = c;
            b = d;
            c = (k * c) - aa;
            d = (k * d) - bb;
            result += string.Format("{0}/{1} ", a, b);
         }

         result += "}";
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
