using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Procedurals_Programming1
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("What is Your Name :- ");
            var name = Console.ReadLine();

            var reversed = ReverseName(name);
            Console.WriteLine("Reversed Name :- " + reversed);
            
            Console.ReadKey();
        }

        public static string ReverseName(string name)
        {
            var array = new char[name.Length];

            for (var i = name.Length; i > 0; i--)
            {
                array[name.Length - i] = name[i - 1];
            }
            /*1st Way*/ 
            
            //var reversed = new string(array);
            //return reversed;

            /*2nd Way*/
          
            return new string(array);
        }
    }
}
