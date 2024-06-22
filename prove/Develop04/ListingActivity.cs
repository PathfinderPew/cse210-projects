using System;
using System.Threading;

public class ListingActivity : Activity
{
    private string[] prompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
    }

    public new int Start()
    {
        int duration = base.Start();
        Random random = new Random();
        string prompt = prompts[random.Next(prompts.Length)];
        Console.WriteLine(prompt);
        Thread.Sleep(3000); // Simulate delay
        Console.WriteLine("Start listing...");
        Thread.Sleep(5000); // Simulate listing time
        DateTime startTime = DateTime.Now;
        int count = 0;
        while ((DateTime.Now - startTime).TotalSeconds < duration)
        {
            Console.WriteLine("Enter a new item: ");
            // Assuming you read and count inputs here
            count++;
        }
        Console.WriteLine($"You have listed {count} items.");
        base.End(duration);
        return duration;
    }
}
