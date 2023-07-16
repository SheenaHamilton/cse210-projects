using System;

class Program
{
    static void Main(string[] args)
    {

        Video video1 = new Video( "How to learn Javascript in 90 days",  "Jessica Raymond",  20);
        video1.AddComment("Eric Anderson", "Awesome! I've been looking everywhere for where to start. I found this video informative on where to begin my JavaScript journey! Thanks!");
        video1.AddComment("Maise Steward", "Great review, I found some new information that helps a lot.");
        video1.AddComment("Jen Laurie", "I have been having so much difficulty trying to find where the right place to start is, I start these tutorials and they're usually too far into JavaScript I get lost so quick, I needed a plan where I could learn the basics. This was everything I needed in one stop. thanks!");
        video1.AddComment("Scott Randall", "Good. I've done most of the programs listed in here already but I learned a lot from them.");

        Video video2 = new Video( "Best Chocolate Cake",  "Mike Peters",  15);
        video2.AddComment("Amanda Svenson", "mmmmmm, I can already smell it. Looks amazing, will have to try this sometime!");
        video2.AddComment("Chace Reeves", "Made this for Mothers Day. It was a hit.");
        video2.AddComment("Tiana Cross", "Didn't turn out for me, not sure what I did wrog. There's so many great reviews I'm sure it was something I did, it came out a little bland and dry.");
        video2.AddComment("Meredith Hummings", "Added more cocoa. It was miagnificent. Best chocolate cake EVER. I would suggest underbaking just slighty to avoid a dry cake. A++.");

        Video video3 = new Video( "Changing a tire - the Baiscs",  "Mike Hamsworth",  10);
        video3.AddComment("Tina Glubish", "Very valuable tutorial for anyone who owns a car. Saved me from calling the tow truck.");
        video3.AddComment("Alex Rowas", "Good. Great basic tutorial, thanks man, showed my teenagers this to tech them how to change a tire.");
        video3.AddComment("Amber Feys", "This is very basic, would like some tutorials with a bit more information.");
        video3.AddComment("Jaren Riker", "Great, was super simple and straight to the point.");

        Video video4 = new Video( "Top 20 Summer Movies",  "Gloria Stevens",  5);
        video4.AddComment("Michelle Toone", "OOh, loved this, I remember all of these movies when I was growing up, great memories of them.");
        video4.AddComment("John Laurie", "Pretty corny, probably best for families.");
        video4.AddComment("Nicola Ashen", "Totally watching these with my kids this summer, great list, all family friendly, love it!");
        video4.AddComment("Amy Heamer", "Watched these with my friends, great list!");

        Console.Clear();

        video1.DisplayVideoInformation();
        video2.DisplayVideoInformation();
        video3.DisplayVideoInformation();
        video4.DisplayVideoInformation();
    }

}