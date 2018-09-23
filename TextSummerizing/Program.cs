using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextSummerizing
{
    class Program
    {
        static void Main(string[] args)
        {
            var sentence = "This is Going to be Really Really Really Really Really Really Long Text";
            const int maxLength = 20;

            if (sentence.Length < maxLength)
            {
                Console.WriteLine(sentence);
            }
            else
            {
                var words = sentence.Split(' ');
                var totalCharacters = 0;
                var summeryWords = new List<string>();

                foreach (var word in words)
                {
                    summeryWords.Add(word);

                    totalCharacters = word.Length + 1;
                    if (totalCharacters > maxLength)
                    {
                        break;
                    }
                }

                var summary = String.Join(" ", summeryWords) + " ...";
                Console.WriteLine(summary);

            }
            Console.ReadKey();
        }



    }
}
