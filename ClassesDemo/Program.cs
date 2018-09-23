using ClassesDemo.MATH;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesDemo
{
    class Program : Person
    {
        static void Main(string[] args)
        {
            Person person = new Person();

            person.firstName = "Ronak";

            person.lastName = "Sankhala";

            person.Introduce();

            Calculator calculator = new Calculator();

            calculator.Add(1,5); // Passing Parameter
            var result = calculator.Add(6,3);
            System.Console.WriteLine(result);
        }

    }
}
