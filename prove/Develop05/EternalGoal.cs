public class EternalGoal : Goal 
{
    public EternalGoal(string title, string description, int points): base(title, description, points)
    {}

    public override int Reward()
    {
        _isComplete = false;
        return _points;
    }

    public override string Describe()
    {
       return $"[ ] {_title} ({_description})";
    }

    public override string RecordEvent()
    {
        return $"EternalGoal|{_title}|{_description}|{_points}";
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override void Reset()
    {
        _isComplete = false;
    }
}