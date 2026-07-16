using System;
using System.Collections.Generic;

class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _random = new Random();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] words = text.Split(' ');

        foreach (string word in words)
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWords()
    {
        for (int i = 0; i < 3; i++)
        {
            int index = _random.Next(_words.Count);

            _words[index].Hide();
        }
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

    public string GetDisplayText()
    {
        string scripture = _reference.GetDisplayText();

        scripture += "\n\n";

        foreach (Word word in _words)
        {
            scripture += word.GetDisplayText() + " ";
        }

        return scripture;
    }
}