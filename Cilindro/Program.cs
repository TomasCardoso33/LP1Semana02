﻿using System;

namespace Cilindro
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.Write("Digite a altura do cilindro: ");
        float a = MathF.Abs(float.Parse(Console.ReadLine())); 

        Console.Write("Digite o raio do cilindro: ");
        float r = MathF.Abs(float.Parse(Console.ReadLine())); 

         
        float v = MathF.PI * MathF.Pow(r, 2) * a;

        

        Console.WriteLine($"Volume do cilindro: {v}");
        
        }
    }
}
