using System;

class Program
{
    static void Main(string[] args)
    {
        Boolean quitProgram = false;
        

        Console.Clear();
        Console.WriteLine("~*~  Welcome to Eternal Quest ~*~");
   
        GoalManager goalManager = new GoalManager();

        Console.Clear();  

        while (quitProgram != true)
        {
            Console.Clear();

            Console.WriteLine("\n\n~*~  Eternal Quest Menu ~*~\n");

            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine($"Current Level: {goalManager.GetGoalLevel()}");
            Console.WriteLine($"Starting Points: {goalManager.GetStartingPoints()}");
            Console.WriteLine($"Current Points: {goalManager.CalculateTotalPoints()}");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n\n");  

            Console.WriteLine("1. Create a Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals to File");
            Console.WriteLine("4. Load Goals from File");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit Program");

            Console.Write($"\nPlease select an option: ");

            string menuChoice= Console.ReadLine();
            Console.Clear();

            switch (menuChoice)
            {
                case "1": 
                    
                    Console.WriteLine("~*~ New Goal ~*~\n");
                    goalManager.NewGoal();
                    break;
                case "2": 
                    Console.WriteLine("~*~ Goal List ~*~\n");
                    goalManager.ListGoals();
                    break;
                case "3": 
                    Console.WriteLine("~*~ Save Goal File ~*~\n");
                    goalManager.SaveGoalFile();
                    break;
                case "4": 
                    Console.WriteLine("~*~ Load Goal File ~*~\n");
                    goalManager.LoadGoalFile();
                    break;
                case "5": 
                    Console.WriteLine("~*~ Record Goal Event ~*~\n");
                    goalManager.RecordGoalEvent();
                    break;
                case "6":
                    quitProgram = true;
                    int startingPoints = goalManager.GetStartingPoints();
                    int currentPoints = goalManager.CalculateTotalPoints();

                    if( startingPoints < currentPoints)
                    {
                        Console.WriteLine($"\nAmazing work! You started with {startingPoints} points and finished this session with {currentPoints} points! \n ");
                    }
                    
                    Console.WriteLine($"\nThank you for checking in! Next Level up is: \n\n~*~ {goalManager.GetNextLevel()} ~*~ ");
                    Console.WriteLine("\nKeep working on your goals!");
                    break;
                default:
                    break;
            }
            Wait();
        }
    }
    static void Wait()
    {
        Console.WriteLine("\nPress any key to continue...");
        Console.ReadLine();
    }

}