
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rough
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             byte number = 255;
            number = number + 1; // 0 // OverFlowing
             */

            /*
              checked
             {
                 byte number = 255;
                 number = number + 1;
             }
             */

            Console.WriteLine(3.63f+6.54f);

            DateTime dateTime = new DateTime(2008, 5, 1, 8, 30, 52);
            Console.WriteLine(dateTime);

            for (int a=0;a < 100000 ;a++)
            {
                Console.WriteLine("Mahima I Love You \n");
            }

            Console.ReadKey();
        }
    }
}
    