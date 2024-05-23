using System;

class Program
{
    //Just testing
    static void Main(string[] args)
    {
        int toHide = 1;
        Console.Clear();
        Reference reference = new Reference("Alma",2,12,13);
        Scripture scripture = new Scripture(reference,"Therefore the people of the Nephites were aware of the intent of the Amlicites, and therefore they did prepare to meet them; yea, they did arm themselves with swords, and with cimeters, and with bows, and with arrows, and with stones, and with slings, and with all manner of weapons of war, of every kind.");
        Console.WriteLine("Press Enter to begin hiding words. Type 'quit' and press Enter to exit.\n");
        //Console.WriteLine(scripture.GetDisplayText());
        while (!scripture.isCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
           string response = Console.ReadLine(); // Wait for user input
            
            if (response.ToLower() == "quit")
                break;
            else
            {
            
            scripture.HideRandomWords(toHide); // Hide increment words
            Console.Clear(); // Clear console
            Console.WriteLine(scripture.GetDisplayText()); // Display the scripture
            toHide++;
            }
        }

        Console.WriteLine("All words are hidden. Press any key to exit.");
       // Console.ReadKey();
    }
}