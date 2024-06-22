using System;

public class Program
{
    public static void Main()
    {
        Activity[] activities = {
            new BreathingActivity(),
            new ReflectionActivity(),
            new ListingActivity()
        };

        while (true)
        {
            Console.WriteLine("Select an activity:");
            Console.WriteLine("1. Breathing");
            Console.WriteLine("2. Reflection");
            Console.WriteLine("3. Listing");
            Console.WriteLine("4. Exit");

            int choice;
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                if (choice == 4)
                    break;
                else if (choice > 0 && choice <= activities.Length)
                    activities[choice - 1].Start();
                else
                    Console.WriteLine("Invalid choice. Please try again.");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        }
    }
}
