using System;

class Program
{
    static void Main(string[] args)
    {
        //Call the welcome function
        DisplayWelcome();

        //Call function to get users name.
        string userName = PromptUserName();

        //Call function to get users number
        int userNumber = PromptUserNumber();

        //Call function to square the number
        int squaredNumber = SquareNumber(userNumber);

        //Call function to display results
        DisplayResult(userName, squaredNumber);

    }

    static void DisplayWelcome ()
    {
        //Welcome user to the program
        Console.WriteLine("Welcome to the Program!");
    }
    static string PromptUserName ()
    {
        //Prompt user for name
        Console.Write("Please enter your name: ");
        string inputName = Console.ReadLine();

        //return name
        return inputName;
    }
    static int PromptUserNumber ()
    {
        //Prompt user for favorite number
        Console.Write("Please enter your favorite number: ");
        string inputNumber = Console.ReadLine();

        //convert input to integer
        int inNumber = int.Parse(inputNumber);

        //return favorite number
        return inNumber;
    }

    static int SquareNumber (int userNumber)
    {
        //Square the passed in number and return it
        int userNumberSquared = userNumber * userNumber;
        return userNumberSquared;
    }

    static void DisplayResult (string userName, int userNumSquared)
    {
        //Display the results to the user
        Console.WriteLine($"{userName}, the square of your number is {userNumSquared}");
    }


}