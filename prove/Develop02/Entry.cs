public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;
    public string _mood; //Save tje user's mood

    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_promptText}");
        Console.WriteLine($"(Mood: {_mood})"); // Display the mood
        Console.WriteLine($"> {_entryText}");
        Console.WriteLine("---------------------------------------------");
    }
}