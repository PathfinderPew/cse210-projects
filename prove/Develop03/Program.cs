using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        var scriptures = new List<Scripture>
        {
            new Scripture(new Reference("Isaiah", 1, 18), "Come now, and let us reason together, saith the Lord: though your sins be as scarlet, they shall be as white as snow; though they be red like crimson, they shall be as wool."),
            new Scripture(new Reference("Mosiah", 27, 35), "And they were about to take their journey, insomuch that they were desirous to be baptized as the Lamanites were. And they had come unto the fold of God, and had joined the church of God."),
            new Scripture(new Reference("Matthew", 21, 22), "And all things, whatsoever ye shall ask in prayer, believing, ye shall receive."),
            new Scripture(new Reference("Doctrine and Covenants", 58, 4), "For after much tribulation come the blessings. Wherefore the day cometh that ye shall be crowned with much glory; the hour is not yet, but is nigh at hand."),
            new Scripture(new Reference("Isaiah", 41, 10), "Fear thou not; for I am with thee: be not dismayed; for I am thy God: I will strengthen thee; yea, I will help thee; yea, I will uphold thee with the right hand of my righteousness.")
        };

        Random random = new Random();
        Scripture selectedScripture = scriptures[random.Next(scriptures.Count)];

        while (true)
        {
            selectedScripture.Display();
            Console.WriteLine("\nPress Enter to hide a few words, or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break;

            selectedScripture.HideWords(3);

            if (selectedScripture.Words.All(w => w.IsHidden))
                break;
        }

        Console.WriteLine("All words are hidden. Program has ended.");
    }
}