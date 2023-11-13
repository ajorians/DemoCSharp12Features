using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Interceptors
{
   public static class Interception
   {
      [InterceptsLocation( "C:\\Users\\A.J. Orians\\source\\repos\\CSharp12\\Interceptors\\Program.cs", line: 5, character: 9)]
      public static void InterceptMethod1(
         this Example example )
      {
         Console.WriteLine( "Hello from Interceptor :)" );
      }

      [InterceptsLocation( "C:\\Users\\A.J. Orians\\source\\repos\\CSharp12\\Interceptors\\Program.cs", line: 7, character: 9 )]
      public static void InterceptMethod1(
         this Example example, string name )
      {
         Console.WriteLine( $"Hello from Interceptor, {name} :)" );
      }
   }
}
