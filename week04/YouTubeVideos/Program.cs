using System;
using System.Collections.Generic;
using YouTubeVideos;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");

        // Create the first video
        Video video1 = new Video();
        video1._videoTitle = "Learn C# Programming";
        video1._videoAuthor = "Goodwill Moyo";
        video1._videoLength = 600;

        video1._comments.Add(new Comment("Mpokiseng", "Great tutorial!"));
        video1._comments.Add(new Comment("Nkosiyabo", "Very helpful."));
        video1._comments.Add(new Comment("Freeman", "I learned a lot!"));

        // Create the second video
        Video video2 = new Video();
        video2._videoTitle = "Introduction to Python";
        video2._videoAuthor = "Reaboka Moyo";
        video2._videoLength = 900;

        video2._comments.Add(new Comment("Rebokile", "Amazing video!"));
        video2._comments.Add(new Comment("Realeboga", "Thanks for sharing."));
        video2._comments.Add(new Comment("Rethabile", "Very informative."));

        // Create the third video
        Video video3 = new Video();
        video3._videoTitle = "How to Build Websites";
        video3._videoAuthor = "Zalobuhle Moyo";
        video3._videoLength = 1200;

        video3._comments.Add(new Comment("Reneiloe", "Excellent explanation!"));
        video3._comments.Add(new Comment("Refilwe", "This helped me a lot."));
        video3._comments.Add(new Comment("Nkosana", "Looking forward to more!"));

        // Create a list of videos
        List<Video> videos = new List<Video>();

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        // Display video information and comments
        foreach (Video video in videos)
        {
            Console.WriteLine("----------------------------------");
            Console.WriteLine($"Title: {video._videoTitle}");
            Console.WriteLine($"Author: {video._videoAuthor}");
            Console.WriteLine($"Length: {video._videoLength} seconds");
            Console.WriteLine($"Number of comments: {video.NumberOfComments()}");

            Console.WriteLine("\nComments:");

            foreach (Comment comment in video._comments)
            {
                Console.WriteLine($"{comment._commenterName}: {comment._commentText}");
            }

            Console.WriteLine();
        }
    }
}