using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array1
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new[] { 1, 2, 3, 4, 5, 7, 9 };

            // Length
            Console.WriteLine("Length of Array :- " + numbers.Length);


            // IndexOf
            var index = Array.IndexOf(numbers, 7);

            Console.WriteLine("Index of 7 :- " + index);

            // Clear
            Array.Clear(numbers, 2, 4);
            Console.WriteLine("Effect of Clear()");
            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }


            //copy
            int[] another = new int[3];
            Array.Copy(numbers, another, 3);
            Console.WriteLine("Effect of Copy");
            foreach (var item in another)
            {
                Console.WriteLine(item);
            }


            //sort
            Array.Sort(numbers);
            Console.WriteLine("Effect of Sort");
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }


            // Reverse
            Array.Reverse(numbers);

            Console.WriteLine("Effect of Reverse");
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
            

            Console.ReadKey();
        }
    }
}
