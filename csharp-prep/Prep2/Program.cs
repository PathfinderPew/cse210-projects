using System;

namespace Prep2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user for their grade percentage
            Console.Write("Enter your grade percentage: ");
            string input = Console.ReadLine();
            int gradePercentage = int.Parse(input);

            // Determine the letter grade
            string letter;
            if (gradePercentage >= 90)
            {
                letter = "A";
            }
            else if (gradePercentage >= 80)
            {
                letter = "B";
            }
            else if (gradePercentage >= 70)
            {
                letter = "C";
            }
            else if (gradePercentage >= 60)
            {
                letter = "D";
            }
            else
            {
                letter = "F";
            }

            // Determine if the user passed the course
            bool passed = gradePercentage >= 70;

            // Print out the appropriate letter grade
            Console.WriteLine($"Your letter grade is: {letter}");

            // Print a message based on whether the user passed or not
            if (passed)
            {
                Console.WriteLine("Congratulations! You passed the course.");
            }
            else
            {
                Console.WriteLine("Don't worry, you can try again next time!");
            }

            // Stretch Challenge: Determine the sign for the grade
            string sign = "";
            if (gradePercentage % 10 >= 7 && letter != "F" && letter != "A")
            {
                sign = "+";
            }
            else if (gradePercentage % 10 < 3 && letter != "F")
            {
                sign = "-";
            }

            // Handle exceptional cases for A+ and F grades
            if (letter == "A" && sign == "+")
            {
                letter = "A";
                sign = "";
            }
            else if (letter == "F" && (sign == "+" || sign == "-"))
            {
                sign = "";
            }

            // Print the letter grade with the sign
            Console.WriteLine($"Your letter grade with sign is: {letter}{sign}");
        }
    }
}