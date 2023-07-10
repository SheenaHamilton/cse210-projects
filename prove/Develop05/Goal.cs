using System;

public abstract class Goal
{
    private string _name;
    private string _description;
    private Boolean _complete;
    private int _goalValue;
    private int _pointsEarned;

    public Goal(string name, string description, Boolean complete, int goalValue, int pointsEarned)
    {
        _name = name;
        _description = description;
        _complete = complete;
        _goalValue = goalValue;
        _pointsEarned = pointsEarned;
    }

    public Goal(string importLine)
    {
        ImportGoal(importLine);
    }

    public Goal()
    {
        CreateNewGoal();
    }


    //Set and Gets: 

    //_name
    private void SetName(string name)
    {
        _name = name;
    }
    public string GetName()
    {
        return _name;
    }

    //_description
    private void SetDesc(string description)
    {
        _description = description;
    }
    public string GetDesc()
    {
       return _description;
    }

    //_complete
    public void SetComplete()
    {
        _complete = true;
        Celebrate("COMPLETE", _goalValue);
    }

    public Boolean IsComplete()
    {
        return _complete;
    }

    //GoalValue
    private void SetGoalValue(int goalvalue)
    {
        _goalValue = goalvalue;
    }
    public int GetGoalValue()
    {
        return _goalValue;
    }
    //points earned
    public void SetPointsEarned(int pointsEarned)
    {
        _pointsEarned += pointsEarned;
    }

    public int GetPointsEarned()
    {
        return _pointsEarned;
    }


    private string GoalStatus()
    {
        return $"{_name}: {_description} {_complete} {_pointsEarned}";
    }

    public void Celebrate(string status, int points)
    {
        if(status == "COMPLETE")
        {
            Console.WriteLine($"\n\nWooHoo! Awesome job! you finished {GetName()} goal!");
            CelebrateAnimation(5, points);
        }
        if(status == "BONUS")
        {
            Console.WriteLine("\n>> BONUS EVENT <<");
            CelebrateAnimation(5, points);
        }
        
    }

    public void CelebrateAnimation(int time, int points) 
    {
        //I don't want the spinner using the main endtime, it doesn't need to exist outside of this 
        //context

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(time);

        DateTime currentTime = DateTime.Now;
        Console.CursorVisible = false;
        while( currentTime < endTime)
        {
            Console.SetCursorPosition(0,Console.CursorTop);
            Console.Write($"     *     {points} POINTS!     *     ");
            Thread.Sleep(200);
            Console.SetCursorPosition(0,Console.CursorTop);
            Console.Write($"  *        {points} POINTS!        *  ");
            Thread.Sleep(200);
            Console.SetCursorPosition(0,Console.CursorTop);
            Console.Write($"        *  {points} POINTS! *         ");
            Thread.Sleep(200);

            currentTime = DateTime.Now;
        }
        Console.CursorVisible = true;
        Console.WriteLine();
     } 

    private void ImportGoal(string importGoalLine)
    {
        int nameIndex = 0;
        int descrIndex = 1;
        int completeIndex = 2;
        int goalValueIndex = 3;
        int pointsIndex = 4;

        string[] goalString = importGoalLine.Split("|");
        _name = goalString[nameIndex];
        _description = goalString[descrIndex];
        _complete = Boolean.Parse(goalString[completeIndex]);
        _goalValue = int.Parse(goalString[goalValueIndex]);
        _pointsEarned= int.Parse(goalString[pointsIndex]);
    }

    private void CreateNewGoal()
    {
        Console.Clear();
        Console.WriteLine("~*~  New Goal ~*~\n");

        Console.Write("Please enter the goal name: ");
        _name = Console.ReadLine();

        Console.Write("Please enter the goal description: ");
        _description = Console.ReadLine();

        _pointsEarned = 0;

        Console.Write("Please enter the goal points value: ");
        string response = Console.ReadLine();

        int value;

        while (!int.TryParse(response, out value))
        {
            Console.Write($"{value} not valid. Please enter the goal points value: ");
            response = Console.ReadLine();
        }
        
        _goalValue = value;
    }

    public abstract void RecordEvent();
    public abstract void DisplayGoal();
    public abstract string ExportGoalFormat();


}