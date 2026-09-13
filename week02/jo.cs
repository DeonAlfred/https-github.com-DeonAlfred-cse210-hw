
using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();

        int choice = 0;

        while (choice != 5)
        {
            Console.WriteLine();
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");

            Console.Write("What would you like to do? ");

            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                journal.AddEntry();
            }
            else if (choice == 2)
            {
                journal.DisplayEntries();
            }
            else if (choice == 3)
            {
                Console.Write("Enter the filename to save to: ");
                string filename = Console.ReadLine();

                journal.SaveToFile(filename);
            }
            else if (choice == 4)
            {
                Console.Write("Enter the filename to load: ");
                string filename = Console.ReadLine();

                journal.LoadFromFile(filename);
            }
            else if (choice == 5)
            {
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid choice.");
            }
        }
    }
}


public class Journal
{
    private List<Entry> _entries = new List<Entry>();


    public void AddEntry()
    {
        PromptGenerator promptGenerator = new PromptGenerator();

        string prompt = promptGenerator.GetRandomPrompt();

        Console.WriteLine();
        Console.WriteLine($"Prompt: {prompt}");

        Console.Write("Response: ");
        string response = Console.ReadLine();

        string date = DateTime.Now.ToShortDateString();

        Entry entry = new Entry();

        entry._date = date;
        entry._prompt = prompt;
        entry._response = response;

        _entries.Add(entry);

        Console.WriteLine("Entry added.");
    }


    public void DisplayEntries()
    {
        Console.WriteLine();

        if (_entries.Count == 0)
        {
            Console.WriteLine("No journal entries found.");
            return;
        }

        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }


    public void SaveToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine(entry._date);
                outputFile.WriteLine(entry._prompt);
                outputFile.WriteLine(entry._response);
            }
        }

        Console.WriteLine("Journal saved.");
    }


    public void LoadFromFile(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        _entries.Clear();

        string[] lines = File.ReadAllLines(filename);

        for (int i = 0; i + 2 < lines.Length; i += 3)
        {
            Entry entry = new Entry();

            entry._date = lines[i];
            entry._prompt = lines[i + 1];
            entry._response = lines[i + 2];

            _entries.Add(entry);
        }

        Console.WriteLine("Journal loaded.");
    }
}


public class Entry
{
    public string _date;
    public string _prompt;
    public string _response;


    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_prompt}");
        Console.WriteLine($"Response: {_response}");
        Console.WriteLine();
    }
}


public class PromptGenerator
{
    private List<string> _prompts = new List<string>()
    {
        "What was the best part of your day?",
        "What are you grateful for today?",
        "What did you learn today?",
        "What was something interesting that happened today?",
        "What is something you want to accomplish tomorrow?"
    };


    public string GetRandomPrompt()
    {
        Random random = new Random();

        int index = random.Next(_prompts.Count);

        return _prompts[index];
    }
}
