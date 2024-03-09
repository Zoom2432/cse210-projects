public class PromptGenerator
{
    Random rnd = new Random();
    public List<string> _prompts = new List<string>();
    
    public PromptGenerator()
    {
        _prompts = ["Who was the most interesting person I interacted with today?", "What was the best part of my day?", "How did I see the hand of the Lord in my life today?", "What was the strongest emotion I felt today?", "If I had one thing I could do over today, what would it be?", "What's the most beautiful thing I saw this day?", "What inspired me today?", "What useful things did I do in a day for personal growth?"];
    }

    public string GeneratePrompt()
    {
        return _prompts[rnd.Next(0, _prompts.Count)];
    }
}