using System;

class Program
{
    static void Main(string[] args)
    {
        Videos videoList = new Videos();

        // First video created and added to the list
        Video vid1 = new Video();
        vid1.SetTitle("How to Bake a Cake");
        vid1.SetAuthor("Baking 101");
        vid1.SetLength(500);
        Comment v1Com1 = new Comment("Alyssa", "Love the content!");
        vid1.AddComment(v1Com1);
        Comment v1Com2 = new Comment("Mikey Shawn", "What's your favorite food?");
        vid1.AddComment(v1Com2);
        Comment v1Com3 = new Comment("Shaun Spencer", "I like cheese!");
        vid1.AddComment(v1Com3);

        videoList.AddVideo(vid1);

        // Second video created and added to list
        Video vid2 = new Video();
        vid2.SetTitle("Generic Gaming Video");
        vid2.SetAuthor("Gaming Central");
        vid2.SetLength(200);
        Comment v2Com1 = new Comment("John Doe", "Very epic video!");
        Comment v2Com2 = new Comment("Mary Steve", "How do I get this game you played?");
        Comment v2Com3 = new Comment("Abby Count", "Where can I play?");
        vid2.AddComment(v2Com1);
        vid2.AddComment(v2Com2);
        vid2.AddComment(v2Com3);

        videoList.AddVideo(vid2);

        // Third video created and added
        Video vid3 = new Video();
        vid3.SetTitle("How to Program in C#");
        vid3.SetAuthor("Coding Masters");
        vid3.SetLength(800);
        Comment v3com1 = new Comment("Noob Coder", "Can you explain for loops?");
        Comment v3com2 = new Comment("Jimmy John", "I appreciate the video! :)");
        Comment v3com3 = new Comment("Brent Smith", "Where can I subscribe?");
        vid3.AddComment(v3com1);
        vid3.AddComment(v3com2);
        vid3.AddComment(v3com3);

        videoList.AddVideo(vid3);

        // Code to loop through the video list and display each video
        videoList.DisplayVideos();
    }
}