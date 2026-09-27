using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a list of videos
        List<Video> videos = new List<Video>();

        // Create video objects and add comments
        Video video1 = new Video("Fishin Tutorial' with Desmond", "Desmond D", 600);
        video1.AddComment(new Comment("Grand", "Great tutorial!"));
        video1.AddComment(new Comment("Bob", "Very helpful, thanks!"));
        video1.AddComment(new Comment("Lionel", "This is awesome, never knew fishing can be this fun!"));

        Video video2 = new Video("Learn C#", "Jane Smith", 900);
        video2.AddComment(new Comment("Charlie", "I love this course!"));
        video2.AddComment(new Comment("Michael", "C# is great!"));
        video2.AddComment(new Comment("Susan", "I have seen C# videos before but this one is awesome!"));



        Video video3 = new Video("Chess Strategies", "Jane Smith", 900);
        video3.AddComment(new Comment("Jack", "I love this course!"));
        video3.AddComment(new Comment("Mary", "This is a great chess tutorial!"));
        video3.AddComment(new Comment("Angelou", "I Love this !"));

        Video video4= new Video("World of Birds", "Johnathan Watt", 900);
        video4.AddComment(new Comment("Jamie", "I loved watching this!"));
        video4.AddComment(new Comment("Greg", "This is a stress reliever!"));
        video4.AddComment(new Comment("Dianne", "Can you mmake more please?"));
        video4.AddComment(new Comment("Jamie", "Beautiful"));



        // Add videos to the list
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        videos.Add(video4);
        // Display information about each video and its comments
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLengthInSeconds()} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.GetName()}: {comment.GetText()}");
            }
            Console.WriteLine();
        }
    }
}