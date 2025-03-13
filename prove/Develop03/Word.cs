using System.ComponentModel.DataAnnotations;

public class Word
{
    private Boolean _isHidden = false;

    private string word_text;


    public Word(string text)
    {
        this.word_text = text;

    }

    public void Display()
    {
        if(_isHidden == true)
        {
            Console.Write(" -----");
        }
        else
        {
            Console.Write($" {word_text}");
        }
    }
    public void Hide()
    {
        _isHidden = true;
    }

    public bool Hidden(){
        return _isHidden;
    }
}