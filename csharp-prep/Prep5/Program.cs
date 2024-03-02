using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }

        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            
            return name;
        }

        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            string input = Console.ReadLine();
            int num = int.Parse(input);
            
            return num;
        }

        static int SquareNumber(int num)
        {
            return num*num;
        }

        static void DisplayResult(string name, int num)
        {
            Console.WriteLine($"{name}, the square of your number is {num}");
        }

        static void mainFunc()
        {
            DisplayWelcome();
            string name = PromptUserName();
            int num = PromptUserNumber();
            int num2 = SquareNumber(num);
            DisplayResult(name, num2);
        }

        mainFunc();
    }
}