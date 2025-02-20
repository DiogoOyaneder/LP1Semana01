using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks.Dataflow;
using Microsoft.VisualBasic;

namespace ManyStrings
{
    public class Program
    {
        //Program starts here
        private static void Main(string[] args)
        {
            string str_1 = "this is a flag\n\u2690";
            string str_2 = "this is a \b \"test\" to try out \\escape characters\\\r";
            Console.WriteLine(str_1);
            Console.WriteLine(str_2);

            string str_3 = "Hello" + " " + "World";
            string str_4 = str_3 + 4;
            int x = 6;
            int y = 13;
            string x_value = "x is " + x;
            string add = $"{x} + {y} = {x + y}";
            Console.WriteLine(str_3);
            Console.WriteLine(str_4);
            Console.WriteLine(x_value);
            Console.WriteLine(add);

            double xx =1.23456;
            int ii = 19;
            string s1 = $"{xx:f2}";
            string s2 = $"{xx:p1}";
            string s3 = ii.ToString("X");
            string s4 = $"{ii:c}";
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            Console.WriteLine(s4);


        }
    }
}
