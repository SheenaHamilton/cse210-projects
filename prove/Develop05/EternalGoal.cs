using System;

public class EternalGoal:Goal
{
    private int _timesCompleted;
    private int _bonusPoints;
    private int _bonusEvent;

    //Receives an imported goal line.
    public EternalGoal(string goalImportLine):base(goalImportLine)
    {
        ImportGoal(goalImportLine);
    }

    //Initiates a new Goal
    public EternalGoal():base()
    {
        NewEternalGoal();
    }

    public void SetTimesCompleted()
    {
        _timesCompleted += 1;
        if (_timesCompleted % _bonusEvent == 0)
        {
            SetBonusPoints();
        }
    }

    public void SetBonusPoints()
    {
        SetPointsEarned(_bonusPoints);
        Celebrate("BONUS", _bonusPoints);
    }

    public void SetPoints()
    {
        Console.WriteLine($"\nEternal Goal: {GetGoalValue()} points!");
        SetPointsEarned(GetGoalValue());
    }

    private void NewEternalGoal()
    {
        string response;
        int value;

        _timesCompleted = 0;

        Console.Write("Please enter how many completions until a bonus reward: ");
        response = Console.ReadLine();

        while(!int.TryParse(response, out value))
        {
            Console.Write($"\n{response} invalid integer. Please enter how many completions until a bonus reward: ");
            response = Console.ReadLine();

        }

        _bonusEvent = value;

        Console.Write("Please enter the bonus reward amount: ");
        response = Console.ReadLine();

        while(!int.TryParse(response, out value))
        {
            Console.Write($"{response} invalid integer. Please enter the bonus reward amount: ");
            response = Console.ReadLine();
        }

        _bonusPoints = value;

    }
  
    public override void DisplayGoal()
    {
        Console.Write($"[E] {GetName()} ({GetDesc()}) ~ [Completed {_timesCompleted} times]");
    }

    public override void RecordEvent()
    {
        //Eternal goal, continueous event, add number of times completed, add points. 
        Console.WriteLine($"\n*********************************************");
        SetPoints();
        SetTimesCompleted();
        Console.WriteLine($"\n*********************************************");
    }

    private void ImportGoal(string importGoalLine)
    {
        int completedIndex = 5;
        int bonusAmountIndex = 6;
        int bonusEventIndex = 7;

        string[] goalString = importGoalLine.Split("|");

        _timesCompleted = int.Parse(goalString[completedIndex]);
        _bonusPoints  = int.Parse(goalString[bonusAmountIndex]);
        _bonusEvent = int.Parse(goalString[bonusEventIndex]);
    }
    public override string ExportGoalFormat()
    {
        return ($"Eternal Goal:{GetName()}|{GetDesc()}|{IsComplete()}|{GetGoalValue()}|{GetPointsEarned()}|{_timesCompleted}|{_bonusPoints}|{_bonusEvent}");
    }

}