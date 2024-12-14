public class Reception : Event
{
    private bool _rsvp = false;

    public Reception(string title, string description, string date, string time, Address address) : base (title, description, date, time, address)
    {
    }

    public string FullDetails()
    {
        return $"Reception\n{StandardDetail()}Please RSVP\n";
    }

    public string ShortDescription()
    {
        return $"Reception\n{_title}\n{_description}\n{_date}\n";
    }

    public void RSVP()
    {
        _rsvp = true;
    }

    public bool Attendance()
    {
        return _rsvp;
    }
}