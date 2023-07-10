using System;

class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private Dictionary<int, string> _goalLevels = new Dictionary<int, string>();
    private Dictionary<int, string> _goalType = new Dictionary<int, string>();
    private string _fileName;
    private int _startingTotalPoints;
    private int _currentGoalLevel;

    public GoalManager()
    {
        _startingTotalPoints = 0;

        // add items to the level dictionary
        _goalLevels.Add(0, "Goal Newbie");
        _goalLevels.Add(1000, "Goal Apprentice");
        _goalLevels.Add(2000, "Goal 2nd Apprentice");
        _goalLevels.Add(3000, "Goal Warrior");
        _goalLevels.Add(4000, "Goal Ninja");
        _goalLevels.Add(5000, "Goal Master");

        //Add Goal Types dictionary
        _goalType.Add(1, "Simple Goal");
        _goalType.Add(2, "Checklist Goal");
        _goalType.Add(3, "Eternal Goal");

    }

    private Goal GetImportGoal(string goalType, string goalInfo)
    {
        //Passing the contructor the import string. normally we could seperate the string but the logic
        //will change based on the goal type. This keeps it simple and the class handles the import string.
        if (goalType == "Checklist Goal") return new ChecklistGoal(goalInfo);
        else if (goalType == "Eternal Goal") return new EternalGoal(goalInfo);
        else return new SimpleGoal(goalInfo);
    }

    
    private Goal GetNewGoal(string goalType)
    {
        //passes the correct goal object back.
        if (goalType == "Checklist Goal") return new ChecklistGoal();
        else if (goalType == "Eternal Goal") return new EternalGoal();
        else return new SimpleGoal();
    }

    public int GetStartingPoints()
    {
        return _startingTotalPoints;
    }

    public string GetGoalLevel()
    {
        return _goalLevels[_currentGoalLevel];
    }

    public void SetGoalLevel(Boolean importBypass = false)
    {
        int currentPoints = CalculateTotalPoints();
        int prevUserLevel = _currentGoalLevel;

        string currentLevel = "";
        
        foreach(var goalLevel in _goalLevels)
        {
            if (currentPoints >= goalLevel.Key)
            {
                currentLevel = goalLevel.Value;
                _currentGoalLevel = goalLevel.Key;
            } 
        }
       
       if ((prevUserLevel != _currentGoalLevel) && (importBypass == false))
       {
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadLine();
            Console.Clear();
            LevelUpAnimation(5,GetGoalLevel());

       }
    }

    public void LevelUpAnimation(int time, string level) 
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(time);

        DateTime currentTime = DateTime.Now;
        Console.CursorVisible = false;

        Console.WriteLine($"\n*****************************\n");

        Console.WriteLine($">>>  GOAL LEVEL UP  <<<");
        Console.WriteLine($"     {level}");

        Console.WriteLine($"\n*****************************\n");

        Console.SetCursorPosition(0,Console.CursorTop-4);
        while( currentTime < endTime)
        {
            Console.SetCursorPosition(0,Console.CursorTop-1);
            Console.WriteLine($">    GOAL LEVEL UP    <");
            Thread.Sleep(200);
            Console.SetCursorPosition(0,Console.CursorTop-1);
            Console.WriteLine($">>   GOAL LEVEL UP   <<");
            Thread.Sleep(200);
            Console.SetCursorPosition(0,Console.CursorTop-1);
            Console.WriteLine($">>>  GOAL LEVEL UP  <<<");
            Thread.Sleep(200);

            currentTime = DateTime.Now;
        }
        Console.CursorVisible = true;
        Console.SetCursorPosition(0,Console.CursorTop+3);
     } 

    public string GetNextLevel()
    {
        return _goalLevels[(_currentGoalLevel+1000)];
    }

    public void NewGoal()
    {
        Console.WriteLine("What type of goal would you like to create?");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Checklist Goal");
        Console.WriteLine("3. Eternal Goal"); 
        Console.Write("Please enter the number: ");

        string goalType = Console.ReadLine();

        if (goalType == "1" || goalType == "2" || goalType == "3")
        {
            _goals.Add(GetNewGoal(_goalType[int.Parse(goalType)]));
            Console.WriteLine($"\n* {_goalType[int.Parse(goalType)]} Created *\n");
        }
        else
        {
            Console.WriteLine($"{goalType}: Invalid goal type, must be a valid number associated to a goal. Goal entry cancelled.");
        }
         
    }

    public void ListGoals()
    {
        int numberList = 1;

        if (_goals.Count > 0)
        {
            foreach (Goal goal in _goals)
            {
                Console.Write ($"{numberList}. ");
                goal.DisplayGoal();
                Console.WriteLine ();
                numberList ++;
            }
        }
        else Console.WriteLine("There are no goals to list. Please load a goal file or create some new goals!");
    }

    public void RecordGoalEvent()
    {
        int goalIndex;
        ListGoals();
        if (_goals.Count > 0)
        {
            Console.Write("\nWhich goal would you like to record an event for?: ");
            string response = Console.ReadLine();

            while (!int.TryParse(response, out goalIndex))
            {
                Console.Write($"{goalIndex} not a valid integer. Please enter the goal number: ");
                response = Console.ReadLine();
            }

            goalIndex --;
            if(goalIndex < _goals.Count)
            {
                if  (_goals[goalIndex].IsComplete() != true)
                {
                    //Goal Index exists. 
                    _goals[goalIndex].RecordEvent();
                    Console.WriteLine($"\nYour total score is now:  {CalculateTotalPoints()} points");
                    SetGoalLevel();
                }
                else Console.WriteLine($"This goal is already complete. Record event cancelled.");
            }
            else Console.WriteLine($"There is no goal associated to this number {goalIndex}. Record event cancelled.");
        }
        else Console.WriteLine($"There is no goals. Record event cancelled.");
    }

    public void SaveGoalFile()
    {
        string overwriteFile = "Y";

        if(_fileName is not null)
        {
            Console.Write($"Continue to use {_fileName}? Y|N : ");
            overwriteFile = Console.ReadLine();
        }

        if (_fileName is null || overwriteFile.ToUpper() == "N")
        {
            Console.Write("\nPlease enter the name for the file: ");
            _fileName = Console.ReadLine();
            overwriteFile = "Y";
        }

        if (File.Exists(_fileName) && (overwriteFile.ToUpper() == "N"))
        {
            Console.Write($"\n{_fileName} File already exists, Overwrite the file? Y|N : ");
            overwriteFile = Console.ReadLine();
        } 

        if (overwriteFile.ToUpper() == "Y")
        {
            using (StreamWriter outputFile = new StreamWriter(_fileName))
            {
                foreach (Goal goal in _goals)
                {
                    outputFile.WriteLine(goal.ExportGoalFormat());
                }
            }
            Console.WriteLine($"\n* {_fileName} Goal File Saved *\n");
        }
        else Console.WriteLine($"\n* {_fileName} File Save Cancelled *\n");
    }


    public void LoadGoalFile()
    {
        string overwriteGoals = "Y";
        Boolean isFileLoadCancelled = false;

        Console.Write($"What is the name of your Goal File?: ");
        _fileName = Console.ReadLine();

        if (!File.Exists(_fileName))
        {
            isFileLoadCancelled = true;
            Console.WriteLine($"{_fileName} File does not exist");
        } 

        if ((_goals.Count() > 0) && isFileLoadCancelled == false)
        {
            Console.Write("\n!! Loading a file will overwrite the existing goals in the program. Do you wish to proceed? Y | N : ");
            overwriteGoals = Console.ReadLine();

            if (overwriteGoals.ToLower() == "y") _goals.Clear();
            else isFileLoadCancelled = true;
        }

        if (overwriteGoals.ToLower() == "y" && isFileLoadCancelled == false)
        {
            string[] fileLines = System.IO.File.ReadAllLines(_fileName);

            if (fileLines.Count() == 1 )
            {
                if (fileLines[0] == "")
                {
                    isFileLoadCancelled = true;
                    Console.WriteLine($"{_fileName} No goals found to load.");
                } 
            }
            else if (fileLines.Count() < 1) 
            {
                isFileLoadCancelled = true;
                Console.WriteLine($"{_fileName} No goals found to load.");
            }

            if (!(isFileLoadCancelled))
            {
                foreach (string line in fileLines)
                {
                    int typeIndex = 0;
                    int goalIndex = 1;

                    string[] goalString = line.Split(":");

                    _goals.Add(GetImportGoal(goalString[typeIndex],goalString[goalIndex]));
                }

                _startingTotalPoints = CalculateTotalPoints();
                SetGoalLevel(true);
                ListGoals();
                Console.WriteLine("\n* File Loaded *\n");
            }
        }

        if  (isFileLoadCancelled == true)
        {
            Console.WriteLine("\n* File Load Cancelled. *\n");
        }
    }

    public int CalculateTotalPoints()
    {
        int totalpoints = 0;
        foreach (Goal goal in _goals)
        {
            totalpoints += goal.GetPointsEarned();
        }
        return totalpoints;
    }
 
}