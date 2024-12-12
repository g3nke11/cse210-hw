public class Swimming : Activity
{
    private double _laps;

    public Swimming(int time, string date, float laps) : base (time, date)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * 50 / 1000 * 0.62;
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
        return $"{_date} Swimming ({_time} min) - Distance {GetDistance()} miles, Speed {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }
}