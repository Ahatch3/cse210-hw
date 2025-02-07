using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");


        Fraction f = new Fraction();

        Fraction f2 = new Fraction(2);

        Fraction f3 = new Fraction(2,3);

        Console.WriteLine(f.GetDecimalValue());
        Console.WriteLine(f3.GetDecimalValue());

        Console.WriteLine(f.GetFractionString());
        Console.WriteLine(f3.GetFractionString());

    }
}