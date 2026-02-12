using System;
using System.Collections.Generic;

public class Scripture
{
    // 1. Atributos: Una escritura TIENE una referencia y una LISTA de palabras.
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    // 2. Constructor: Aquí sucede la "magia" de separar el texto.
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        
        // Separamos el texto por espacios para obtener cada palabra.
        string[] splitWords = text.Split(' ');

        // Por cada palabra del texto, creamos un nuevo objeto Word y lo metemos a la lista.
        foreach (string w in splitWords)
        {
            Word newWord = new Word(w);
            _words.Add(newWord);
        }
    }

    // 3. Método para ocultar palabras al azar.
    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        int hiddenCount = 0;

        // Intentamos ocultar el número de palabras que nos pidieron.
        // Pero primero revisamos si todavía hay palabras visibles.
        while (hiddenCount < numberToHide && !IsCompletelyHidden())
        {
            int randomIndex = random.Next(_words.Count);
            
            // Solo la ocultamos si no estaba oculta ya.
            if (!_words[randomIndex].IsHidden())
            {
                _words[randomIndex].Hide();
                hiddenCount++;
            }
        }
    }

    // 4. Método para mostrar todo en pantalla.
    public string GetDisplayText()
    {
        string scriptureText = "";
        
        foreach (Word word in _words)
        {
            scriptureText += word.GetDisplayText() + " ";
        }

        return $"{_reference.GetDisplayText()} {scriptureText.Trim()}";
    }

    // 5. Método para saber si ya terminamos.
    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false; // Si encuentra una sola palabra visible, no está completa.
            }
        }
        return true;
    }
}