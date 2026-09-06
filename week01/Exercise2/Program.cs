using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please type grade percentage: ");
        string ValueEnteredFromUser = Console.ReadLine();
        int gradePercentage = int.Parse(ValueEnteredFromUser);


    
         if (gradePercentage >= 97)
        {
            Console.WriteLine("Your grade is an A+.");
        }
     
         else if (gradePercentage >= 93)
        {
            Console.WriteLine("Your grade is an A.");

        }
         else if (gradePercentage >= 90)
        {
            Console.WriteLine("Your grade is an A-.");

        }

        else if (gradePercentage >= 87)
        {
            Console.WriteLine("Your grade is a B+.");
        }
        else if (gradePercentage >= 83)
        {
            Console.WriteLine("Your grade is a B.");
        }
        else if (gradePercentage >= 80)
        {
            Console.WriteLine("Your grade is a B-.");
        }
        else if (gradePercentage >= 77)
        {
            Console.WriteLine("Your grade is a C+.");
        }
        else if (gradePercentage >= 73)
        {
            Console.WriteLine("Your grade is a C.");
        }
        else if (gradePercentage >= 70)
        {
            Console.WriteLine("Your grade is a C.");
        }
        else if (gradePercentage >= 60)
        {
            Console.WriteLine("Your grade is a D.");
        }
        else
        {
            Console.WriteLine("Your grade is an F.");
        }
        
        if (gradePercentage >= 70)
        {
            Console.WriteLine("You passed the course.");
        }
        else
        {
            Console.WriteLine("You did not pass the course.");
        }
    }
}