public class Prompt
{
    public List<string> _prompts = new List<string>();

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int randomNumber = random.Next(0,_prompts.Count);
        return _prompts[randomNumber];
    }
}