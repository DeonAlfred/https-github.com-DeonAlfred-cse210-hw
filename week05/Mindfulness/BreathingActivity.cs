public class BreathingActivity : Activity
{
    public BreathingActivity()
        : base(
            """Breathing Activity""",
            """This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.""")
    {
    }

    public void Run()
    {
        // Display the starting message and get the duration from the user
        DisplayStartingMessage();

        Console.WriteLine();
        Console.WriteLine("""+++++++++++++Get ready to begin++++++++++""");
        ShowCountdown(5);
        Console.WriteLine("==============================================================");
        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());
        
        while (DateTime.Now < endTime)
        {
            Console.WriteLine();
            Console.WriteLine("""Breathe in...""");
            ShowCountdown(4);

            Console.WriteLine();
            Console.WriteLine("""Now breathe out...""");
            ShowCountdown(6);
        }

        DisplayEndingMessage();
    }
}
