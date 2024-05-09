using System;

class Program
{
    static void Main(string[] args)
    {
        
        
        Fraction fract = new Fraction();
        Fraction fract2= new Fraction(6);
        Fraction fract3 = new Fraction(6,7);
        Fraction top = new Fraction();
        top.SetTop(0);
        top.SetBottom(0);
        Console.WriteLine(top.GetTop());
        Console.WriteLine(top.GetBottom());
        Console.WriteLine(top.GetFractionString());
        Console.WriteLine(top.GetDecimalValue());

    }
}