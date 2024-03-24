public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity()
    {
        _name = "Reflection Activity";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        _prompts = ["Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless."];
        _questions = ["Why was this experience meaningful to you?", "Have you ever done anything like this before?",
        "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?"];    
    }

    public void Run()
    {
        Console.Clear();
        DisplayStartingMessage();
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(5);
        Console.WriteLine();

        Console.WriteLine("Consider the following prompt:\n");
        DisplayPrompt();
        Console.WriteLine("\nWhen you have something in mind, press enter to continue.");
        Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        ShowCountDown(5);

        Console.Clear();
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);

        while (startTime < futureTime)
        {
            Console.Write($"> ");
            DisplayQuestion();
            Console.Write("  ");
            ShowSpinner(15);
            Console.WriteLine();

            startTime = DateTime.Now;
        }

        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        Random rnd = new Random();
        int rnd_num = rnd.Next(0, _prompts.Count);
        string prompt = _prompts[rnd_num];
        return prompt;
    }

    public void DisplayPrompt()
    {
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
    }

    public string GetRandomQuestion()
    {
        if (_questions.Count > 0)
        {
            Random rnd = new Random();
            int rnd_num = rnd.Next(0, _questions.Count);
            string question = _questions[rnd_num];
            _questions.Remove(_questions[rnd_num]);
            return question;
        }
        else
        {
            return "There are no more questions.";
        }
    }

    public void DisplayQuestion()
    {
        Console.Write(GetRandomQuestion());
    }
}