using System;
using System.Threading;

public class Program
{
    static void Main(string[] args)
    {
    
    
        while (true)
        {
            Console.Clear();
            DateTime currentDate = DateTime.Now;
             Console.WriteLine($"Welcome to the Mindfulness Program!\n");
             Console.WriteLine($"Today's date is: {currentDate}");
            // Display the menu options
            Console.WriteLine("                Menu Options\n");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflection activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.WriteLine();
            
            Console.Write("========Select a choice from the menu:========\n ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                // calling the BreathingActivity class and its Run method
                BreathingActivity activity = new BreathingActivity();
                activity.Run();
            }
            else if (choice == "2")
            {
                // calling the ReflectionActivity class and its Run method
                ReflectionActivity activity = new ReflectionActivity();
                activity.Run();
            }
            else if (choice == "3")
            {
                // calling the ListingActivity class and its Run method
                ListingActivity activity = new ListingActivity();
                activity.Run();
            }
            else if (choice == "4")
            {
                Console.WriteLine();
                Console.WriteLine("Thank you for using the Mindfulness Program and I hope you enjoyed it.");
                break;
            }
            else
            {   // Handle invalid input
                Console.WriteLine();
                Console.WriteLine("Your choice is invalid. Please select 1, 2, 3, or 4.");

                Thread.Sleep(1500);
            }
        }
    }
}