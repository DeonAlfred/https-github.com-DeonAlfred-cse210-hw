public class ListingActivity : Activity
{
    public ListingActivity()
        : base(
            """Listing Activity""",
            """This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.""")
    {
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine();
        Console.WriteLine("""Be ready...""");
        ShowCountdown(5);

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            Console.WriteLine();
            Console.WriteLine("""List as many things as you can in the following area:""");
            Console.WriteLine("""-Think about things that make you happy""");

            ShowCountdown(10);
        }

        DisplayEndingMessage();
    }
}