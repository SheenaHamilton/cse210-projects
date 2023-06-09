using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        
        Boolean quit = false;
        string menuChoice;
        int menuNumber;
        int activityCount = -1;
        DateTime startTime = new DateTime();

        startTime = DateTime.Now;

        do
        {
            activityCount += 1;

            Console.Clear();
            Console.WriteLine("~~*~~ Welcome to the Mindfulness Program ~~*~~\n");
            Console.WriteLine($"Menu Options:");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflecting Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. Quit");

            Console.Write($"\nSelect a choice from the menu: ");

            menuChoice = Console.ReadLine();
            menuNumber =  int.Parse(menuChoice);

            switch (menuNumber)
            {
                case 1: 
                    BreathingActivity newBreathing = new BreathingActivity();
                    newBreathing.GuidedBreathing();
                    
                    break;
                case 2: 
                    ReflectionActivity newReflection = new ReflectionActivity();
                    newReflection.GuidedReflection();
                    
                    break;
                case 3: 
                    ListingActivity newListing = new ListingActivity();
                    newListing.GuidedListing();
                    break;
                case 4: 
                    quit = true;
                    break;
                default:
                    break;              

            }

        }while (quit is false);

        TimeSpan totalTimeSpent;
        totalTimeSpent = (DateTime.Now - startTime);

        Console.WriteLine($"I hope you enjoyed this mindfulness program. You ran {activityCount} program(s) and spent {totalTimeSpent.ToString(@"mm")} minutes and {totalTimeSpent.ToString(@"ss")} seconds in the mindfulness program.");

    }


}