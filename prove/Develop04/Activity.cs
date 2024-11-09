using System.Diagnostics.Metrics;

public class Activity
{
    private string _type;
    private string _description;
    private int _duration;
    private int _counterDuration;
    private int _spinnerDuration;

    public Activity(string type, string description, int duration, int counterDuration, int spinnerDuration)
    {
        _type = type;
        _description = description;
        _counterDuration = counterDuration;
        _spinnerDuration = spinnerDuration;
    }

    public void SetCounterDuration(int duration)
    {
        _counterDuration = duration;
    }

    public void SetSpinnerDuration(int duration)
    {
        _spinnerDuration = duration;
    }

    public void SetDuration(int duration)
    {
        _duration = duration;
    }

    public void Spinner()
    {
        for (int i = _spinnerDuration; i > 0; i--)
        {
            if(i % 4 == 0)
            {
                Console.Write("\\");
            }
            else if (i % 3 == 0)
            {
                Console.Write("|");
            }
            else if (i % 2 == 0)
            {
                Console.Write("/");
            }
            else
            {
                Console.Write("-");
            }
            Thread.Sleep(1000);
            Console.Write("\b");
        }
        Console.Write("\b");
    }

    public void Countdown()
    {
        for (int i = _counterDuration; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b");
        }
        Console.Write("\b\b");
        Console.WriteLine();
    }

    public void StartingMessage()
    {
        Console.WriteLine($"Welcome to the {_type} Activity");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
    }

    public void EndingMessage()
    {
        Console.WriteLine("Well done!!");
        Console.WriteLine();
        Console.WriteLine($"You have completed {_duration} second of the {_type} Activity.");
    }
}