using System;
using System.Threading;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing", "This activity will help you relax by guiding you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    public new int Start()
    {
        int duration = base.Start();
        int elapsed = 0;
        while (elapsed < duration)
        {
            Console.WriteLine("Breathe in...");
            ShowCountdown(4);
            Console.WriteLine("Breathe out...");
            ShowCountdown(4);
            elapsed += 8;
        }
        base.End(duration);
        return duration;
    }
}
