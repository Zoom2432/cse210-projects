public class SimpleGoal : Goal
{
    private bool _isComplete = false;

    public SimpleGoal(string name, string description, int points) : base(name, description, points){}

    public void SetComplete(bool ch)
    {
        _isComplete = ch;
    }

    public override void RecordEvent()
    {
        Console.WriteLine($"Congratulations! You have earnd {_points} points!");
        _isComplete = true;
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal|{_shortName}|{_description}|{_points}|{_isComplete}";
    }
}