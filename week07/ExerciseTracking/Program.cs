using System;


class Program
{
    static void Main(string[] args)
    {
        {
         
        
        //  Creating List of activities 
        
        List<Activity> activities = new List<Activity>();

        // Calculating distance speed and pace for cycling activity
        activities.Add(new Cycling(
        new DateTime(2025, 11, 3), 30, 20.0));

        
        // Calculating distance speed and pace for Running activity
        activities.Add(new Running(
            new DateTime(2024, 11, 3), 30, 5.0));
       // Calculating distance speed and pace for Swimmming activity
        activities.Add(new Swimming(
            new DateTime(2026, 11, 3), 30, 40));
 

     // Loop through list of activities and returning the summary of each activity
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
}
    