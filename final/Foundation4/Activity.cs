public abstract class Activity
{
    protected int _time;
    protected string _date;

    public Activity(int time, string date)
    {
        _time = time;
        _date = date;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();
    public abstract string GetSummary();
}