public class Word
{
    // private attributes
    private string _text;
    private bool _isHidden;

    // Constructor: all word her is visible (_isHidden = false)
    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    // hide the word
    public void Hide()
    {
        _isHidden = true;
    }

    // we can show the word also
    public void Show()
    {
        _isHidden = false;
    }

    // it tells us if the word is hidden or not
    public bool IsHidden()
    {
        return _isHidden;
    }

    // how we show the word in the console
    public string GetDisplayText()
    {
        if (_isHidden)
        {
            // if it's hidden, we return underscores instead of the word.
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