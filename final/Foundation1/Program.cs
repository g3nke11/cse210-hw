using System;

class Program
{
    static void Main(string[] args)
    {
        // First video
        Comment com1 = new Comment("John", "Nice video!");
        Comment com2 = new Comment("Sam", "Terrible video!");
        Comment com3 = new Comment("Bob", "This is a very interesting video. Please continue to post more.");
        Video vid1 = new Video("Programming for dummies", "BlueGrass", 25, [com1, com2, com3]);
        
        // Second Video
        Comment com4 = new Comment("Johnny", "Interesting video!");
        Comment com5 = new Comment("Sammy", "Aweful video!");
        Comment com6 = new Comment("Bob", "This is a very interesting video. Please continue to post more.");
        Video vid2 = new Video("Programming for geniuses", "BlueGrass", 120, [com1, com2, com3]);
        
        // Third Video
        Comment com7 = new Comment("J-Man", "CCOOOOLLLL!");
        Comment com8 = new Comment("Annoymous", "My eyes!!!!");
        Comment com9 = new Comment("H3lp", "What the heck did I just watch?");
        Video vid3 = new Video("Programming for @#$^#$%#$^#$$%#$%", "BlueWhoops", 1, [com1, com2, com3]);
        
        List<Video> videos = [vid1, vid2, vid3];
        foreach (Video vid in videos)
        {
            vid.Display();
            vid.DisplayComments();
        }
    }
}