using System;

class Program
{
    static void Main(string[] args)
    {

        Fraction defaultFraction = new Fraction();
        Fraction topFraction = new Fraction(5);
        Fraction mixedFraction = new Fraction(3, 4);
        Fraction oneThird = new Fraction(1, 3);

        Console.WriteLine(defaultFraction.GetFractionString());
        Console.WriteLine(defaultFraction.GetDecimalValue());

        Console.WriteLine(topFraction.GetFractionString());
        Console.WriteLine(topFraction.GetDecimalValue());

        Console.WriteLine(mixedFraction.GetFractionString());
        Console.WriteLine(mixedFraction.GetDecimalValue());

        Console.WriteLine(oneThird.GetFractionString());
        Console.WriteLine(oneThird.GetDecimalValue());

        Fraction myFraction = new Fraction();
        Random randomInt = new Random();

        for (int i = 1; i <= 20; i++)
        {
            myFraction.SetTop(randomInt.Next(1, 50));
            myFraction.SetBottom(randomInt.Next(1, 50));

            Console.WriteLine($"Fraction {i}: String: {myFraction.GetFractionString()} Decimal: {myFraction.GetDecimalValue()}");
        }



    }
}