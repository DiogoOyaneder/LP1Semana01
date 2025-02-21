using System;
using System.Globalization;
namespace AskForInput
{
    public class Program
    {
        //Program Starts Here
        private static void Main(string[] args)
        {
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
            Console.WriteLine("Inserir número intiero");
            int n_int = int.Parse(Console.ReadLine());
            Console.WriteLine("Inserir um número real");
            float n_float = float.Parse(Console.ReadLine());
            Console.WriteLine(n_int + n_float);
        }
    }
}
