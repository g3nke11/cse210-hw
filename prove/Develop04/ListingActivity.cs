public class ListingActivity : Activity
{
    private List<string> _prompts = ["Who are people that you appreciate?"
    , "What are personal strengths of yours?"
    , "Who are people that you have helped this week?"
    , "When have you felt the Holy Ghost this month?"
    , "Who are some of your personal heroes?"];

    public ListingActivity() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area", 10, 10, 10)
    {}

    public void Listing()
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
        Console.WriteLine("Consider the following prompt");
        Random ran = new Random();
        int prom = ran.Next(0, _prompts.Count);
        Console.WriteLine(_prompts[prom]);
        Console.Write("When you have somthing in mind, press enter to continue. ");
        Console.ReadLine();
        Console.Clear();
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(duration);
        while (DateTime.Now < futureTime)
        {
            Console.Write("> ");
            Console.ReadLine();
        }
        EndingMessage();
        Spinner();
        Console.Clear();
    }
}