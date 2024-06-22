using System;
using System.Threading;

public class Activity
{
    public string Name { get; private set; }
    public string Description { get; private set; }

    public Activity(string name, string description)
    {
        Name = name;
        Description = description;
    }

    public int Start()
    {
        Console.Write($"Enter the duration for the {Name} activity (in seconds): ");
        int duration = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Starting {Name} activity.");
        Console.WriteLine(Description);
        Thread.Sleep(3000); // Simulate delay
        return duration;
    }

    public void End(int duration)
    {
        Console.WriteLine($"Good job! You have completed the {Name} activity for {duration} seconds.");
        Thread.Sleep(3000); // Simulate delay
    }

    public void ShowCountdown(int seconds)
    {
        while (seconds > 0)
        {
            Console.Write($"{seconds} seconds remaining...");
            Thread.Sleep(1000); // Simulate delay
            seconds--;
            Console.SetCursorPosition(0, Console.CursorTop); // Move cursor back to start of the line
        }
        Console.WriteLine();
    }
}
