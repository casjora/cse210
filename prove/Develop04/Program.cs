using System;

class Program
{
    static void Main(string[] args)
    {
        var choice = "";
        do
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("   1. Start Breathing Activity");
            Console.WriteLine("   2. Start Breathing Activity");
            Console.WriteLine("   3. Start Breathing Activity");
            Console.WriteLine("   4. Start Breathing Activity");
            Console.Write("Select a choice from the menu: ");
            Console.WriteLine("Menu Options:");
            choice = Console.ReadLine();
            if (choice == "1")
            {
                BreathingActivity brAct = new BreathingActivity();
                brAct.Run();
                brAct.DisplayStartingMessage();
                brAct.ShowSpinner(10);
            }
        }
        while (choice !="4");

    }
}