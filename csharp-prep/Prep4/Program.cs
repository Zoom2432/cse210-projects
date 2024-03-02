using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int sum = 0;
        float avr = 0;
        int lrg = 0;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        Console.Write("Enter number: ");
        string input = Console.ReadLine();
        int num = int.Parse(input);

        while (num != 0)
        {
            numbers.Add(num);

            Console.Write("Enter number: ");
            input = Console.ReadLine();
            num = int.Parse(input);
        }

        foreach (int n in numbers)
        {
            sum += n;

            if (n > lrg)
            {
                lrg = n;
            }
        }

        avr = sum / numbers.Count;

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {avr}");
        Console.WriteLine($"The largest number is: {lrg}");
    }
}