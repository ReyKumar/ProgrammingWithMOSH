﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummarizingText1
{
    class Program
    {
        static void Main(string[] args)
        {
            var sentence = "This is going to be Really Really Really Really Really very Long";
            Console.WriteLine(SummarizeText());
        }

        private static string SummarizeText()
        {
            throw new NotImplementedException();
        }

        static string SummarizeText(string text, int maxLength = 20)
        {
            if (text.Length < maxLength)
            {
                return text;

            };
            var words = text.Split(' ');
            var totalCharacters = 0;
            var summaryWords = new List<string>();

            foreach (var word in words)
            {
                summaryWords.Add(word);
                totalCharacters += word.Length + 1;
                if (totalCharacters > maxLength)
                {
                    break;
                }

            }

            return String.Join(" ", summaryWords) + "...";
        }
    }
}
