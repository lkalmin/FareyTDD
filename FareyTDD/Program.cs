using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
         fs.Run();
      }
   }
}
