using System;

class Program
{
    static void Main(string[] args)
    {

        Outdoor outdoorEvent1 = new Outdoor("Expect clear skies and warm temperatures with a high of 22°C","Summer Music Festival", "Join us for a day of live music and fun under the sun.", new DateTime(2023, 07, 30, 14, 0, 0), "Hawrlack Park", "34 East Way", "Edmonton", "Alberta", "Canada", "T6X 1M1");

        Outdoor outdoorEvent2 = new Outdoor("Expect partly cloudy skies an temperatures ranging from 18°C - 20°C, providing a mix of sun and clouds for a pleasant day outdoors.", "Family Picnic in the Park", "Enjoy a delightful picnic with your loved ones.", new DateTime(2023, 08, 15, 12, 30, 0), "Riverside Park", "456 Park Avenue", "Chicago", "Illinois", "United States", "60601");

        Reception receptionEvent1 = new Reception(new DateTime(2023, 07, 20), "JamieAndKate@gmail.com", "Jamie and Kate'a Wedding Reception", "Join us for a joyous celebration as we exchange our vows and start our journey together.", new DateTime(2023, 08, 15, 17, 30, 0), "Grand View Hotel", "789 Grand Avenue", "Toronto", "Ontario", "Canada", "M5H 1K1");

        Reception receptionEvent2 = new Reception(new DateTime(2023, 10, 04), "EnglandPublicLibrary@gmail.com", "England Public Library Grand Opening", "Celebrating the magnificent new library that will serve the public. Reception to honor the organizations and individuals who donated to make this endevour a reality.", new DateTime(2023, 08, 15, 17, 30, 0), "England Public Library", "43 Park Avenue", "London", "England", "United Kingdom", "SW1A 1AA");

        Lecture lectureEvent1 = new Lecture("Mark Burgess", 200,"Exploring the Cosmos: Journey Through Space", "Join us for a captivating lecture on the wonders of the universe and the latest discoveries in space exploration.", new DateTime(2023, 11, 20, 19, 30, 0), "Meade Observatory", "789 Main Avenue", "Manchester", "Greater Manchester", "England", "M15 6BH");


        Console.WriteLine("\n---------------------------------------------------\n");
        Console.WriteLine("~ Short Details ~\n");
        Console.WriteLine(outdoorEvent1.ShortDetails());

        Console.WriteLine("\n~ Standard Details ~\n");
        Console.WriteLine(outdoorEvent1.StandardDetails());

        Console.WriteLine("\n~ Full Details ~\n");
        Console.WriteLine(outdoorEvent1.FullDetails());


        Console.WriteLine("\n---------------------------------------------------\n");
        Console.WriteLine("~ Short Details ~\n");
        Console.WriteLine(outdoorEvent2.ShortDetails());

        Console.WriteLine("\n~ Standard Details ~\n");
        Console.WriteLine(outdoorEvent2.StandardDetails());

        Console.WriteLine("\n~ Full Details ~\n");
        Console.WriteLine(outdoorEvent1.FullDetails());


        Console.WriteLine("\n---------------------------------------------------\n");
        Console.WriteLine("~ Short Details ~\n");
        Console.WriteLine(receptionEvent1.ShortDetails());

        Console.WriteLine("\n~ Standard Details ~\n");
        Console.WriteLine(receptionEvent1.StandardDetails());

        Console.WriteLine("\n~ Full Details ~\n");
        Console.WriteLine(receptionEvent1.FullDetails());


        Console.WriteLine("\n---------------------------------------------------\n");
        Console.WriteLine("~ Short Details ~\n");
        Console.WriteLine(receptionEvent2.ShortDetails());

        Console.WriteLine("\n~ Standard Details ~\n");
        Console.WriteLine(receptionEvent2.StandardDetails());

        Console.WriteLine("\n~ Full Details ~\n");
        Console.WriteLine(receptionEvent2.FullDetails());



        Console.WriteLine("\n---------------------------------------------------\n");
        Console.WriteLine("~ Short Details ~\n");
        Console.WriteLine(lectureEvent1.ShortDetails());

        Console.WriteLine("\n~ Standard Details ~\n");
        Console.WriteLine(lectureEvent1.StandardDetails());

        Console.WriteLine("\n~ Full Details ~\n");
        Console.WriteLine(lectureEvent1.FullDetails());

    }
}