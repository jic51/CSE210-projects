public class Reference
{
    // 1. Atributos Privados (Encapsulación)
    // Guardamos los datos bajo llave para que nadie los cambie por error.
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    // 2. Constructor para un solo versículo (ej. Juan 3:16)
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = verse; // Si es solo uno, el final es el mismo que el inicio.
    }

    // 3. Constructor para un rango (ej. Proverbios 3:5-6)
    // Nota que este tiene 4 parámetros en lugar de 3. C# sabe cuál usar.
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;
    }

    // 4. Comportamiento (Abstracción)
    // El mundo exterior solo pide "el texto", no le importa cómo lo armamos.
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