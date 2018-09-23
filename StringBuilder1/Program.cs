using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilder1
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new StringBuilder("Hello World");
            builder.Append('_', 12);
            builder.AppendLine();
            builder.Append("Header");
            builder.AppendLine();
            builder.Append('_', 12);

            builder.Replace('_','+');
            builder.Remove(0, 10);
            builder.Insert(0, new string('_', 12));
            Console.WriteLine(builder);

            Console.WriteLine("First Character :- {0}", builder[0]);

            // 2nd Method (Easy Way)
            var builder1 = new StringBuilder("Hello World");
            builder1
                .Append('_', 12)
                .AppendLine()
                .Append("Header")
                .AppendLine()
                .Append('_', 12)
                .Replace('_', '+')
                .Remove(0, 10)
                .Insert(0, new string('_', 12));

            Console.WriteLine(builder1);


            Console.ReadKey();
        }
    }
}
