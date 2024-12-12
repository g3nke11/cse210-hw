public class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    public Lecture(string title, string description, string date, string time, Address address, string speaker, int capacity) : base (title, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public string FullDetails()
    {
        return $"Lecture\nSpeaker: {_speaker}\n{StandardDetail()}\nCapacity: {_capacity}";
    }

    public string ShortDescription()
    {
        return $"Lecture\n{_title}\n{_description}\n{_date}";
    }
}