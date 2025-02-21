using System;
using System.Globalization;
namespace Percentagem
{
    public class Program
    {
        private static void Main(string[] args)
        {
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
            Console.WriteLine("Intruduza 4 números entre 0 e 1, separados por linhas");
            float n_float1 = float.Parse(Console.ReadLine());
            float n_float2 = float.Parse(Console.ReadLine());
            float n_float3 = float.Parse(Console.ReadLine());
            float n_float4 = float.Parse(Console.ReadLine());
           
        }
    }
}
