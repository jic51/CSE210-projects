using System;
using System.Collections.Generic;

public class Scripture
{
    // 1. private  atributs
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    // 2. Constructor: saparates the text into words
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        
        // we get each word separates by spaces.
        string[] splitWords = text.Split(' ');

        //we create a Word object for each word and we add it to the list of words.
        foreach (string w in splitWords)
        {
            Word newWord = new Word(w);
            _words.Add(newWord);
        }
    }

    // 3. hide random words
    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        int hiddenCount = 0;

        // we hide the words until we hide the number of words we want.
        
        while (hiddenCount < numberToHide && !IsCompletelyHidden())
        {
            int randomIndex = random.Next(_words.Count);
            
            // only hide words if they are not already hidden.
            if (!_words[randomIndex].IsHidden())
            {
                _words[randomIndex].Hide();
                hiddenCount++;
            }
        }
    }

    // 4. we shiw all in the console
    public string GetDisplayText()
    {
        string scriptureText = "";
        
        foreach (Word word in _words)
        {
            scriptureText += word.GetDisplayText() + " ";
        }

        return $"{_reference.GetDisplayText()} {scriptureText.Trim()}";
    }

    // 5. we check if we are done already
    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false; // If we find a visible word, it's not completely hidden.
            }
        }
        return true;
    }
}