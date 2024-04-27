using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        Console.Write("Please enter your grade as an integer: ");
        string inputGrade = Console.ReadLine();
        int grade = int.Parse(inputGrade);
        string letterGrade;

        if (grade>=90)
        {
            letterGrade = "A";
            Console.WriteLine($"Your letter grade is {letterGrade}");
        }

        else if (grade>=80)
        {
        letterGrade = "B";
        Console.WriteLine($"Your letter grade is {letterGrade}");
        }
        else if (grade>=70)
        {
        letterGrade = "C";
        Console.WriteLine($"Your letter grade is {letterGrade}");
        }
        else if (grade>=60)
        {
        letterGrade = "D";
        Console.WriteLine($"Your letter grade is {letterGrade}");
        }
        else
        {
        letterGrade = "F";
        Console.WriteLine($"Your letter grade is {letterGrade}");
        }

        if (grade>=70)
        {
            Console.Write("You passed the class");
        }
        else
        {
            Console.Write("Sadly you did not pass this time but you can do it next time!");
        }

        

    }
}