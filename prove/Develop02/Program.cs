using System;

class Program
{
    static void Main(string[] args)
    {
        string menu = "Please select one of the following choices:\n1. Write\n2. Display\n3. Load\n4. Save\n5. Quit\nWhat would you like to do? ";
        
        Console.Write(menu);
        string answer = Console.ReadLine();

        Journal jour = new Journal();

        while (answer != "5")
        {
            switch (answer)
            {
                case "1":
                    jour.CreateEntry();
                    break;
                case "2":
                    jour.DisplayAll();
                    break;
                case "3":
                    jour.Load();
                    break;
                case "4":
                    jour.Save();
                    break;
                default:
                    Console.Write($"It looks like you entered a number that is not from the list provided, try again.\n{menu}");
                    answer = Console.ReadLine();
                    break;
            }
            Console.Write(menu);
            answer = Console.ReadLine();
        }
    }
}