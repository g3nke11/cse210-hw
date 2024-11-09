public class MindfulnessActivity : Activity
{
    private List<string> _questions = ["What am I noticing around me right now?"
    , "How does my body feel in this moment"
    , "What emotions or thoughts am I experiencing right now?"
    , "What am I grateful for in this moment?"
    , "What positive things can I think about myself at this moment?"];
    public MindfulnessActivity() : base("Mindfulness", "This activity will help you become more aware of yourself and your surroundings.", 10, 10, 10)
    {}

    public void Mind()
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
        Random ran = new Random();
        int num = ran.Next(0, _questions.Count);
        Console.Write(_questions[num]);
        SetSpinnerDuration(duration);
        Spinner();
        Console.WriteLine();
        EndingMessage();
        Spinner();
        Console.Clear();
    }
}