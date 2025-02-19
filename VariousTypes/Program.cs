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

            double numb_double = 3.6483267;
            float numb_float = 5.2567f;
            decimal numb_decimal = 6.43273m;
            Console.WriteLine(numb_double);
            Console.WriteLine(numb_float);
            Console.WriteLine(numb_decimal);

            bool condition_T = true;
            bool condition_F = false;
            Console.WriteLine(condition_T);
            Console.WriteLine(condition_F);


        }
    }
}
