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
            // Decrementar
            Console.WriteLine($"{--b1}");
            //Incrementar
            Console.WriteLine($"{++b1}");
             // Divisão por 2
            Console.WriteLine($"{b1 / 2}");

            // Shift left por 3
            Console.WriteLine($"{b1 << 3}");

            // Xor com 5
            Console.WriteLine($"{b1 ^ 5}");

            // Se é maior que 10
            Console.WriteLine($"{b1 > 10}");
            
            
        }
    }
}
