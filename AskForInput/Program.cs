﻿using System;

namespace AskForInput
{
    public class Program
    {
        //Program Starts Here
        private static void Main(string[] args)
        {
            Console.WriteLine("Inserir número intiero");
            int n_int = int.Parse(Console.ReadLine());
            Console.WriteLine("Inserir um número real");
            float n_float = float.Parse(Console.ReadLine());
        }
    }
}
