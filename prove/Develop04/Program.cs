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
            Console.WriteLine("   2. Start Reflection Activity");
            Console.WriteLine("   3. Start Listing Activity");
            Console.WriteLine("   4. Quit");
            Console.Write("Select a choice from the menu: ");
            Console.WriteLine("Menu Options:");
            choice = Console.ReadLine();
            if (choice == "1")
            {
                BreathingActivity brAct = new BreathingActivity();
                brAct.Run();
                brAct.DisplayStartingMessage();
                brAct.ShowSpinner(5);
            }
        }
        while (choice !="4");

    }
}