using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the number of points you have earned: ");
        string input = Console.ReadLine();
        int number = int.Parse(input);

        string letter = "";

        if (number >= 90)
        {
            letter = "A";
        }
        else if (number >= 80)
        {
            letter = "B";
        }
        else if (number >= 70)
        {
            letter = "C";
        }
        else if (number >= 60)
        {
            letter = "D";
        }
        else if (number < 60)
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is {letter}.");

        if (number >= 70)
        {
            Console.WriteLine("Congratulations, you have passed the exam!");
        }
        else
        {
            Console.WriteLine("Unfortunately, you did not pass the exam. You can try again in a week.");
        }
    }
}