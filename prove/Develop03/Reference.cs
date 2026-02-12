public class Reference
{
    // 1. private atributes
    // save data about the reference: book, chapter, verse(s)
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    // 2. Constructor for one verse (John 3:16)
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = verse;
    }

    // 3. Constructor for more than 1 verse (ej. Proverbs 3:5-6)
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;
    }

    // 4.Abstracción
    // it only asks for the data.
    public string GetDisplayText()
    {
        if (_verse == _endVerse)
        {
            return $"{_book} {_chapter}:{_verse}";
        }
        else
        {
            return $"{_book} {_chapter}:{_verse}-{_endVerse}";
        }
    }
}