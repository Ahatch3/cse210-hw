using System.ComponentModel;

public class Scripture
{
    private Reference scripture_reference;

    private List<Word> word_list = new List<Word>();


    public Scripture(string reference, string text){
        foreach(string word in text.Split(' ')){
            Word word1 = new Word(word);

            word_list.Add(word1);
        }

        string[] strings = reference.Split(' ');

        string book = strings[0];

        string[] strings2 = strings[1].Split(':');

        string chapter = strings2[0];

        if(strings2[1].Contains('-')){

            string[] strings3 = strings2[1].Split('-');

            string Start_verse = strings3[0];

            string End_Verse = strings3[1];

            Reference reference1 = new Reference(book, chapter, Start_verse, End_Verse);

            this.scripture_reference = reference1;

        }
        else{

        string verse = strings2[1];

        Reference reference1 = new Reference(book, chapter, verse);

        this.scripture_reference = reference1;
        }
    }

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

        if(Check_Hidden() is true){

            try_to_hide = 99;

        }

        int random_int = random1.Next(word_list.Count);

        if(word_list[random_int].Hidden() == false){

            word_list[random_int].Hide();
        
            try_to_hide ++;
        }

        
        }
    }

    public Boolean Check_Hidden(){

        bool check = true;

        foreach(Word i in word_list){
            if(i.Hidden() == false){
                return false;
            }
        }
        return true;

        
    }


}