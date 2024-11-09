public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.", 10, 10, 10)
    {}

    public void Breath()
    {
        Console.Clear();
        StartingMessage();
        Console.Write("How long, in seconds, would you like for your session? ");
        int duration = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Getting Ready");
        SetSpinnerDuration(5);
        Spinner();
        SetDuration(duration);
        SetCounterDuration(3);
        DateTime start = DateTime.Now;
        DateTime future = start.AddSeconds(duration);
        while (DateTime.Now < future)
        {
            Console.Write("Breath in ...");
            Countdown();
            Console.Write("Breath out ...");
            Countdown();
            Console.WriteLine("");
        }
        EndingMessage();
        Spinner();
        Console.Clear();
    }
}