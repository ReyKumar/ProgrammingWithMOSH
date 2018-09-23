using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatements3
{
    class Program
    {
        static void Main(string[] args)
        {
            var season = Season.सर्दी;

            switch (season)
            {
                case Season.सर्दी:
                    Console.WriteLine("अभी सर्दी का सीज़न हें"); // Console Not Support Hindi Font
                    Console.WriteLine("This is Winter");
                    break;

                case Season.गर्मी:
                    Console.WriteLine("अभी गर्मी का सीज़न हें");
                    Console.WriteLine("This is Summer");
                    break;

                case Season.बरसात:
                    Console.WriteLine("अभी बरसात का सीज़न हें");
                    Console.WriteLine("This is Rainy");

                    break;
                default:
                    Console.WriteLine("पता नही यह कोनसा सीज़न हें");
                    Console.WriteLine("I Don't Know this Season");

                    break;
                    
            }

            // 2nd Method
            switch (season)
            {
                case Season.सर्दी:
                case Season.गर्मी:
                    Console.WriteLine("You have Got Prmotion");
                    break;

                default:
                    Console.WriteLine("पता नही यह कोनसा सीज़न हें");
                    Console.WriteLine("I Don't Know this Season");
                    break;
            }
            Console.ReadKey();
        }
    }
}
