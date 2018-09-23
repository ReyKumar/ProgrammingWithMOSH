using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (var i = 1; i <= 10; i++)
            {
                if (i%2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine();
            Console.WriteLine("2nd Example");

            // 2nd Example
            for (var i = 10; i > 1; i--)
            {
                if (i%2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine();
            Console.WriteLine("3rd Example");

            // 3rd Example 
            var name = "Rey Kumar";
            for (var i = 0; i < name.Length; i++)
            {
                Console.WriteLine(name[i]);
            }

            Console.WriteLine();
            Console.WriteLine("4th Example");

            // 4th Example (ForEach)
            foreach (var character in name)
            {
                Console.WriteLine(character);
            }

            Console.WriteLine();
            Console.WriteLine("5th Example");

            // 5th Example (While)
            var j = 0;
            while (j<=10)
            {
                if (j%2 == 0)
                {
                    Console.WriteLine(j);
                    
                }
                j++;

            }

            Console.Read();
        }
    }
}
