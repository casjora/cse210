using System.ComponentModel.DataAnnotations;

public class Entry
{
    public string _date;//{get;set;}
    public string _promptText;//{get;set;}
    public string _entryText;//{get;set;}

    /*public Entry (string date,string promptText,string entryText)
    {
        _date = date;
        promptText = _promptText;
        entryText = _entryText;

    }*/

    public void Display()
    {
        Console.WriteLine($"{_date} - Prompt: {_promptText} \n{_entryText}");
    }


}