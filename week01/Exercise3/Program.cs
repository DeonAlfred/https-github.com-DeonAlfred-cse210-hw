using System;

class Program
{
    static void Main(string[] args)
    {   
        string playAgain = "yes"; 
        while (playAgain.ToLower() == "yes")

    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int guess = -1;
        int guessCount = 0;

        Console.WriteLine("Welcome to the Number Guessing Game!");
        Console.WriteLine("Guess a magic number between 1 and 100.");
        

        while (guess != magicNumber)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (magicNumber > guess)
            {
                Console.WriteLine("Higher");
                Console.WriteLine("Try again.");

            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("Lower");
                Console.WriteLine("Try again.");
            }
            else
            {
                Console.WriteLine("********************************");
                Console.WriteLine("Congratulations! You guessed it!");
                Console.WriteLine($"It took you {guessCount} guesses.");
                Console.WriteLine("********************************");
            }
        }
    }
    }
}
        
