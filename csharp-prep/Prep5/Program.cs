using System;
using System.ComponentModel.DataAnnotations;
using System.Data;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string User = PromptUserName();
        int faveNum = PromptUserNumber();
        int squared = SquareNumber(faveNum);
        DisplayResult(User, squared);

    }

    static void DisplayWelcome(){
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName(){
        Console.Write("What is your name? ");
        String name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber(){
        Console.Write("What is your favorite number? ");
        int num = int.Parse(Console.ReadLine());
        return num;
    }

    static int SquareNumber(int number){
        int squared = number*number;
        return squared;
    }

    static void DisplayResult(string firstName, int favoriteNum){
        Console.WriteLine($"Brother {firstName}, the square of your number is {favoriteNum}");
    }
}