using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InlineArrays
{
   [System.Runtime.CompilerServices.InlineArray(10)]
   public struct MyInlineBuffer
   {
      private int _whatever;
   }
}
