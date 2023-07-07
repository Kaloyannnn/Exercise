using System;
using System.Collections.Generic;

namespace Diploma
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] quotes = {
            "The only way to do great work is to love what you do. - Steve Jobs",
            "Success is not final, failure is not fatal: It is the courage to continue that counts. - Winston Churchill",
            "In the middle of every difficulty lies opportunity. - Albert Einstein",
            "Believe you can and you're halfway there. - Theodore Roosevelt",
            "The best revenge is massive success. - Frank Sinatra"
            };

            Random random = new Random();
            List<string> usedQuotes = new List<string>();

            Console.WriteLine("Press Enter to get a random quote. Type 'quit' to exit.");

            while (true)
            {
                string userInput = Console.ReadLine();

                if (string.Equals(userInput, "quit")) break;

                if (usedQuotes.Count == quotes.Length)
                {
                    Console.WriteLine("You've seen all the quotes. Press the key 'Enter' to restart or type 'quit' to exit.");
                    usedQuotes.Clear();
                    continue;
                }

                string quote;
                do
                {
                    int index = random.Next(quotes.Length);
                    quote = quotes[index];
                } while (usedQuotes.Contains(quote));

                usedQuotes.Add(quote);

                Console.WriteLine("Random Quote of the day:");
                Console.WriteLine(quote);
            }
        }
    }
}


