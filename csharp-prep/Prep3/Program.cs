using System;

class Program
{
    static void Main(string[] args)
    
    { 
        int guessNumber=0;  
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(0,100);    
        do{ 
        Console.WriteLine("What's your guess? ");
        string inputGuessNumber = Console.ReadLine();
        guessNumber = int.Parse(inputGuessNumber);

        if (magicNumber > guessNumber)
        {
            Console.WriteLine("Enter a higher number");
        }
        else if (magicNumber < guessNumber)
        {
            Console.WriteLine("The number is lower");

        }
        else
        {
            Console.WriteLine("Awesome!! You guessed it!");
        }
        } while (magicNumber!=guessNumber);
    } 
    
}