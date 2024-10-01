public class Job
{
    // public variables
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;

    // Display information in needed format
    public void Display() {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}