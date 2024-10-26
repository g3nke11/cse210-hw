public class Word
{
    private string _word;
    private bool _statusHide;

    public Word(String word)
    {
        _word = word;
        _statusHide = false;
    }

    public string Display()
    {
        return _word;
    }

    public void Hide()
    {
        _statusHide = true;
    }

    public void Show()
    {
        _statusHide = false;
    }

    public bool IsHidden()
    {
        return _statusHide;
    }
}