using System;

namespace VariousTypes
{
    public class Program
    {
        /// Program starts here
        private static void Main(string[] args)
        {
            int numb_int = 54;
            int numb_int_hex = 0x6f;
            int numb_int_bi = 0b1101011;

            Console.WriteLine(numb_int);
            Console.WriteLine(numb_int_hex);
            Console.WriteLine(numb_int_bi);

            char star = '\u2606';
            char horse = '\u2658';
            char exclamation2 = '\u203c';
            Console.WriteLine(star);
            Console.WriteLine(horse);
            Console.WriteLine(exclamation2);
        }
    }
}
