public class Scripture
{
    private Reference scripture_reference;

    private List<Word> word_list = new List<Word>();


    public void Display()
    {
        scripture_reference.Display();

        foreach(Word i in word_list)
        {
            i.Display();
        }
    }

    public void Hide_words()
    {
        Random random1 = new Random();

        int try_to_hide = 0;

        while(try_to_hide < 3)
        {
        int random_int = random1.Next(word_list.Count);

        word_list[random_int].Hide();
        
        try_to_hide ++;
        }
    }


}