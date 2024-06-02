using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    public Reference Reference { get; private set; }
    public List<Word> Words { get; private set; }

    public Scripture(Reference reference, string text)
    {
        Reference = reference;
        Words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public void HideWords(int count)
    {
        Random random = new Random();
        int hiddenCount = 0;
        while (hiddenCount < count)
        {
            int index = random.Next(Words.Count);
            if (!Words[index].IsHidden)
            {
                Words[index].Hide();
                hiddenCount++;
            }
        }
    }

    public void Display()
    {
        Console.Clear();
        Console.WriteLine(Reference.ToString());
        Console.WriteLine(string.Join(" ", Words));
    }
}