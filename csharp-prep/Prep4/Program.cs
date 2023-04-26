using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> userNumbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int userNumber = -1;
        int sumNumbers = 0;
        int maxNumber = -99999;

        do
        {
            Console.Write("Enter number? ");
            string inputNumber= Console.ReadLine();
            userNumber = int.Parse(inputNumber);
        
            if (userNumber != 0)
            {
                userNumbers.Add(userNumber); 
                sumNumbers = sumNumbers + userNumber;
                if (userNumber > maxNumber)
                {   
                    maxNumber = userNumber;
                }
            }
            
        } while (userNumber != 0);

        double average = ((float)sumNumbers) / userNumbers.Count();
        Console.WriteLine($"The sum is {sumNumbers}.");
        Console.WriteLine($"The average is {average}.");
        Console.WriteLine($"The largest number is {maxNumber}.");

        Console.WriteLine("The sorted list is:");
        userNumbers.Sort();
        userNumbers.ForEach(Console.WriteLine);

    }
}