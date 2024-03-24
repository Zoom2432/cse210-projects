public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "Breathing activity";
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public void Run()
    {
        Console.Clear();
        DisplayStartingMessage();
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(5);
        Console.WriteLine();

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);

        while (startTime < futureTime)
        {
            Console.WriteLine();
            Console.Write($"Breathe in...");
            ShowCountDown(4);
            Console.WriteLine();
            Console.Write($"Breathe out...");
            ShowCountDown(6);
            Console.WriteLine();

            startTime = DateTime.Now;
        }

        DisplayEndingMessage();
    }
}