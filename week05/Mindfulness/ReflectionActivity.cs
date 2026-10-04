using System;
using System.Collections.Generic;
// This class represents a reflection activity that prompts the user to reflect on past experiences and answer questions related to those experiences.
public class ReflectionActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;
    private Random _random;

    public ReflectionActivity()
        : base(
            """Reflection Activity""",
            """This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.""")
    {
        _random = new Random();

        _prompts = new List<string>
        {   """Think when you have felt the Spirit to help others.""",
            """Remember a time when you stood up for someone else.""",
            """Think of a time when you did something really difficult.""",
            """Think of a time when you helped someone in need.""",
            """Think of a time when you did something truly selfless."""
        };

        _questions = new List<string>
        {
            """Why this experience meaningful to you?""",
            """Have you ever done anything  this before?""",
            """How did you get started?""",
            """How did you feel when it was complete?""",
            """What made this time different than other times when you were not as successful?""",
            """What is your favorite thing about this experience and why?""",
            """What could you learn from this experience that applies to other situations?""",
            """ Did you learn about yourself through this experience?""",
            """How can you keep this experience in mind in the future?"""
        };
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine();
        Console.WriteLine("""Consider the following prompt:""");
        Console.WriteLine();

        string prompt = _prompts[_random.Next(_prompts.Count)];

        Console.WriteLine($"""--- {prompt} ---""");

        Console.WriteLine();
        Console.WriteLine(
            """When you have something to reflect on, press Enter to continue."""
        );

        Console.ReadLine();

        Console.WriteLine();

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());
        // Loop until the specified duration has elapsed
        while (DateTime.Now < endTime)
        {
            string question = _questions[_random.Next(_questions.Count)];

            Console.WriteLine();
            Console.WriteLine(question);
            Console.WriteLine();

            ShowSpinner(5);
        }

        DisplayEndingMessage();
    }
}