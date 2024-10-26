public class Scripture
{
    private Reference _reference;
    private List<Word> _verse = new List<Word>();

    public Scripture(String reference, String verse)
    {
        string[] parts = reference.Split(" ");
        int firstInt = int.Parse(parts[1]);
        int secondInt = int.Parse(parts[2]);
        if (parts.Length > 3)
        {
            int thirdInt = int.Parse(parts[3]);
            _reference = new Reference(parts[0], firstInt, secondInt, thirdInt);
        }
        else
        {
            _reference = new Reference(parts[0], firstInt, secondInt);
        }

        string[] words = verse.Split(' ');
        foreach(string word in words)
        {
            _verse.Add(new Word(word));
        }
    }

    public void Memorize()
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
            if (IsCompletelyHidden())
            {
                break;
            }
            HideWords();
            Console.Write("Press enter to continue, type 'quit' to finish or 'restart' to show verse. ->");
            String answer = Console.ReadLine();
            if (answer == "quit")
            {
                break;
            }
            if (answer == "restart")
            {
                ShowWords();
            }
        }
    }

    public void ShowWords()
    {
        foreach(Word word in _verse)
        {
            word.Show();
        }
    }

    public void HideWords()
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
            if (IsCompletelyHidden())
            {
                break;
            }
        }
    }

    public bool IsCompletelyHidden()
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