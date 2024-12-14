public class Cycling : Activity
{
    private float _speed;

    public Cycling(int time, string date, float speed) : base (time, date)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return GetSpeed() / 60 * _time;
    }
    public override double GetSpeed()
    {
        return _speed;
    }
    public override double GetPace()
    {
        return _time / GetDistance();
    }
    public override string GetSummary()
    {
        return $"{_date} Cycling ({_time} min) - Distance {GetDistance():F1} miles, Speed {GetSpeed():F1} mph, Pace: {GetPace():F1} min per mile";
    }
}