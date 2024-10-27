public class Scripture_Memorizer
{
    private Dictionary<Reference, List<Word>> _scriptures = new Dictionary<Reference, List<Word>>();

    public Scripture_Memorizer(String reference, String verse)
    {
        string[] parts = reference.Split(" ");
        int firstInt = int.Parse(parts[1]);
        int secondInt = int.Parse(parts[2]);
        Reference reference1;
        if (parts.Length > 3)
        {
            int thirdInt = int.Parse(parts[3]);
            reference1 = new Reference(parts[0], firstInt, secondInt, thirdInt);
        }
        else
        {
            reference1 = new Reference(parts[0], firstInt, secondInt);
        }

        string[] words = verse.Split(' ');
        List<Word> verse1 = new List<Word>();
        foreach(string word in words)
        {
            verse1.Add(new Word(word));
        }

        _scriptures.Add(reference1, verse1);
    }

    public Scripture_Memorizer(Dictionary<Reference, List<Word>> scriptures)
    {
        _scriptures = scriptures;
    }

    public void AddScripture(String reference, String verse)
    {
        string[] parts = reference.Split(" ");
        int firstInt = int.Parse(parts[1]);
        int secondInt = int.Parse(parts[2]);
        Reference reference1;
        if (parts.Length > 3)
        {
            int thirdInt = int.Parse(parts[3]);
            reference1 = new Reference(parts[0], firstInt, secondInt, thirdInt);
        }
        else
        {
            reference1 = new Reference(parts[0], firstInt, secondInt);
        }

        string[] words = verse.Split(' ');
        List<Word> verse1 = new List<Word>();
        foreach(string word in words)
        {
            verse1.Add(new Word(word));
        }

        _scriptures.Add(reference1, verse1);
    }

    public void MemorizeRandom()
    {
        List<Reference> references = new List<Reference>(_scriptures.Keys);
        Random randomNum = new Random();
        int num = randomNum.Next(0, references.Count);
        List<Word> verse = _scriptures[references[num]];
        Memorize(references[num], verse);
    }

    private void Memorize(Reference _reference, List<Word> _verse)
    {
        while (true)
        {
            Console.Clear();
            Console.Write(_reference.GetReference() + " ");
            foreach(Word word in _verse)
            {
                if(!word.IsHidden())
                {
                    Console.Write(word.Display() + " ");
                }
                else
                {
                    Console.Write("___" + " ");
                }
            }
            if (IsCompletelyHidden(_verse))
            {
                break;
            }
            HideWords(_verse);
            Console.WriteLine();
            Console.Write("Press enter to continue, type 'quit' to finish or 'restart' to show verse. ->");
            String answer = Console.ReadLine();
            if (answer == "quit")
            {
                break;
            }
            if (answer == "restart")
            {
                ShowWords(_verse);
            }
        }
    }

    private void ShowWords(List<Word> _verse)
    {
        foreach(Word word in _verse)
        {
            word.Show();
        }
    }

    private void HideWords(List<Word> _verse)
    {
        Random random = new Random();
        int counter = 0;

        while (counter != 3)
        {
            int randomNumber = random.Next(0,_verse.Count);
            if (!_verse[randomNumber].IsHidden())
            {
                _verse[randomNumber].Hide();
                counter += 1;
            }
            if (IsCompletelyHidden(_verse))
            {
                break;
            }
        }
    }

    private bool IsCompletelyHidden(List<Word> _verse)
    {
        foreach(Word word in _verse)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }

        return true;
    }

}