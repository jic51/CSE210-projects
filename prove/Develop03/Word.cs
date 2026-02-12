public class Word
{
    // Atributos privados
    private string _text;
    private bool _isHidden;

    // Constructor: Al principio, toda palabra nace visible (_isHidden = false)
    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    // Método para ocultar la palabra
    public void Hide()
    {
        _isHidden = true;
    }

    // Método para mostrar la palabra (por si acaso)
    public void Show()
    {
        _isHidden = false;
    }

    // Método que nos dice si la palabra ya está oculta
    public bool IsHidden()
    {
        return _isHidden;
    }

    // El corazón de la lógica: ¿Cómo me muestro al mundo?
    public string GetDisplayText()
    {
        if (_isHidden)
        {
            // Si está oculta, creamos una cadena de guiones del mismo largo que el texto
            // Ejemplo: "Dios" -> "____"
            string underscores = "";
            foreach (char letter in _text)
            {
                underscores += "_";
            }
            return underscores;
        }
        else
        {
            return _text;
        }
    }
}