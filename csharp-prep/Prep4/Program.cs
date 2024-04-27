using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        
        int number =0;
        int sum =0;
        double avg =0.0;
        int highest=0;
        do{
            Console.Write("Enter a number: ");
            string inputNumber = Console.ReadLine();
            number = int.Parse(inputNumber);
            if (number !=0)
            {
                numbers.Add(number);
            }

        } while(number!=0);
        foreach (int numbera in numbers)
        
        sum =numbers.Sum();
        highest = numbers.Max();
        avg = Queryable.Average(numbers.AsQueryable());
            

        
        Console.WriteLine(sum);
        Console.WriteLine(avg);
        Console.WriteLine(highest);
        

        

    }
}