using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();//{get;set}
    //PromptGenerator prompt1 = new PromptGenerator();
    
    

    /*public Journal(List<Entry>entries)
    {
        _entries=entries;
    }*/
    public void AddEntry(Entry newEntry)
    {
        string date = newEntry._date;
        string promptText = newEntry._promptText;
        string entryText = newEntry._entryText;
        

    }
    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();

        }

    }

    public void SaveToFile(string file)
    {
        Console.WriteLine("Please enter a text file name, remember to use a .txt at the end.");
        string fileName = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry line in _entries)
            {
            outputFile.WriteLine($"Date: {line._date} - {line._promptText} {line._entryText}");
            }
        }

    }

    public void LoadFromFile (string file)
    {
        Console.WriteLine("Please enter a text file name, remember to use a .txt at the end.");
        string fileName = Console.ReadLine();

        if (File.Exists(fileName))
            {
            string [] lines = System.IO.File.ReadAllLines(fileName);
            foreach (string line in lines)
            {
                char [] characters = {';','-',':','?'};
               // Entry reader = new Entry();
                string[] parts = line.Split(characters);
                string _date=parts[0].Trim();
                string _promptText = parts[1].Trim();
                string _entryText = parts[2].Trim();
                string _entryText2 = parts[3].Trim();


               // Journal journal = new Journal();
                //journal._entries.Add(line);
                Console.WriteLine($"{_date} - {_promptText} - {_entryText}? \n{_entryText2}");
            }
        }
        else
        {Console.WriteLine("File not found");}


    }

}