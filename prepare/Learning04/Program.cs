using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment myMathAssignment = new MathAssignment("Sheena","Fractions", "Section 7.3", "134-144");
        
        Console.WriteLine(myMathAssignment.GetSummary());
        Console.WriteLine(myMathAssignment.GetHomeworkList());

        WritingAssignment myWritingAssignment = new WritingAssignment("Sheena","American Hstory", "The History of the Americas");
        
        Console.WriteLine(myWritingAssignment.GetSummary());
        Console.WriteLine(myWritingAssignment.GetWritingInformation());
    }
}