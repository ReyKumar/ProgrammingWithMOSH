using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTime1
{
    class Program
    {
        static void Main(string[] args)
        {
            var dateTime = new DateTime(2018, 6, 11);
            var now = DateTime.Now;
            var today = DateTime.Today;


            Console.WriteLine("Time :- " + now);
            Console.WriteLine("Date :- " + today);

            Console.WriteLine("Hour :- " + now.Hour);
            Console.WriteLine("Minute :- "+ now.Minute);


            //Tommorow
            Console.WriteLine("Tommorow :- "+now.AddDays(1));

            // YesterDay
            Console.WriteLine("Yesterday :- "+now.AddDays(-1));

            Console.WriteLine("AddYear :-" + now.AddYears(2));

            Console.WriteLine("ToLongDateString  =" + DateTime.Now.ToLongDateString());
            Console.WriteLine("ToShortDateString =" + DateTime.Now.ToShortDateString());
            Console.WriteLine("ToLongTimeString =" + DateTime.Now.ToLongTimeString());
            Console.WriteLine("ToShortTimeString =" + DateTime.Now.ToShortTimeString());
            Console.WriteLine( "ToString :- " +now.ToString("U"));

            var toDay = DateTime.Now.Day;
            Console.WriteLine("Today :- "+toDay);

            var dayOfWeek = DateTime.Now.DayOfWeek;
            Console.WriteLine("Day of Week :- "+ dayOfWeek);

            var date1 = DateTime.Now.Ticks;
            Console.WriteLine("DateTime Ticks :- "+date1);

            


            Console.ReadKey();
        }
    }
}
