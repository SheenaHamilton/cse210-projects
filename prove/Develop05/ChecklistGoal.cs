using System;

public class ChecklistGoal:Goal
{
    private int _totalSteps;
    private int _completedSteps;
    private int _bonusPointValue;

    //Receives an imported goal line.
    public ChecklistGoal(string goalImportLine):base(goalImportLine)
    {
        ImportGoal(goalImportLine);
    }

    //Initiates a new Goal
    public ChecklistGoal():base()
    {
        NewChecklistGoal();
    }

    public void SetTotalSteps(int totalSteps)
    {
        _totalSteps = totalSteps;
    }

    public void SetCompletedSteps()
    {
        _completedSteps += 1;
        SetPointsEarned(_bonusPointValue);
        Console.WriteLine($"Checklist Goal: step completed.");
        Celebrate("BONUS",_bonusPointValue);

        if (_completedSteps == _totalSteps)
        {
            SetPointsEarned(GetGoalValue());
            SetComplete();
        }
    }

    private void NewChecklistGoal()
    {
        string response;
        int value;

        Console.Write("Please enter the total steps: ");
        response = Console.ReadLine();

        while (!int.TryParse(response, out value))
        {
            Console.WriteLine($"{value} not a valid integer. Please enter the total steps: ");
            response = Console.ReadLine();
        }
        
        _totalSteps = value;

        Console.Write("Please enter the bonus amount (for each step completed): ");
        response = Console.ReadLine();  

        while (!int.TryParse(response, out value))
        {
            Console.Write($"{value} not a valid integer. Please enter the bonus amount: ");
            response = Console.ReadLine();
        }
        _bonusPointValue = value;
        _completedSteps = 0;
            
    }
    public override void DisplayGoal()
    {
        Boolean isComplete = IsComplete();
        string completeStatus = "[ ]";

        if (isComplete == true) completeStatus = "[X]";
 
        Console.Write($"{completeStatus} {GetName()} ({GetDesc()}) ~ [Completed {_completedSteps}/{_totalSteps}]");
    }

    public override void RecordEvent()
    {
        //Checklist goal, set the number of times complete +1 and check to see if a bonus or complete stage is acheived.
        Console.WriteLine($"\n*********************************************");
        SetCompletedSteps();
        Console.WriteLine($"\n*********************************************");
    }

    private void ImportGoal(string importGoalLine)
    {
        int stepsIndex = 5;
        int stepsCompleteIndex = 6;
        int bonusIndex = 7;

        string[] goalString = importGoalLine.Split("|");

        _totalSteps = int.Parse(goalString[stepsIndex]);
        _completedSteps = int.Parse(goalString[stepsCompleteIndex]);
        _bonusPointValue= int.Parse(goalString[bonusIndex]);
    }

   public override string ExportGoalFormat()
    {
        return ($"Checklist Goal:{GetName()}|{GetDesc()}|{IsComplete()}|{GetGoalValue()}|{GetPointsEarned()}|{_totalSteps}|{_completedSteps}|{_bonusPointValue}");
    }

}