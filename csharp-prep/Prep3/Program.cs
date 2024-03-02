using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int num = randomGenerator.Next(1, 100);

        Console.Write("What is your guess? ");
        string input_guess = Console.ReadLine();
        int guess = int.Parse(input_guess);

        while (guess != num)
        {
            if (guess < num)
            {
                Console.WriteLine("Lower");
            }
            else 
            {
                Console.WriteLine("Higher");
            }

            Console.Write("What is your guess? ");
            input_guess = Console.ReadLine();
            guess = int.Parse(input_guess);
        }

        Console.WriteLine("You guessed it!");
    }
}