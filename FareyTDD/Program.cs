using System;
using System.Globalization;

namespace FareyTDD
{
   /// <summary>
   /// Farey Sequence create with TDD
   /// </summary>
   class Program
   {
      /// <summary>
      /// Farey Sequence Main
      /// </summary>
      /// <param name="args"></param>
      static void Main(string[] args)
      {
         FareySequence fs = new FareySequence();
         int n = fs.AcceptInput(args);
         if (n < 0)
         {
            Console.WriteLine("Input n value for Farey Sequence");
            return;
         }
         var output = fs.Run(n);
         Console.WriteLine("Farey Sequence of order " + n.ToString(CultureInfo.InvariantCulture));
         Console.WriteLine();
         Console.WriteLine(output);
      }
   }
}
