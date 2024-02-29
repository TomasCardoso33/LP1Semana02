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
                    case "What's your name?":
                        response = "Gran'pa";
                        break;
                    case "EXIT":
                        response = "Ill be back";
                        break;
                    case  "Are you more intelligent than me?":
                        response = "Obviously!";
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
