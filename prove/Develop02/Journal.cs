using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry()
    {
        Prompt prompts = new Prompt();
        prompts._prompts.Add("What was the most enjoyable part of your day, and why did it stand out to you?");
        prompts._prompts.Add("Did you face any challenges today, and how did you handle them?");
        prompts._prompts.Add("What is something you learned or discovered today, no matter how small?");
        prompts._prompts.Add("How did you take care of yourself today, either physically or mentally?");
        prompts._prompts.Add("Was there a moment today that made you feel proud or accomplished?");
        prompts._prompts.Add("What was your mood like throughout the day, and did anything significantly affect it?");
        prompts._prompts.Add("Did you connect with someone today in a meaingful way and how did that interaction make you feel?");
        
        Entry entry = new Entry();
        DateTime theCurrentTime = DateTime.Now;
        entry._date = theCurrentTime.ToShortDateString();
        entry._prompt = prompts.GetRandomPrompt();
        Console.WriteLine(entry._prompt);
        Console.Write(">");
        entry._response = Console.ReadLine();
        _entries.Add(entry);
    }
    
    public void Display()
    {
        foreach(Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void WriteToFile()
    {
        Console.Write("What is the filename? ");
        string filename = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach(Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date},{entry._prompt},{entry._response}");
            }
        }
    }

    public void ReadFromFile()
    {
        Console.Write("What is the filename? ");
        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);
        _entries.Clear();

        foreach(string line in lines)
        {
            string[] parts = line.Split(",");
            Entry entry = new Entry();
            entry._date = parts[0];
            entry._prompt = parts[1];
            entry._response = parts[2];
            _entries.Add(entry);
        }
    }
}