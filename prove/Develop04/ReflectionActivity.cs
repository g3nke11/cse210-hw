public class ReflectionActivity: Activity
{
    private List<string> _prompts = ["Think of a time when you stood up for someone else."
    , "Think of a time when you did something really difficult."
    , "Think of a time when you helped someone in need."
    , "Think of a time when you did something truly selfless."];
    private List<string> _questions = ["Why was this experience meaningful to you?"
    , "How did you feel when it was complete?"
    , "What is your favorite thing about this experience?"
    , "How did you get started?"
    , "What made this time different from other times when you did not feel successful?"
    , "What did you learn about yourself from this experience?"
    , "What did you learn about others from this experience?"
    , "How can you keep this experience in mind in the future?"];

    public ReflectionActivity() : base("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", 10, 10, 10)
    {}

    public void Reflect()
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
        Console.WriteLine("Consider the following prompt");
        Random ran = new Random();
        int prom = ran.Next(0, _prompts.Count);
        Console.WriteLine(_prompts[prom]);
        Console.Write("When you have somthing in mind, press enter to continue. ");
        Console.ReadLine();
        Console.Clear();
        SetSpinnerDuration(10);
        DateTime start = DateTime.Now;
        DateTime future = start.AddSeconds(duration);
        while (DateTime.Now < future)
        {
            Random ranI = new Random();
            int promI = ranI.Next(0, _prompts.Count);
            Console.Write($">{_questions[promI]}");
            Spinner();
            Console.WriteLine();
        }
        EndingMessage();
        Spinner();
        Console.Clear();
    }
}