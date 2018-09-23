using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Files1
{
    class Program
    {
        static void Main(string[] args)
        {
            //File.Create(@"H:\R.txt");
            var path = @"H:\R.txt";

            //Copy
            if (File.Exists(@"H:\Rough3.txt"))
            {
                //
            }
            else
            {
                File.Copy(@"E:\Rough2.txt", @"H:\Rough3.txt");
            }
            
            Console.WriteLine("File Copied");

            //Delete
            File.Delete(path);

            Console.WriteLine("File deleted");
            
            if (File.Exists(path))
            {
                // File.ReadAllText(@"H:\R.txt");
            }

            File.ReadAllText(path);

            Console.ReadLine();

        }
    }
}
