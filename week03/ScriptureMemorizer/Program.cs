using System;

class Program
{
    static void Main(string[] args)
    {
        // Display the current date and time, welcome message, and prompt the user to start memorizing a scripture.
        System.DateTime myDate = System.DateTime.Now;
        Console.WriteLine("Todays Date And Time: " + myDate.ToString());
        Console.WriteLine("Welcome to the Scripture Memorizer!");
        Console.WriteLine("Press Enter to start memorizing a scripture.");
        Console.ReadLine();

    // Create a Reference object for the scripture reference "Matthew 6:1" and a Scripture object with the reference and the scripture text.
        Reference reference = new Reference("Matthew", 6, 1);

        Scripture scripture = new Scripture(
            reference,
            "Take heed that ye do not your alms before men, to be seen of them: otherwise ye have no reward of your Father which is in heaven."
        );
// Start a loop that continues until the user chooses to quit. In each iteration, it clears the console, displays the scripture with hidden words, and prompts the user to either hide another word or quit. If all words are hidden, it informs the user that they have memorized the scripture.
        while (true)
        {
            Console.Clear();

            Console.WriteLine(scripture.GetDisplayText());

            Console.WriteLine();
            Console.WriteLine("Press Enter to hide a word.");
            Console.WriteLine("Press Q to quit.");

            string input = Console.ReadLine();

            if (input.ToLower() == "q")
            {
                break;
            }

            scripture.HideRandomWord();

            if (scripture.AllWordsHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine();
                Console.WriteLine("All words are hidden!, have memorized the scripture?");
                Console.WriteLine("If not restart again.");
            }
        }
    }
}