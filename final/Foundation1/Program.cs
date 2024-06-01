using System;

class Program
{
static void Main(string[] args)
    {
        var videos = new List<Video>();

        var video1 = new Video("Learning C#", "John Doe", 300);
        video1.AddComment(new Comment("Alice", "Great tutorial!"));
        video1.AddComment(new Comment("Bob", "Very helpful, thanks!"));
        video1.AddComment(new Comment("Charlie", "I love this!"));
        videos.Add(video1);

        var video2 = new Video("Cooking Pasta", "Jane Smith", 600);
        video2.AddComment(new Comment("Dave", "Yummy recipe!"));
        video2.AddComment(new Comment("Eve", "Can't wait to try this!"));
        videos.Add(video2);

        foreach (var video in videos)
        {
            video.Display();
            Console.WriteLine();
        }
    }
}