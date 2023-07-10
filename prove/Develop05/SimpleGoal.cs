using System;

public class SimpleGoal:Goal
{
    //Receives an imported goal line.
    public SimpleGoal(string goalImportLine):base(goalImportLine)
    {
    }

    //Initiates a new Goal
    public SimpleGoal():base()
    {
    }

    public void SetPoints()
    {
        int goalvalue = GetGoalValue();
        Console.Write($"Simple Goal: Completed!");
        SetPointsEarned(goalvalue);
    }

    public override void DisplayGoal()
    {
        Boolean isComplete = IsComplete();
        string completeStatus = "[ ]";

        if (isComplete == true) completeStatus = "[X]";
 
        Console.Write($"{completeStatus} {GetName()} ({GetDesc()})");

    }

    public override void RecordEvent()
    {
        //Simple goal, one time event once an event occurs set the points and set the task to complete.
        Console.WriteLine($"\n*********************************************");
        SetPoints();
        SetComplete();
        Console.WriteLine($"\n*********************************************");
    }

   public override string ExportGoalFormat()
    {
        return ($"Simple Goal:{GetName()}|{GetDesc()}|{IsComplete()}|{GetGoalValue()}|{GetPointsEarned()}");
    }

}