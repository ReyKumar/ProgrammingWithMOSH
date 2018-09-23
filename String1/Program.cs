using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String1
{
    class Program
    {
        static void Main(string[] args)
        {
            //var myName = "Ronak Sankhala ";
            //var yourName = " Kishan Sankhala";
            var fullName = "Ronak Sankhala ";


            Console.WriteLine(fullName);
            Console.WriteLine("Trim:- {0} ",fullName.Trim());
            Console.Write("ToUpper:- {0} ",fullName.Trim().ToUpper());

            Console.WriteLine();

            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0, index);
            var lastName = fullName.Substring(index + 1);

            Console.WriteLine("First Name :- {0}", firstName);
            Console.WriteLine("Last Name :- {0}", lastName);
            
            var names = fullName.Split(' ');
            Console.WriteLine("First Name :- {0}", names);
            Console.WriteLine("Last Name :- {1}", names);

            Console.WriteLine(fullName.Replace("Ronak", "Rey") );
            Console.WriteLine(fullName.Replace('o', 'O'));

            // fullName.Replace(' ', ' ');


            // Method 1
            if (String.IsNullOrEmpty(null))
            {
                Console.WriteLine("Invalid");
            }

            // Method 2
            if (String.IsNullOrEmpty(""))
            {
                Console.WriteLine("Invalid");
            }
            Console.WriteLine("Method 3");
            // Method 3
            if (String.IsNullOrEmpty(" "))
            {
                Console.WriteLine("Invalid"); // Why This Not Print
            }
            
            //Method 4
            if (String.IsNullOrWhiteSpace(" "))
            {
                Console.WriteLine("Invalid");
            }
            Console.WriteLine();
            // Method 1
            var str = "25" ;
            var age = Convert.ToByte(str);
            Console.WriteLine(age);
            
            float price = 3.86f;
            Console.WriteLine(price.ToString("C"));

            Console.WriteLine(price.ToString("C0"));

            Console.ReadKey();

        }

    }
}
