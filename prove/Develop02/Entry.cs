public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;
    public string _mood; // Mejora creativa: Guardar el ánimo

    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_promptText}");
        Console.WriteLine($"(Mood: {_mood})"); // Mostramos el ánimo
        Console.WriteLine($"> {_entryText}");
        Console.WriteLine("---------------------------------------------");
    }
}