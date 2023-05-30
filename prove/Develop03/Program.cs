using System;

class Program
{
    static void Main(string[] args)
    {
        string response = "";
        Boolean quit = false;
        Boolean scriptureComplete = false;      
       

        Console.Clear();

        Console.WriteLine("\nWelcome to the Scripture Memorizer. ");

        string verse = "";
        string book = "";
        int chapter = 0;
        int verseStart = 0;
        int verseEnd = -1;

        do 
        {
            Console.Write("ENTER a scripture or use a DEFAULT scripture? please enter ENTER or DEFAULT :  ");
            response = Console.ReadLine().ToLower();

            if(response == "default")
            {

                verse = "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.";

                book = "1 Nephi";
                chapter = 3;
                verseStart = 7;
                verseEnd = -1;

            }
            else if (response == "enter")
            {
                
                Console.Write("Book: ");
                book = Console.ReadLine();

                Console.Write("Chapter: ");
                chapter = int.Parse(Console.ReadLine());

                Console.Write("Verse Start: ");
                verseStart = int.Parse(Console.ReadLine());

                Console.Write("Do you have an End verse? Y | N : ");

                if (Console.ReadLine().ToLower() == "y")
                {
                    Console.Write("Verse End: ");
                    verseEnd = int.Parse(Console.ReadLine());
                }

                Console.Write("Verse: ");
                verse = Console.ReadLine();

            }
            else
            {
                Console.Write("Not a valid response. Please try again. ");
            }


        } while (!(response == "enter" || response == "default"));

        Scripture scriptureVerse = new Scripture(verse,book,chapter,verseStart,verseEnd);

        while (!quit && !scriptureComplete)
        {
            Console.Clear();
            Console.WriteLine( "___________________________________SCRIPTURE MEMORIZER___________________________________\n");
            Console.WriteLine(scriptureVerse.getReference());
            Console.WriteLine(scriptureVerse.getVerse());

            Console.WriteLine("\nPress enter to continue or type 'quit' to finish:");
            response = Console.ReadLine();

            if(response=="")
            {
                if (scriptureVerse.getWordsRemaining() <= 0)
                {
                    scriptureComplete = true;
                }
                else
                {
                    scriptureVerse.HideWord();
                    scriptureVerse.HideWord();
                }
                
            }
            else if (response.ToLower() == "quit")
            {
                quit = true;
            }
        }


        if (scriptureComplete)
        {
            Console.WriteLine( "\n~ * Congrats!! You completed the scripture! * ~ ");
        }
       else if (quit)
        {
            Console.WriteLine( "\n ... Sorry to see you go. Play again soon!");
        }
        
        Console.WriteLine( "_________________________________________________________________________________________\n");
    }



}