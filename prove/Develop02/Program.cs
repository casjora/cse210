using System;

class Program
{
    static void Main(string[] args)
    {
        
        int userInput=0;
        Journal journal = new Journal();
        PromptGenerator promptText=new PromptGenerator();
        
        do{
            try
            {
                Console.WriteLine("\nSelect a number option from the menu: \n1.Write a new prompt\n2.Display added prompts\n3.Save your added prompts to a text file\n4. Load the text file\n5. Quit \n");
                userInput = int.Parse(Console.ReadLine());
                
                if (userInput==1)
                {
                    Entry newEntry = new Entry();
                    newEntry._date = DateTime.Today.ToString("MM/dd/yyyy");
                    newEntry._promptText=promptText.GetRandomPrompt();
                    Console.WriteLine(newEntry._promptText);
                    newEntry._entryText = Console.ReadLine();
                    journal._entries.Add(newEntry);
                }
                else if(userInput==2)
                {
                    journal.DisplayAll();
                }
                else if(userInput==3)
                {
                
                    journal.SaveToFile("");
                    
                }
                else if(userInput==4)
                {
                    journal.LoadFromFile("");
                }
                else if (userInput==5)

                break;
                else if (userInput<1 | userInput>5)
                {
                    Console.WriteLine("Enter a number between 1-5");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Avoid using non numerical characters.");
            }
            //Console.WriteLine("Hello Develop02 World!");

            //Console.WriteLine(prompt1.GetRandomPrompt());
        }while (userInput!=5);
    }
}