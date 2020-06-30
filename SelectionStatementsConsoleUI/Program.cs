using System;

namespace SelectionStatementsConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            int FavoriteNumber = 11;

            Console.WriteLine("Guess my favorite number. Hint: below 20");
            int userGuess = int.Parse(Console.ReadLine());

            if (userGuess < FavoriteNumber)
            {
                Console.WriteLine("Too Low!! :(");
            }

            else if (userGuess > FavoriteNumber)
            {
                Console.WriteLine("Too High!! Try again!");
            }

            else if (userGuess == FavoriteNumber)
            {
                Console.WriteLine("Congratulations!! You got it!!! :) Here's a free ticket.");
            }

            else
            {
                Console.WriteLine("Nevermind");
            }

            string subject = "C#";

            Console.WriteLine("Choose a subject");
            string userSubject = Console.ReadLine();


            switch (userSubject)
            {
                case "C#":
                    Console.WriteLine("You are in the right class!");
                    break;
                case "Java":
                    Console.WriteLine("C# is better than Java");
                    break;
                case "Python":
                    Console.WriteLine("Python is an excellent language");
                    break;
                case "Javascript":
                    Console.WriteLine("That's a popular language");
                    break;
                case "HTML":
                    Console.WriteLine("Good to know when building websites");
                    break;
                default:
                    Console.WriteLine("We learn to code the right way!");
                    break;
            }
        }
    }
}
