using System;

class Program
{
    static void Main(string[] args)
    {
        //Set up variables. Initialize playAgain to true to run through the first set.
        String inputPlayAgain = "yes";
        int numberGuesses = 0;

        // Loop while play again is yes
        while (inputPlayAgain == "yes")
        {
            //Get a random number 
            Random randomGenerator = new Random();  
            int magicNumber = randomGenerator.Next(1, 100);

            //init the guess number
            int guess = 0;

            // loop while guess is not the magic number 
            do
            {
                //Ask user for a guess. convert to int.
                Console.Write("What is your guess? ");
                string inputGuess = Console.ReadLine();
                guess = int.Parse(inputGuess);

                //Increment the numbr of guesses 
                numberGuesses = numberGuesses + 1;

                //Check if the guess is higher, lower or is the magic number
                if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else
                {
                    Console.WriteLine($"You guessed it! it took you {numberGuesses} tries");
                }
            } while (guess != magicNumber);

            // Ask the user if they want to play again
            Console.Write("Would you like to play again? ");
            inputPlayAgain = Console.ReadLine();
        }
    }
}