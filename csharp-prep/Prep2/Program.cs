using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade? ");
        float grade = float.Parse(Console.ReadLine());
        string letter = "";
        
        if (grade >= 90){
            letter = "A";
        }
        else if (grade >=80){
            letter = "B";
        }
        else if (grade >= 70){
            letter = "C";
        }
        else if (grade >= 60){
            letter = "D";
        }
        else if (grade < 60){
            letter = "F";
        }
        string sign = "";

        if (grade%10 >= 5 && letter == "A"){
            sign = "";
        }
        else if(letter == "F"){
            sign = "";
        }
        else if (grade%10 >= 5){
            sign = "+";
        }
        else if (grade%10 < 5){
            sign = "-";
        }
        

        Console.WriteLine($"With the grade you received, your corresponding letter grade is: {letter}{sign}");

    }
}