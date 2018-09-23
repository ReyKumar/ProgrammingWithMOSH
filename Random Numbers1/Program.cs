using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random_Numbers1
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine(random.Next(1, 5));

            //}

            //// 2nd Example
            //Console.WriteLine();

            //Console.WriteLine((char)65);

            //3rd Example Random String
            //Console.WriteLine();
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.Write((char)random.Next(97, 122));
            //}

            Console.WriteLine();
            Console.WriteLine();

            // 4th Example
            const int passwordLength = 10;
            var buffer = new char[passwordLength];
            for (int i = 0; i < passwordLength; i++)
            {
                buffer[i] = (char)('a' + random.Next(0, 26));
                var password = new String(buffer);
                Console.WriteLine(password);
            }


            Console.ReadKey();
        }
    }
}
 