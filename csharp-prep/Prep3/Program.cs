using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");
        Console.Write("What's the magic number? ");
        string inputMagicNumber = Console.ReadLine();
        int magicNumber = int.Parse(inputMagicNumber); 
        Console.Write("What's your guess? ");
        string inputGuessNumber = Console.ReadLine();
        int guessNumber = int.Parse(inputGuessNumber);

        if (magicNumber > guessNumber)
        {
            Console.Write("Enter a higher number");
        }
        else if (magicNumber < guessNumber)
        {
            Console.Write("The number is lower");

        }
        else
        {
            Console.Write("Awesome!! You guessed it!");
        }
    }
}