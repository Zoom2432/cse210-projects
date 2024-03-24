public class MathAssigment : Assigment
{
    private string _textbookSection;
    private string _problems;

    public MathAssigment(string name, string topic, string textbookSection, string problems) : base(name, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        return $"Section: {_textbookSection}, Problems: {_problems}";
    }
}