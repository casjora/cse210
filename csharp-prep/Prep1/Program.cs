using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep1 World!");
        Console.Write("What's your first name? ");
        string first_name = Console.ReadLine();
        Console.Write("What's your last name? ");
        string last_name = Console.ReadLine();
        Console.Write($"Your name is {last_name}, {first_name} {last_name}.");

    }
}