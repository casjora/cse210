using System.Reflection.Metadata.Ecma335;
using System.Xml.XPath;


public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference,string text)
    { //split words in text
    /*
    string name = "Jhon Deere";
    string [] words = name.Split(" ");
    Console.WriteLine(words[0]);
    Console.WriteLine(words[1]);*/
    _reference = reference;
    _words=new List<Word>();

    string[] words=text.Split(" ");
    foreach (string word in words)
    { 
        _words.Add(new Word(word));
    }

    }

    public void HideRandomWords(int numberToHide)
    {
        //set state of randomly selected group of words to be hidden
        // find a set of visible words
        // Need to randomly select numberToHide

        Random random = new Random();
        int wordsHidden = 0;
        while (wordsHidden < numberToHide)
        {
            int index = random.Next(_words.Count);
            if (!_words[index].IsHidden())
            {

                _words[index].Hide();
                wordsHidden++;
            }
        }
    }

    public string GetDisplayText()
    {
        string displayText = $"{_reference.GetDisplayText()}\n";
        foreach (Word word in _words)
        {
            displayText += word.GetDisplayText() + " ";
        }
        return displayText;
    }

    

    public bool isCompletelyHidden()
    {
        
        foreach (Word word in _words)
        {
            if (!word.IsHidden())

                return false;
        }
    return true;
    }

}