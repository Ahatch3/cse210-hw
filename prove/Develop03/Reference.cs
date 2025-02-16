using System.Security.Cryptography;

public class Reference
{
    private string Book;

    private string Chapter;

    private string Start_verse;

    private string End_Verse;



    public Reference(string Book, string Chapter, string Start_verse)
    {
        this.Book = Book;
        this.Chapter = Chapter;
        this.Start_verse = Start_verse;
    }

    public Reference(string Book, string Chapter, string Start_verse, string End_Verse)
    {
        this.Book = Book;
        this.Chapter = Chapter;
        this.Start_verse = Start_verse;
        this.End_Verse = End_Verse;
    }

    public void Display()
    {
        if(End_Verse == null)
        {
            Console.Write($"{Book} {Chapter}: {Start_verse}");
        }
        else
        {
            Console.Write($"{Book} {Chapter}: {Start_verse}-{End_Verse}");
        }
    }
}