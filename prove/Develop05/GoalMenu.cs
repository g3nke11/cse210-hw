using System.IO;
using Microsoft.VisualBasic;

public class GoalMenu
{
    private List<Goal> _goals = new List<Goal>();
    private int _points;
    private int _level;
    private string _user;

    public GoalMenu()
    {}

    public GoalMenu(List<Goal> goals, int points, int level, string user)
    {
        _goals = goals;
        _points = points;
        _level = level;
        _user = user;
    }

    public void Menu()
    {
        Console.Write("Please enter your name: ");
        _user = Console.ReadLine();
        _level = 1;
        while (true)
        {
            Console.Clear();
            int newLevel = _points / 100;
            if(newLevel > _level)
            {
                _level = newLevel;
            }
            Console.WriteLine($"Hello {_user}");
            Console.WriteLine($"You are level: {_level}");
            Console.WriteLine($"You have {_points} points.");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("\t 1. Create New Goal");
            Console.WriteLine("\t 2. List Goals");
            Console.WriteLine("\t 3. Save Goals");
            Console.WriteLine("\t 4. Load Goals");
            Console.WriteLine("\t 5. Record Event");
            Console.WriteLine("\t 6. Reset Goals");
            Console.WriteLine("\t 7. Fresh Restart");
            Console.WriteLine("\t 8. Quit");
            Console.Write("Select a choice from the menu: ");
            int select = int.Parse(Console.ReadLine());
            Console.WriteLine();
            switch (select)
            {
                case 1:
                    Console.WriteLine("The types of Goals are:");
                    Console.WriteLine("\t 1. Simple Goal");
                    Console.WriteLine("\t 2. Eternal Goal");
                    Console.WriteLine("\t 3. Checklist Goal");
                    Console.Write("Which type of goal would you like to create: ");
                    int type =  int.Parse(Console.ReadLine());
                    AddGoal(type);
                    break;
                case 2:
                    DisplayCurrent();
                    break;
                case 3:
                    Console.Write("What is the filename for the goal file? ");
                    string filenameS = Console.ReadLine();
                    SaveGoals(filenameS);
                    break;
                case 4:
                    Console.Write("What is the filename for the goal file? ");
                    string filenameL = Console.ReadLine();
                    LoadGoals(filenameL);
                    break;
                case 5:
                    CompleteGoal();
                    break;
                case 6:
                    ResetGoals();
                    break;
                case 7:
                    _points = 0;
                    _level = 1;
                    _goals.Clear();
                    break;
                case 8:
                    Console.WriteLine("Ending game ...");
                    return;
            }
        }
    }

    private void AddGoal(int type)
    {
        if(type == 1)
        {
            Console.Write("What is the name of your goal? ");
            string title = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal? ");
            int points = int.Parse(Console.ReadLine());
            _goals.Add(new SimpleGoal(title, description, points));
        }
        else if(type == 2)
        {
            Console.Write("What is the name of your goal? ");
            string title = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal? ");
            int points = int.Parse(Console.ReadLine());
            _goals.Add(new EternalGoal(title, description, points));
        }
        else if(type == 3)
        {
            Console.Write("What is the name of your goal? ");
            string title = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal? ");
            int points = int.Parse(Console.ReadLine());
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int targetGoal = int.Parse(Console.ReadLine());Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonusPoints = int.Parse(Console.ReadLine());
            _goals.Add(new ChecklistGoal( title, description, points, targetGoal, bonusPoints));
        }
    }

    private void SaveGoals(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine($"{_points}|{_level}|{_user}");
            foreach(Goal goal in _goals)
            {
                outputFile.WriteLine(goal.RecordEvent());
            }
        }
    }

    private void LoadGoals(string filename)
    {
        string[] lines = System.IO.File.ReadAllLines(filename);

        string[] info = lines[0].Split("|");
        _points = int.Parse(info[0]);
        _level = int.Parse(info[1]);
        _user = info[2];
        _goals.Clear();
        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split("|");
            if (parts[0] == "ChecklistGoal")
            {
                _goals.Add(new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]), int.Parse(parts[6])));
            }
            else if (parts[0] == "SimpleGoal")
            {
                _goals.Add(new SimpleGoal(parts[1], parts[2], int.Parse(parts[3])));
            }
            else if (parts[0] == "EternalGoal")
            {
                _goals.Add(new EternalGoal(parts[1], parts[2], int.Parse(parts[3])));
            }
        }
    }

    private void DisplayCurrent()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].Describe()}");
        }
    }

    private void CompleteGoal()
    {
        Console.Write("Which goal did you accomplist? ");
        int num = int.Parse(Console.ReadLine());
        int goalNum = num - 1;
        if(goalNum >= 0 && goalNum < _goals.Count)
        {
            _points += _goals[goalNum].Reward();
        }
        else
        {
            Console.WriteLine("OutofBounds");
        }
    }

    private void ResetGoals()
    {
        foreach (Goal goal in _goals)
        {
            goal.Reset();
        }
    }
}