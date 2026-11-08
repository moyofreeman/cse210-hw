using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Fractions Project.");

        Console.WriteLine("Testing Constructors & Representations");

        Fraction f1 = new Fraction();
        Fraction f2 = new Fraction(5);
        Fraction f3 = new Fraction(3, 4);
        Fraction f4 = new Fraction(1, 3);

        DisplayFractionInfo(f1);
        DisplayFractionInfo(f2);
        DisplayFractionInfo(f3);
        DisplayFractionInfo(f4);

        Console.WriteLine("Testing Getters and Setters");
        Fraction testFraction = new Fraction();

        Console.WriteLine($"Initial Fraction: {testFraction.GetFractionString()}");

        testFraction.SetTop(2);
        testFraction.SetBottom(5);

        Console.WriteLine($"Retrieved Top using GetTop(): {testFraction.GetTop()}");
        Console.WriteLine($"Retrieved Bottom using GetBottom(): {testFraction.GetBottom()}");
        Console.WriteLine($"Updated Fraction String: {testFraction.GetFractionString()}");
        Console.WriteLine($"Updated Decimal Value: {testFraction.GetDecimalValue()}");
    }

    static void DisplayFractionInfo(Fraction fraction)
    {
        Console.WriteLine($"Fraction String: {fraction.GetFractionString()} | Decimal Value: {fraction.GetDecimalValue()}");
    }
}