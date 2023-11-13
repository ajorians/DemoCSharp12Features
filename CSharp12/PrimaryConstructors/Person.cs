using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimaryConstructors
{
   public class Person( string _name, int _age )
   {
      public void Test()
      {
         Console.WriteLine( $"{_name} is {_age} years old" );
      }
   }

   //record Person( string Name, int Age );
}
