using System;

namespace SelectionStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the number guessing game!");
            Console.WriteLine("See if you can guess the number!");

            var random = new Random();
            var number = random.Next(1, 1000);

            Console.WriteLine("Input your guess:");

            var guess = int.Parse(Console.ReadLine());

            if(guess > number)
            {
                Console.WriteLine("too high!");
            }

            else if(guess < number)
            {
                Console.WriteLine("too low!");
            }

            else
            {
                Console.WriteLine("Correct!");
            }

        }
    }
}
