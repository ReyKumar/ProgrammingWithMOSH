using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            // Impliticit Type Convertion / Automatically Type Convertion 
            int a = 3;
            float b = a;
            Console.WriteLine("{0},{1}",a,b);

            // Explicit type Converstion 
            float c = 3.04f;
            int d = (int)c;
            Console.WriteLine("{0}, {1}",c,d);

            //Convert the Non Compatible Type Conversion 
            string s = "1";
            int i = Convert.ToInt32(s);
            int j = int.Parse(s);
            Console.WriteLine("{0},{1},{2}", s,i,j);

            //2nd Example of Convert the Non Compatible Type Conversion 
            int e = 1000;
            byte f = (byte)e; // This Make Non Compatible Types
            Console.WriteLine("{0},  {1},", e,f);

        }
    }
}
