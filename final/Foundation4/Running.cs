public class Running : Activity
{
    private float _distance;
    public Running(int time, string date, float distance) : base (time, date)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }
    public override double GetSpeed()
    {
        return GetDistance() / _time * 60;
    }
    public override double GetPace()
    {
        return _time / GetDistance();
    }
    public override string GetSummary()
    {
        return $"{_date} Running ({_time} min) - Distance {GetDistance()} miles, Speed {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }
}