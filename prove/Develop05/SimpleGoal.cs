public class SimpleGoal: Goal
{
    public SimpleGoal(string title, string description, int points): base(title, description, points)
    {}

    public override int Reward()
    {
        _isComplete = true;
        return _points;
    }

    public override string Describe()
    {
        if (!_isComplete)
        {
            return $"[ ] {_title} ({_description})";
        }
        else
        {
            return $"[X] {_title} ({_description})";
        }
    }

    public override string RecordEvent()
    {
        return $"SimpleGoal|{_title}|{_description}|{_points}";
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