using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists1
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int> { 2, 3, 4, 5, 7 };

            // Simple List
            Console.WriteLine("Simple List");
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            // Add() Method
            numbers.Add(4);
            Console.WriteLine("After using Add() Method ");
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            // AddRange() Method
            numbers.AddRange(new int[3] { 3, 5, 2 });
            Console.WriteLine("After using AddRange() Method");
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine();
            // IndexOf() Method 
            Console.WriteLine("IndexOf 3:- "+ numbers.IndexOf(3));
            
            // LastIndexOf() Method
            Console.WriteLine("LastIndexOf 4:- " + numbers.LastIndexOf(4));

            // Count
            Console.WriteLine("Count method :- "+ numbers.Count);

            // Remove() Method
            Console.WriteLine("After Using Remove Method With Condition");


            for (var i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == 2 )
                {
                    numbers.Remove(numbers[i]);
                }
            }

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            // Clear() Method
            numbers.Clear();

            Console.WriteLine("Count After Clear:- "+ numbers.Count);

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }


            Console.ReadKey();
        }
    }
}
