using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatements2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isGoldCustomer = true;
            float price = (isGoldCustomer) ? 19.95f : 29.95f;

            Console.WriteLine(price + "$");
            Console.ReadLine();
        }
    }
}
