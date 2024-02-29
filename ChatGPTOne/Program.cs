using System;

namespace ChatGPTOne
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string question, response;

            do
            {
                Console.Write("Ask and i shall answer? (or say EXIT to quit) ");
                question = Console.ReadLine();


                switch (question)
                {
                    case "Who are you?":
                        response = "Im the one who knocks!";
                        break;
                    case "Whats 9+10":
                        response = "21";
                        break;
                    case "EXIT":
                        response = "Ill be back";
                        break;
                    default:
                        response = "Im rubbish and dont know what you are saying";
                        break;
                }

                // Responder adequadamente
                Console.WriteLine(response);
            } while (true);
        }
    }
}
