using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction1 = new Fraction();
        Console.WriteLine(fraction1.GetFractionString()); // 1/1
        Console.WriteLine(fraction1.GetDecimalValue()); // 1

        Fraction fraction2 = new Fraction(5);
        Console.WriteLine(fraction2.GetFractionString()); // 5/1
        Console.WriteLine(fraction2.GetDecimalValue()); // 5

        Fraction fraction3 = new Fraction(3, 4);
        Console.WriteLine(fraction3.GetFractionString()); // 3/4
        Console.WriteLine(fraction3.GetDecimalValue()); // 0.75

        Fraction fraction4 = new Fraction();
        fraction4.SetNumerator(1);
        fraction4.SetDenominator(3);
        Console.WriteLine(fraction4.GetFractionString()); // 1/3
        Console.WriteLine(fraction4.GetDecimalValue()); // 0.3333333333333333
    }
}