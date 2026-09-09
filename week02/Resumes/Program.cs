

    
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Resume resume = new Resume();

        resume._name = "Jake Smith";

        resume._jobs.Add(new Job
        {
            _jobTitle = "Software Developer",
            _company = "ABC Company",
            _startYear = 2020,
            _endYear = 2023
        });

        resume._jobs.Add(new Job
        {
            _jobTitle = "Senior Developer",
            _company = "XYZ Company",
            _startYear = 2023,
            _endYear = 2026
        });

        resume.Display();
    }
}

public class Resume
{
    public string _name;

    // Initialize the list before using it.
    public List<Job> _jobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        // Loop through every Job in the list
        foreach (Job job in _jobs)
        {
            // Call the Display method for each job
            job.Display();
        }
    }
}

public class Job
{
    public string _jobTitle;
    public string _company;
    public int _startYear;
    public int _endYear;

    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company})");
        Console.WriteLine($"{_startYear} - {_endYear}");
    }
}