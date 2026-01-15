using System;

class Program
{
    static void Main(string[] args)
    {
        
        string playAgain = "yes";

        while (playAgain == "yes")
        {
            
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101); 

            int guess = -1;
            int count = 0; 

            
            while (guess != magicNumber)
            {
                Console.WriteLine("Guess a number between 1 and 100:");
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                count++;

                
                if (magicNumber > guess)
                {
                    Console.WriteLine("Higher");
                }
                else if (magicNumber < guess)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }
            }

            
            Console.WriteLine($"It took you {count} guesses.");

            
            Console.Write("Do you want to play again (yes/no)? ");
            playAgain = Console.ReadLine().ToLower();
        }

        Console.WriteLine("Thanks for playing!");
    }
}