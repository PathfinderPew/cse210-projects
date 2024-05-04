using System;

namespace CSharpPrep2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user for their grade percentage
            Console.Write("Enter your grade percentage: ");
            double gradePercentage = double.Parse(Console.ReadLine());

            // Determine the letter grade
            char letterGrade;
            if (gradePercentage >= 90)
            {
                letterGrade = 'A';
            }
            else if (gradePercentage >= 80)
            {
                letterGrade = 'B';
            }
            else if (gradePercentage >= 70)
            {
                letterGrade = 'C';
            }
            else if (gradePercentage >= 60)
            {
                letterGrade = 'D';
            }
            else
            {
                letterGrade = 'F';
            }

            // Determine if the user passed the course
            bool passed = gradePercentage >= 70;

            // Display the letter grade
            Console.WriteLine($"Your letter grade is: {letterGrade}");

            // Display a message based on whether the user passed
            if (passed)
            {
                Console.WriteLine("Congratulations! You passed the course.");
            }
            else
            {
                Console.WriteLine("Keep working hard! You'll get there next time.");
            }

            // Stretch challenge: Determine the sign (+/-) for the grade
            string sign = "";
            if (letterGrade != 'A' && letterGrade != 'F')
            {
                int lastDigit = (int)gradePercentage % 10;
                if (lastDigit >= 7)
                {
                    sign = "+";
                }
                else if (lastDigit < 3)
                {
                    sign = "-";
                }
            }

            // Handle exceptional cases (A+ and F)
            if (letterGrade == 'A' && gradePercentage == 100)
            {
                sign = "+";
            }
            else if (letterGrade == 'F')
            {
                sign = "";
            }

            // Display the letter grade with sign
            if (!string.IsNullOrEmpty(sign))
            {
                Console.WriteLine($"Your letter grade with sign is: {letterGrade}{sign}");
            }
        }
    }
}
