using System;

class Program
{
    static void Main(string[] args)
    {
        Running running = new Running("03 Feb 2024", 50, 5.5);
        Bicycle bicycle = new Bicycle("14 Feb 2024", 30, 10.7);
        Swimming swimming = new Swimming("24 Feb 2024", 60, 20);

        List<Activity> activities = new List<Activity>();
        activities.Add(running);
        activities.Add(bicycle);
        activities.Add(swimming);

        Console.Clear();

        foreach(Activity act in activities)
        {
            Console.WriteLine(act.GetSummary());
        }
    }
}