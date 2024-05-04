using System;
using System.Collections.Generic;

namespace Prep4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            int number;
            
            Console.WriteLine("Enter a list of numbers, type 0 when finished.");
            do
            {
                Console.Write("Enter number: ");
                number = int.Parse(Console.ReadLine());
                if (number != 0)
                {
                    numbers.Add(number);
                }
            } while (number != 0);

            // Core Requirement 1: Compute the sum
            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }
            Console.WriteLine($"The sum is: {sum}");

            // Core Requirement 2: Compute the average
            double average = (double)sum / numbers.Count;
            Console.WriteLine($"The average is: {average}");

            // Core Requirement 3: Find the maximum number
            int max = numbers[0];
            foreach (int num in numbers)
            {
                if (num > max)
                {
                    max = num;
                }
            }
            Console.WriteLine($"The largest number is: {max}");

            // Stretch Challenge 1: Find the smallest positive number
            int minPositive = int.MaxValue;
            foreach (int num in numbers)
            {
                if (num > 0 && num < minPositive)
                {
                    minPositive = num;
                }
            }
            if (minPositive == int.MaxValue)
            {
                Console.WriteLine("There are no positive numbers.");
            }
            else
            {
                Console.WriteLine($"The smallest positive number is: {minPositive}");
            }

            // Stretch Challenge 2: Sort the numbers
            numbers.Sort();
            Console.WriteLine("The sorted list is:");
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}
