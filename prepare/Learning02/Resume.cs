public class Resume
{
    // public variables
    public string _name;
    public List<Job> _jobs = new List<Job>();

    // Display information in needed format
    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");
        foreach(Job job in _jobs)
        {
            job.Display();
        }
    }
}