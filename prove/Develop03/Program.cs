using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Reference reference = new Reference("Alma",2,12);
        Scripture scripture = new Scripture(reference,"Therefore the people of the Nephites were aware of the intent of the Amlicites, and therefore they did prepare to meet them; yea, they did arm themselves with swords, and with cimeters, and with bows, and with arrows, and with stones, and with slings, and with all manner of weapons of war, of every kind.");
        Console.WriteLine("Press Enter to begin hiding words. Type 'quit' and press Enter to exit.");

        while (!scripture.isCompletelyHidden())
        {
            Console.ReadLine(); // Wait for user input
            
            if (Console.ReadLine().ToLower() == "quit")
                break;
            

            scripture.HideRandomWords(3); // Hide 3 random words
            Console.Clear(); // Clear console
            Console.WriteLine(scripture.GetDisplayText()); // Display the scripture
        }

        Console.WriteLine("All words are hidden. Press any key to exit.");
        Console.ReadKey();
    }
}