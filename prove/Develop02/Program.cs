using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine($"\nWelcome to the Journal App");
        Boolean quit = false;
        string menuChoice;
        int menuNumber;
        Journal theJournal = new Journal();


        do
        {
            Console.WriteLine($"\n~~~~~~ Journal Menu ~~~~~~");
            Console.WriteLine("1. Write a Journal Entry");
            Console.WriteLine("2. Display the Journal Entries");
            Console.WriteLine("3. Save Journal to File");
            Console.WriteLine("4. Load Journal from File");
            Console.WriteLine("5. Quit Program");

            Console.Write($"\nPlease select an option: ");

            menuChoice = Console.ReadLine();
            menuNumber =  int.Parse(menuChoice);

            switch (menuNumber)
            {
                case 1: 
                    theJournal.MakeNewEntry();
                    break;
                case 2: 
                    theJournal.DisplayJournal();
                    break;
                case 3: 
                    theJournal.SaveJournal();
                    break;
                case 4: 
                    theJournal.LoadJournal();
                    break;
                case 5:
                    quit = true;
                    Console.Write($"\nThank you for using the Journal!\n ");
                    break;
                default:
                    break;
                               

            }

        }while (quit is false);
    }
}