using System;

class Program
{
    static void Main(string[] args)
    {
        Reference refer = new Reference("Nephi", 2, 4);
        
        Scripture sc = new Scripture(refer, "And now, I, speak concerning the prophecies of which my father hath spoken, concerning Joseph, who was carried into Egypt.");

        Console.WriteLine(sc.GetDisplayText());

        Console.WriteLine("\nPress enter to continue or type 'quit' to finish:");
        string output = Console.ReadLine();

        while (sc.IsCompletelyHidden() != true && output != "quit")
        {
            Console.WriteLine(sc.IsCompletelyHidden());
            sc.HideRandomWords(3);
            Console.WriteLine(sc.GetDisplayText());
            Console.WriteLine("\nPress enter to continue or type 'quit' to finish:");
            output = Console.ReadLine();
        }
    }
}