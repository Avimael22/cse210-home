using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        List<float> numbers = new List<float>();
        float number;

        do{
            Console.Write("Enter a series of numbers, one at a time. Pass zero when finished: ");
            number = float.Parse(Console.ReadLine());
            numbers.Add(number);

        }while(number != 0);
        Console.WriteLine("Here is the list of numbers");

        foreach (float num in numbers){
            Console.WriteLine(num);
        }

        float sum = 0;
        foreach(float num in numbers){
            sum += num;
        }
        Console.WriteLine($"The sum of the numbers entered is: {sum}");

        float average = sum / numbers.Count;
        Console.WriteLine($"The average of the numbers is: {average}");

        float max = 0;
        foreach (float num in numbers){
            if (num > max){
                max = num;
            }
        }
        Console.WriteLine($"The largest number of the numbers provided is: {max}");
    }
}