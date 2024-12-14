public class OutdoorGathering : Event
{
    private string _weather;

    public OutdoorGathering(string title, string description, string date, string time, Address address, string weather) : base (title, description, date, time, address)
    {
        _weather = weather;
    }
    public string FullDetails()
    {
        return $"Outdoor Gathering\n{StandardDetail()}Expected Weather: {_weather}\n";
    }

    public string ShortDescription()
    {
        return $"Outdoor Gathering\n{_title}\n{_description}\n{_date}\n";
    }
}