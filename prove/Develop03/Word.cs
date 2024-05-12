using System.Xml.XPath;

public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public string GetDisplayText()
    {
        return _text;
    }

    public void Show()
    {
        _isHidden = false;
    }
    public void Hide()
    {
        _text = "___";
        _isHidden=true;
    }

    public bool IsHidden()
    {
       return _isHidden;
    }
}