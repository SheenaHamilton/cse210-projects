using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction myFraction = new Fraction();
        Fraction myFraction1 = new Fraction(6);
        Fraction myFraction2 = new Fraction(6,7);

        Console.WriteLine ("\nNo Param Constructor");
        Console.WriteLine (myFraction.GetFractionString());
        Console.WriteLine (myFraction.GetDecimalValue());

        Console.WriteLine ("\nSingle Param Constructor");
        Console.WriteLine (myFraction1.GetFractionString());
        Console.WriteLine (myFraction1.GetDecimalValue());      

        Console.WriteLine ("\nTwo Param Constructor");
        Console.WriteLine (myFraction2.GetFractionString());
        Console.WriteLine (myFraction2.GetDecimalValue());      

        Console.WriteLine ("\nSet Top: 5 & Bottom: 9");
        myFraction.SetTop(5);
        myFraction.SetBottom(9);
        Console.WriteLine ("Get Top & Bottom");
        Console.WriteLine (myFraction.GetTop());
        Console.WriteLine (myFraction.GetBottom());
        Console.WriteLine ("Get Fraction & Decimal");
        Console.WriteLine (myFraction.GetFractionString());
        Console.WriteLine (myFraction.GetDecimalValue());          

    }
}