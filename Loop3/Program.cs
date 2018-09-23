using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop3
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Type Your Name :- ");
                var input = Console.ReadLine();

                // 2nd Example
                if (String.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("@Echo: " + input);
                }
                continue;
            }
        }
    }
}
