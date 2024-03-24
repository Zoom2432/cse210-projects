using System;

class Program
{
    static void Main(string[] args)
    {
        WriteAssigment ass1 = new WriteAssigment("Mary Waters", "European History", "The Causes of World War II");

        Console.WriteLine(ass1.GetSummary());
        Console.WriteLine(ass1.GetWritingInformation());
    }
}