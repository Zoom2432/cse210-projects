public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    public GoalManager()
    {
        _goals = [];
        _score = 0;
    }

    public void Start()
    {
        Console.Write("Menu Options:\n1. Create New Goal\n2. List Goals\n3. Save Goals\n4. Load Goals\n5. Record Goals\n6. Quit\nSelect a choice from the menu: ");
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points.\n");
    }

    public void ListGoalNames()
    {
        Console.WriteLine("The goals are:");

        if (_goals.Count() == 0)
        {
            Console.WriteLine("false");
        }
        else
        {
            int count = 1;

            for (int i = 0; i < _goals.Count; i++)
            {
                if (_goals[i].IsComplete() == false)
                {
                    Console.WriteLine($"{count}. {_goals[i].GetShortName()}");
                    count++;
                }
            }
        }
    }

    public void ListGoalDetails()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i+1}. {_goals[i].GetDetailsString()}");
        }
    }

    public void CreateGoal()
    {
        int choice = 0;

        Console.Write("The types of Goals are:\n1. Simple Goal\n2. Eternal Goal\n3. Checklist Goal\nWhich type of goal would you like to create? ");
        while (choice > 4 || choice < 1)
        {
            choice = Int32.Parse(Console.ReadLine());
            if (choice > 4 & choice < 0)
            {
                Console.WriteLine("You entered incorrect information, please try again.");
            }
        }

        switch (choice)
        {
            case 1:
                Console.Write("What is the name of your goal? ");
                string name = Console.ReadLine();
                Console.Write("What is a short description of it? ");
                string desc = Console.ReadLine();
                Console.Write("What is the amount if points associated with this goal? ");
                int points = Int32.Parse(Console.ReadLine());

                SimpleGoal g = new SimpleGoal(name, desc, points);
                _goals.Add(g);

                break;
            case 2:
                Console.Write("What is the name of your goal? ");
                string name2 = Console.ReadLine();
                Console.Write("What is a short description of it? ");
                string desc2 = Console.ReadLine();
                Console.Write("What is the amount if points associated with this goal? ");
                int points2 = Int32.Parse(Console.ReadLine());

                EternalGoal g2 = new EternalGoal(name2, desc2, points2);
                _goals.Add(g2);

                break;
            case 3:
                Console.Write("What is the name of your goal? ");
                string name3 = Console.ReadLine();
                Console.Write("What is a short description of it? ");
                string desc3 = Console.ReadLine();
                Console.Write("What is the amount of points associated with this goal? ");
                int points3 = Int32.Parse(Console.ReadLine());
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                int target = Int32.Parse(Console.ReadLine());
                Console.Write("What is the bonus for accomplishing it that many times? ");
                int bonus = Int32.Parse(Console.ReadLine());

                ChecklistGoal g3 = new ChecklistGoal(name3, desc3, points3, target, bonus);
                _goals.Add(g3);

                break;
        }
    }

    public void RecordEvent()
    {
        ListGoalNames();
        Console.Write("What goal did you accomplish? ");
        int choice = Int32.Parse(Console.ReadLine());

        for (int i = 0; i < _goals.Count(); i++)
        {
            if (_goals[i].IsComplete() == false)
            {
                if (choice == 1)
                {
                    _goals[i].RecordEvent();
                    _score += _goals[i].GetPoints();
                    break;
                }
                else
                {
                    choice -= 1;
                }
            }
        }
        
    }

        public void SaveGoals()
    {
        Console.WriteLine("What is the filename?");
        string filename = $"{Console.ReadLine()}.txt";

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_score);

            foreach (Goal g in _goals)
            {
                outputFile.WriteLine(g.GetStringRepresentation());
            }
        }
    }

    public void LoadGoals()
    {
        Console.WriteLine("What is the filename?");
        string filename = $"{Console.ReadLine()}.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            if (parts[0] == "SimpleGoal")
            {
                SimpleGoal s = new SimpleGoal(parts[1], parts[2], Int32.Parse(parts[3]));

                if (Convert.ToBoolean(parts[4]))
                {
                    s.SetComplete(true);
                }

                _goals.Add(s);
            }
            else if (parts[0] == "EternalGoal")
            {
                EternalGoal s = new EternalGoal(parts[1], parts[2], Int32.Parse(parts[3]));
                _goals.Add(s);
            }
            else if (parts[0] == "ChecklistGoal")
            {
                ChecklistGoal s = new ChecklistGoal(parts[1], parts[2], Int32.Parse(parts[3]), Int32.Parse(parts[4]), Int32.Parse(parts[5]));

                s.SetAmountCompleted(Int32.Parse(parts[6]));

                _goals.Add(s);
            }
            else if (parts.Length == 1)
            {
                _score = Int32.Parse(parts[0]);
            }
        }
    }
}