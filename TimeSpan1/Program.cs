using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeSpan1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating
            var timeSpan = new TimeSpan(1, 4, 3);

            var timeSpan1 = new TimeSpan(1, 0, 0);
            var timeSpan2 = TimeSpan.FromHours(1);

            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);
            var duration = end - start;

            Console.WriteLine("Duration :- "+duration);
            Console.WriteLine();

            // Properties
            Console.WriteLine("Minutes :- "+ timeSpan.Minutes);
            Console.WriteLine("Total Minutes :- " + timeSpan.TotalMinutes);
            Console.WriteLine();

            // Add
            Console.WriteLine("Add Example :- "+ timeSpan.Add(TimeSpan.FromMinutes(8)));
            // Subsract
            Console.WriteLine("Add Example :- "+ timeSpan.Add(TimeSpan.FromMinutes(8)));

            // ToString
            Console.WriteLine("ToString :- "+ timeSpan.ToString());

            // Parse
            Console.WriteLine("Parse :- "+ TimeSpan.Parse("01:02:03"));
            Console.ReadKey();

        }
    }
}
