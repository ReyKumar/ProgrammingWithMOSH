using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConersionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = "1234";
            int i = Convert.ToInt32(s);
            Console.WriteLine(s);
            Console.WriteLine(i);

            // 2nd Example
            try
            {
                var s2 = "1234";
                byte b = Convert.ToByte(s2);
                Console.WriteLine(s2);
                Console.WriteLine(b);
            }
            catch (Exception)
            {

                Console.WriteLine("String Can't be Convert to Byte");
            }

            // 3rd Example
            try
            {
                var s3 = "true";
                bool b1 = Convert.ToBoolean(s3);

                Console.WriteLine(s3);
                Console.WriteLine(b1);
            }
            catch (Exception)
            {
                Console.WriteLine("There is an Error");
                throw;
            }

        }
    }
}
