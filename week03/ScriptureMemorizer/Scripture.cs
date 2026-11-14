using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] splitText = text.Split(' ');
        foreach (string wordText in splitText)
        {
            _words.Add(new Word(wordText));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        List<Word> visibleWords = new List<Word>();
        foreach (Word word in _words)
        {
            // Note: Make sure your Word class uses IsHidden() with a capital I
            if (!word.IsHidden())
            {
                visibleWords.Add(word);
            }
        }

        Random random = new Random();
        int count = 0;

        // Fixed the duplicate "ToHide" typo here
        while (count < numberToHide && visibleWords.Count > 0)
        {
            int index = random.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
            count++;
        }
    }

    public string GetDisplayText()
    {
        string displayText = _reference.GetDisplayText() + " ";

        List<string> wordStrings = new List<string>();
        foreach (Word word in _words)
        {
            wordStrings.Add(word.GetDisplayText());
        }

        displayText += string.Join(" ", wordStrings);
        return displayText;
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}