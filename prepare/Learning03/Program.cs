using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction n1 = new Fraction();
        Fraction n2 = new Fraction(5);
        Fraction n3 = new Fraction(3, 4);

        n1.SetBottom(2);
        Console.WriteLine(n1.GetBottom());

        Console.WriteLine(n1.GetFractionString());
        Console.WriteLine(n1.GetDecimalValue());

        Console.WriteLine(n2.GetFractionString());
        Console.WriteLine(n2.GetDecimalValue());

        Console.WriteLine(n3.GetFractionString());
        Console.WriteLine(n3.GetDecimalValue());
    }
}