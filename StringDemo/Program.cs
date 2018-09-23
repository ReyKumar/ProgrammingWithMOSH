using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace StringDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // string name = firstName + " " + lastName;
            var firstName = "Ronak";
            var lastName = "Sankhala";
            var name = string.Format("{0} {1}",firstName, lastName);
            Console.WriteLine(name);

            Console.WriteLine();
            Console.WriteLine("2nd Example");
            Console.WriteLine();
            // 2nd Example

            Int32 i = 2;
            int j = 2;
            Console.WriteLine("same data type of \n i = {0} \n j = {1} ", i,j);

            Console.WriteLine();
            Console.WriteLine("3rd Example");
            Console.WriteLine();
            // 3rd Example

            var names = new string[3] {"Ronak", "Kishan", "Bhaislana" };
            var formattedNames = string.Join(",", names);

            Console.WriteLine("Simple Names = ",names);
            Console.WriteLine(formattedNames);

            Console.WriteLine();
            Console.WriteLine("4th Example");
            Console.WriteLine();
            // 4th Example

            var text = "Hi Ronak \nLook into the following paths \nc:\\folder1\\folder2 \nc:\\folder3\\folder4";
            Console.WriteLine(text);

            Console.WriteLine();
            Console.WriteLine("5th Example");
            Console.WriteLine();
            // 5th Example

            var text1 = @"Hi Ronak 
                        Look into the following paths 
                        c:\folder1\folder2
                        c:\folder3\folder4";
            Console.WriteLine(text);

            Console.ReadLine();

        }
    }
}
