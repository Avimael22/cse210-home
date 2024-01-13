using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        string response = "yes";
        while (response == "yes"){
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(1, 100);
            int hiddenNumber = number;

            int myNumber;

            Console.WriteLine("this is the guess the correct number game, please guess a number:");

            int count = 1;

            do{
                Console.WriteLine("Guess a number");
                myNumber = int.Parse(Console.ReadLine());
                if (myNumber == number){
                    Console.Write("Congratulations, you guessed the number!");
                }
                else if (myNumber > number){
                    Console.Write("Guess a little lower");
                    Console.WriteLine($"You have made {count} incorrect guesses");
                }
                else if (myNumber < number){
                    Console.Write("Guess a little higher");
                    Console.WriteLine($"You have made {count} incorrect guesses");
                }
                count += 1;
            } while(myNumber != number);
            Console.WriteLine("Do you wish to play again Y/n");
            response = Console.ReadLine();
        }
        
    }
}