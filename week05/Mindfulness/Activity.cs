public class Activity
{   
    private string _description;
    private string _name;
    private int _duration;
    // Constructor to initialize the activity with a name and description
    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }
    
    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
    }
    // Display the ending message after the activity is completed
    public void DisplayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Well done!");
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.");
        ShowSpinner(3);
    }
    // Show a countdown timer for the specified number of seconds
    public void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
    public int GetDuration()
    {
        return _duration;
    }

    // Show a spinner animation for the specified duration in seconds
    public void ShowSpinner(int durationInSeconds)
    {
        DateTime endTime = DateTime.Now.AddSeconds(durationInSeconds);
        while (DateTime.Now < endTime)
        {
            foreach (char c in "|/-\\")
            {
                Console.Write(c);
                Thread.Sleep(250);
                Console.Write("\b");
            }
        }
    }
}