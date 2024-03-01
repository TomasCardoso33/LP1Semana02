using System;

namespace MagicGun
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer;
            Console.WriteLine("Escreva um número inteiro:  ");
            string s1 = Console.ReadLine();
            int n = int.Parse(s1);
            
            for (int i =0;i < n; i++)
            {
                if (i%3 == 0)
                {
                    answer = "Magic Fire";
                }
                if (i%5 == 0)
                {
                    answer = "Eletric Fire";
                }
                else
                {
                    answer = "Normal Fire :/";
                }
                Console.WriteLine($"{i}: {answer}");
            }




        }
    }
}
