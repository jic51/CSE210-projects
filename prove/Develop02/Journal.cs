using System.IO; 

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry e in _entries)
        {
            e.Display(); // Usamos la abstracción de Entry
        }
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file)) // Uso de StreamWriter
        {
            foreach (Entry e in _entries)
            {
                // Usamos un separador como "|" para facilitar la lectura después
                outputFile.WriteLine($"{e._date}|{e._promptText}|{e._entryText}");
            }
        }
    }

    public void LoadFromFile(string file)
    {
        _entries.Clear(); // Limpiamos las entradas actuales antes de cargar
        string[] lines = System.IO.File.ReadAllLines(file);

        foreach (string line in lines)
        {
            string[] parts = line.Split("|"); // Dividimos la línea por el separador

            Entry newEntry = new Entry();
            newEntry._date = parts[0];
            newEntry._promptText = parts[1];
            newEntry._entryText = parts[2];

            _entries.Add(newEntry);
        }
    }
}