using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatements1
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = 10;

            if (hour > 0 && hour < 12)  
            {
                Console.WriteLine("Good Morning");
            }

            else if (hour > 12 && hour < 18)
            {
                Console.WriteLine("Good Afternoon");
            }

            else
            {
                Console.WriteLine("Good Evening");
            }


            bool isGoldCustomer = true;

            float price;
            if (isGoldCustomer)
            {
                price = 19.95f;
            }
            else
            {
                price = 29.95f;
            }
            Console.WriteLine(price+"$");
            

            Console.ReadLine();
        }
    }
}
