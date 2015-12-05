using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FareyTDD
{
   /// <summary>
   /// The farey sequence.
   /// </summary>
   public class FareySequence
   {
      public string Run(int n)
      {
         return "";
      }

      public int AcceptInput(string[] input)
      {
         if (input.Length == 0) return -1;
         var n = Convert.ToInt32(input[0]);
         return n;
      }
   }
}
