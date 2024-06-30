// Program.cs
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Program
{
    static List<Goal> goals = new List<Goal>();

    static void Main(string[] args)
    {
        LoadGoals(); // Load goals from file on startup
        bool exit = false;

        while (!exit)
        {
            DisplayMenu();
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    RecordEvent();
                    break;
                case "3":
                    DisplayGoals();
                    break;
                case "4":
                    SaveGoals();
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    // Other methods like CreateGoal, RecordEvent, DisplayGoals, CalculateScore,
    // SaveGoals, LoadGoals, etc., can be defined here.
}
