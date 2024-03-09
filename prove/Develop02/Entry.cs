using System.ComponentModel.DataAnnotations;
using System.Xml;
public class Entry
{
    public string _date = DateTime.Now.ToShortDateString();
    public string _prompt = new PromptGenerator().GeneratePrompt();
    public string _text;

    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_prompt}");
        Console.WriteLine($"{_text}\n");
    }
}