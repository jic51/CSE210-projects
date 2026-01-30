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
            e.Display(); // we use the abstaction of Entry
        }
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file)) // StreamWriter for writing the file
        {
            foreach (Entry e in _entries)
            {
                // we use a "|" for better saving/loading
                outputFile.WriteLine($"{e._date}|{e._promptText}|{e._entryText}|{e._mood}");
            }
        }
    }

    public void LoadFromFile(string file)
    {
        _entries.Clear(); 
        string[] lines = System.IO.File.ReadAllLines(file);

        foreach (string line in lines)
        {
            string[] parts = line.Split("|"); // we use the "|" to split

            Entry newEntry = new Entry();
            newEntry._date = parts[0];
            newEntry._promptText = parts[1];
            newEntry._entryText = parts[2];
            newEntry._mood = parts[3];

            _entries.Add(newEntry);
        }
    }
}