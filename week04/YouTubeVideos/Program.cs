using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Learn C# Basics", "Programming Academy", 720);

        video1.AddComment(new Comment("Daniel", "Great tutorial!"));
        video1.AddComment(new Comment("Maria", "Very easy to understand."));
        video1.AddComment(new Comment("John", "Thanks for sharing."));

        videos.Add(video1);


        Video video2 = new Video("Piano for Beginners", "Music World", 950);

        video2.AddComment(new Comment("Anna", "Excellent lesson."));
        video2.AddComment(new Comment("Michael", "I learned a lot."));
        video2.AddComment(new Comment("Sophia", "Please make more videos."));

        videos.Add(video2);


        Video video3 = new Video("Healthy Eating Tips", "Health Channel", 680);

        video3.AddComment(new Comment("Chris", "Very informative."));
        video3.AddComment(new Comment("Emily", "Nice advice."));
        video3.AddComment(new Comment("David", "Thank you!"));

        videos.Add(video3);


        Video video4 = new Video("Travel Guide to Japan", "World Explorer", 1400);

        video4.AddComment(new Comment("Olivia", "Amazing places."));
        video4.AddComment(new Comment("James", "I want to visit."));
        video4.AddComment(new Comment("Sarah", "Beautiful video."));

        videos.Add(video4);


        foreach (Video video in videos)
        {
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Title: " + video.GetTitle());
            Console.WriteLine("Author: " + video.GetAuthor());
            Console.WriteLine("Length: " + video.GetLength() + " seconds");
            Console.WriteLine("Number of Comments: " + video.GetCommentCount());
            Console.WriteLine();

            Console.WriteLine("Comments:");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine(comment.GetName() + ": " + comment.GetText());
            }

            Console.WriteLine();
        }
    }
}