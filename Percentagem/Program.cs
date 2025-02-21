using System;
using System.Globalization;
using System.Runtime.Intrinsics.Arm;
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
           string s1 = $"{n_float1,10}";
           string s2 = $"{n_float2,10}";
           string s3 = $"{n_float3,10}";
           string s4 = $"{n_float4,10}";
        }
    }
}
