using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayDemo
{
    class Program
    {
        static void Main(string[] args)
        {
           int[] numbersInts = new int[]{4,6,3,6,7,3,2};

           Console.WriteLine(numbersInts[0]);
           Console.WriteLine(numbersInts[1]);
           Console.WriteLine(numbersInts[2]);
           Console.WriteLine(numbersInts[3]);
           Console.WriteLine(numbersInts[4]);

            Console.WriteLine();
           Console.WriteLine("2nd Example");
            Console.WriteLine();
           // 2nd Example
           var numbers = new int[5];
           numbers[0] = 32;
            

           Console.WriteLine(numbers[0]);
           Console.WriteLine(numbers[1]);
           Console.WriteLine(numbers[2]);

            Console.WriteLine();
            Console.WriteLine("3rd Example");
            Console.WriteLine();
            // 3rd Example

            var bools = new bool[3];
            bools[0] = true;

            Console.WriteLine(bools[0]);
            Console.WriteLine(bools[1]);
            Console.WriteLine(bools[2]);

            Console.WriteLine();
            Console.WriteLine("4th Example");
            Console.WriteLine();
            // 4th Example

            var names = new string[] {"Ram", "Ramesh", "Suresh" };
            Console.WriteLine(names[0]);
            Console.WriteLine(names[1]);
            Console.WriteLine(names[2]);
            Console.WriteLine();
            Console.WriteLine(String.Concat(names[0]+ " " + names[1]));
            Console.WriteLine(String.Compare(names[0],names[1]));


            Console.ReadKey();
        }
    }
}
