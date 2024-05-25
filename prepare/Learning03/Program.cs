using System;

class Program
{
    static void Main(string[] args)
    {
        // Create instances using different constructors
        Fraction fraction1 = new Fraction();
        Fraction fraction2 = new Fraction(5);
        Fraction fraction3 = new Fraction(3, 4);

        // Display fractions and their decimal values
        Console.WriteLine(fraction1.GetFractionString()); // 1/1
        Console.WriteLine(fraction1.GetDecimalValue());   // 1

        Console.WriteLine(fraction2.GetFractionString()); // 5/1
        Console.WriteLine(fraction2.GetDecimalValue());   // 5

        Console.WriteLine(fraction3.GetFractionString()); // 3/4
        Console.WriteLine(fraction3.GetDecimalValue());   // 0.75

        // Test getters and setters
        fraction3.SetNumerator(1);
        fraction3.SetDenominator(3);

        Console.WriteLine(fraction3.GetFractionString()); // 1/3
        Console.WriteLine(fraction3.GetDecimalValue());   // 0.3333333333333333
    }
}