using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    class Program
    {

        public enum ShippingMethod
        {
            RegularAirMail = 1,
            RegisteredAirMail = 2,
            Express = 3
        }

        static void Main(string[] args)
        {
            var method = ShippingMethod.Express;
            Console.WriteLine((int)method);

            var methodID = 3;
            Console.WriteLine((ShippingMethod)methodID);

            Console.WriteLine(method.ToString());

            var methodName = "Express";
            var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);
            
        }

        
    }
}
