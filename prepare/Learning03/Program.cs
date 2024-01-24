using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Fraction myFraction = new Fraction(1, 3);
        Console.WriteLine(myFraction.GetFractionString());
        double division = myFraction.GetDecimalValue();
        Console.WriteLine($"{division}");
    }
}