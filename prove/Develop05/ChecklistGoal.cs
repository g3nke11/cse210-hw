public class ChecklistGoal: Goal
{
    private int _targetGoal;
    private int _timesCompleted;
    private int _bonusPoints;

    public ChecklistGoal(string title, string description, int points, int targetGoal, int bonusPoints): base(title, description, points)
    {
        _targetGoal = targetGoal;
        _timesCompleted = 0;
        _bonusPoints = bonusPoints;
    }

    public ChecklistGoal(string title, string description, int points, int targetGoal, int bonusPoints, int timesCompleted): base(title, description, points)
    {
        _targetGoal = targetGoal;
        _timesCompleted = timesCompleted;
        _bonusPoints = bonusPoints;
    }

    public override int Reward()
    {
        _timesCompleted += 1;
        int points = 0;
        if (_timesCompleted == _targetGoal)
        {
            _isComplete = true;
            points = _points + _bonusPoints;
        }
        else
        {
            points = _points;
        }
        return points;
    }

    public override string Describe()
    {
        if (!_isComplete)
        {
            return $"[ ] {_title} ({_description}) -- Currently completed: {_timesCompleted}/{_targetGoal}";
        }
        else
        {
            return $"[X] {_title} ({_description}) -- Currently completed: {_timesCompleted}/{_targetGoal}";
        }
    }

    public override string RecordEvent()
    {
        return $"ChecklistGoal|{_title}|{_description}|{_points}|{_targetGoal}|{_bonusPoints}|{_timesCompleted}";
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override void Reset()
    {
        _isComplete = false;
    }
}