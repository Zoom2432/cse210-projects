using System.Runtime;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
    }

        public override void RecordEvent()
    {
        if (_amountCompleted < _target-1)
        {
            Console.WriteLine($"Congratulations! You have earnd {_points} points!");
            _amountCompleted += 1;
        }
        else
        {
            Console.WriteLine($"Congratulations! You have earnd {_points+_bonus} points!");
            _amountCompleted += 1;
        }
    }

    public override bool IsComplete()
    {
        if (_amountCompleted < _target)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    public override string GetDetailsString()
    {
        if (_amountCompleted < _target)
        {
            return $"[ ] {_shortName} {_description} -- Currently completed: {_amountCompleted}/{_target}";
        }
        else
        {
            return $"[X] {_shortName} {_description} -- Currently completed: {_amountCompleted}/{_target}";
        }
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal|{_shortName}|{_description}|{_points}|{_amountCompleted}|{_target}|{_bonus}";
    }
}