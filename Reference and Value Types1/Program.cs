﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reference_and_Value_Types1
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 10;
            var b = a;
            b++;
            Console.WriteLine(string.Format("a: {0}, b: {1}", a, b));

            var array1 = new int[3] { 0, 1, 2 };
            var array2 = array1;
            array2[0] = 1;
            Console.WriteLine(string.Format("Array1[0]: {0}, Array2[0]: {1}", array1[0], array2[0]));
            Console.ReadLine();
        }
    }
}
