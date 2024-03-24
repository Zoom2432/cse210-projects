public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity()
    {
        _name = "Listing activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _prompts = ["Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?"];
    }

    public void Run()
    {
        Console.Clear();
        DisplayStartingMessage();
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(5);
        Console.WriteLine();

        Console.WriteLine("List as many responses you can to the following prompt:");
        GetRandomPrompt();
        Console.Write("You can begin in: ");
        ShowCountDown(10);
        Console.WriteLine();

        GetListFromUser();

        DisplayEndingMessage();
    }

    public void GetRandomPrompt()
    {
        Random rnd = new Random();
        int rnd_num = rnd.Next(0, _prompts.Count);
        Console.WriteLine($"--- {_prompts[rnd_num]} ---");
    }

    public void GetListFromUser()
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);

        while (startTime < futureTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            _count++;
            startTime = DateTime.Now;
        }
        Console.WriteLine($"You listed {_count} items!");
    }
}