// Goal.cs
using System;

public abstract class Goal
{
    public string Description { get; set; }
    public int Points { get; protected set; }

    public abstract void MarkComplete();
    public abstract string ProgressStatus();
}

public class SimpleGoal : Goal
{
    public override void MarkComplete()
    {
        Points = 100;
    }

    public override string ProgressStatus()
    {
        return "[X] Completed";
    }
}

public class ChecklistGoal : Goal
{
    public int RequiredCompletions { get; set; }
    public int Completions { get; private set; }

    public override void MarkComplete()
    {
        Completions++;
        Points = 50;

        if (Completions == RequiredCompletions)
        {
            Points += 500;
        }
    }

    public override string ProgressStatus()
    {
        return $"Completed {Completions}/{RequiredCompletions} times";
    }
}
