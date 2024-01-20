using System.Security.Cryptography;

public class Prompt{
    public List<string> _prompts = new List<string>();

    public Prompt(){

    }

    public string GetRandomPrompt(){
        Random random = new Random();
        int promtPosition = random.Next(0, _prompts.Count);
        return _prompts[promtPosition];
    }
}