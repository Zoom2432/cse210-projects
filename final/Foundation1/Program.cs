using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Learn Python in 10 hours", "Howdy Ho", 36000);
        Video video2 = new Video("Gamedev on C#", "Gosha Dudar", 1500);
        Video video3 = new Video("Which profession to choose in the IT field", "Howdy Ho", 1800);

        Comment video1Comment1 = new Comment("Lionel Messi", "Great video, thanks for the tutorial!");
        Comment video1Comment2 = new Comment("Neymar Jr", "I think it is impossible to learn a programming language in such a short period.");
        Comment video1Comment3 = new Comment("Ashley Cole", "I like Java better");

        video1.AddComment(video1Comment1);
        video1.AddComment(video1Comment2);
        video1.AddComment(video1Comment3);

        Comment video2Comment1 = new Comment("Cristiano Ronaldo", "thanks for sharing ur knowledge it helped me a lot");
        Comment video2Comment2 = new Comment("Ronaldinho", "This sounds incredible, great idea, can't wait to get started");
        Comment video2Comment3 = new Comment("Alexander Golovin", "Your tutorials were very good. The best I could find. Thank you!");

        video2.AddComment(video2Comment1);
        video2.AddComment(video2Comment2);
        video2.AddComment(video2Comment3);

        Comment video3Comment1 = new Comment("Luis Suarez", "I thought I wanted to be a Front-End Engineer. Now, I found my passion: Embedded Systems");
        Comment video3Comment2 = new Comment("Christian Pulisic", "As a first year CS student, I've literally been asking myself this for the last two days. Thanks for the vid");
        Comment video3Comment3 = new Comment("Zlatan Ibrahimovic", "This came just in time - Thank you so much!");

        video3.AddComment(video3Comment1);
        video3.AddComment(video3Comment2);
        video3.AddComment(video3Comment3);

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        Console.Clear();

        foreach(Video v in videos)
        {
            Console.WriteLine(v.DisplayVideoInf());
            Console.WriteLine($"Number of comments - {v.CommentsCount()}");
            Console.WriteLine("Comments:");
            v.DisplayComments();
            Console.WriteLine("\n");
        }
    }
}