using System.Diagnostics;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}.\n\n{_description}\n");
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = Convert.ToInt32(Console.ReadLine());
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine($"\nWell done!");
        ShowSpinner(2);
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.");
        ShowSpinner(2);
    }

    public void ShowSpinner(int seconds)
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(seconds);

        while (startTime < futureTime)
        {
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("|");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(500);
            
            startTime = DateTime.Now;
        }
        Console.Write("\b \b");
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(seconds - i);
            Thread.Sleep(1000);
            if ((seconds - i) < 10)
            {
                Console.Write("\b \b");
            }
            else if ((seconds - i) < 99)
            {
                Console.Write("\b\b  \b\b");
            }
            else if ((seconds - i) < 999)
            {
                Console.Write("\b\b\b   \b\b\b");
            }
        }
    }
}