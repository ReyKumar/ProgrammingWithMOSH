using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Console = System.Console;

namespace Procedural_Programming_02
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>();
            Console.Write("Enter a Number (or 'QUIT' to 'Exit')");

            while (true)
            {
                var input = Console.ReadLine();

                if (input.ToLower() == "quit")
                {
                    break;
                }
                numbers.Add(Convert.ToInt32(input));
            }

            var uniques = new List<int>();
            foreach (var number in numbers)
            {
                if (!uniques.Contains(number))
                {
                    uniques.Add(number);
                }
            }

            Console.WriteLine("Unique Numbers");
            foreach (var number in uniques)
            {
                Console.WriteLine(number);
            }

            Console.ReadKey();
        }
    }
}
