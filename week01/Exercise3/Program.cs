using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        string playAgain = "yes";
        while (playAgain == "yes")
        {
            Random randomGenerator = new Random ();
            int magicNumber = randomGenerator.Next (1, 101);

            int guess = 0;
            int guesses = 0;
            while(guess != magicNumber)
            {
                Console.Write("What is your guess?");
                guess = int.Parse(Console.ReadLine());
                guesses++;

                if (guess<magicNumber)
                {
                   Console.WriteLine ("Higher") ;
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guess it!");
                }
            }
            Console.WriteLine("Number of guesses" + guesses);
            Console.WriteLine("Do you want to continue?");
            playAgain = Console.ReadLine();
        }
    }
}