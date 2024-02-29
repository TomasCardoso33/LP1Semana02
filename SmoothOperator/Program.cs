using System;

namespace SmoothOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva um número inteiro não negativo");
            string s1 = Console.ReadLine();
            byte b1 = byte.Parse(s1);
            Console.WriteLine($"{--b1}");
            Console.WriteLine($"{++b1}");
            
            
        }
    }
}
