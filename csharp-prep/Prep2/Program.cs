using System;

class Program
{
    static void Main(string[] args)
    {
        int gradePass = 70;
        string letter = "";
        int classGrade;

        Console.Write("What is your grade percentage? ");
        string inputClassGrade = Console.ReadLine();

        classGrade = int.Parse(inputClassGrade);

        if (classGrade >= 90)
        {
            letter = "A";
        } 
        else if (classGrade >= 80 && classGrade < 90)
        {
            letter = "B";
        } 
        else if (classGrade >= 70 && classGrade < 80)
        {
            letter = "C";
        } 
        else if (classGrade >= 60 && classGrade < 70)
        {
            letter = "D";
        } 
        else
        {
            letter = "F";
        }
        

        Console.WriteLine($"Your letter grade is {letter}");

        if (classGrade >= gradePass)
        {
            Console.WriteLine("Congratulations on passing the course!");
        }
        else 
        {
            Console.WriteLine("Sorry, sometimes we have to try a few times, ty the course again!");
        }

    }
}