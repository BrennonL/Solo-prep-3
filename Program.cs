using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Randomly generate a number between 1 and 100
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(1 , 100);
            Console.WriteLine($"{number}");
            string GuessString = "";
            int Guess = 0;

            // Set up a do while loop so that it runs the first time even if the randomly picked number is 0
            do
            {
                // Ask the user for a guess and trun that guess into an integer so that the do while loop will
                //will recognize it.
                Console.Write("What is the magic number?");
                GuessString = Console.ReadLine(); 
                Guess = int.Parse(GuessString);

                // If the guess is lower than the number print "Guess higher"
                if (number > Guess)
                {
                    Console.WriteLine("Guess higher");
                }

                // If the guess is higher than the number print "Guess lower"
                else if (number < Guess)
                {
                    Console.WriteLine("Guess lower");
                }

                // If they guess the correct number print "You guessed it!"
                else
                {
                    Console.Write("You guessed it!");
                }
                                
            }while (number != Guess);
        }
    }
}
