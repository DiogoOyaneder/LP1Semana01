using System;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks.Dataflow;

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
        }
    }
}
