using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("221346", "Toronto", "Ontario", "Canada");
        Address address2 = new Address("321532", "Washington", "Colombia", "USA");
        Address address3 = new Address("321532", "Seattle", "Washington", "USA");

        Lecture lecture = new Lecture("AI", "AI in programming", "24.07.2024", "9am", address1, "Antony Gordon", "Senior PHP developer");
        Reception reception = new Reception("Spring Ball", "Spring ball in honor of the Queen", "01.06.2024", "6pm", address2, "If you come, please respond positively to this message.");
        OutDoorGathering outDoorGathering = new OutDoorGathering("Book Club", "Harry Potter discussion", "20.05.2024", "3pm", address3, "Cloudy, 5 degrees Celsius");

        Console.WriteLine("First event:");
        Console.WriteLine(lecture.ShortInf());
        Console.WriteLine("\n");
        Console.WriteLine(lecture.StandartInf());
        Console.WriteLine("\n");
        Console.WriteLine(lecture.FullInf());
        Console.WriteLine("\n");
        Console.WriteLine("\n");
        Console.WriteLine("Second event:");
        Console.WriteLine(reception.ShortInf());
        Console.WriteLine("\n");
        Console.WriteLine(reception.StandartInf());
        Console.WriteLine("\n");
        Console.WriteLine(reception.FullInf());
        Console.WriteLine("\n");
        Console.WriteLine("\n");
        Console.WriteLine("Third event:");
        Console.WriteLine(outDoorGathering.ShortInf());
        Console.WriteLine("\n");
        Console.WriteLine(outDoorGathering.StandartInf());
        Console.WriteLine("\n");
        Console.WriteLine(outDoorGathering.FullInf());
    }
}