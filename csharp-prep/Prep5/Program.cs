using System;
using Microsoft.VisualBasic;

class Program
{
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName (string userName)
    {
        Console.WriteLine("Please enter your name: ");
        userName = Console.ReadLine();
        return userName;
    }
    static int PromptNumber (int number)
    {
        Console.WriteLine("What's your favorite integer number? ");
        string inputNumber = Console.ReadLine();
        number = int.Parse(inputNumber);

        return number;
    }

    static int SquareNumber  (int number)
    {
        int square = number*number;

        return square;
    }

    static void DisplayResult (string userName,int square)
    {
        Console.WriteLine($"{userName}, the square of your number is {square}");
    }

    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName("");
        int number=PromptNumber(0);
        int square=SquareNumber(number);
        DisplayResult(name,square);

    }
}