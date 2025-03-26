using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Net;
using System.Security.Cryptography.X509Certificates;

public class Journal
{
    public List<Entry> EntryList = new List<Entry>();



    public void Write()
    {
        string prompt = Prompt();

        Console.WriteLine(prompt);

        string response = Console.ReadLine();

        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();


        Entry entry1 = new Entry(prompt, response, dateText);

        EntryList.Add(entry1);

    }

    public void Display()
    {
        foreach(Entry e in EntryList){

            Console.WriteLine(e.Display());

        }
    }

    public void Save()
    {   

        List<string> ToBeSaved = new List<string>();

 

        foreach(Entry e in EntryList){

            string save = e.Display();

            ToBeSaved.Add(save);
        }

    

        string[] stringsarray = ToBeSaved.ToArray();

        Console.WriteLine("What would you like to call your journal?" );
        string journal_save = Console.ReadLine();

        System.IO.File.WriteAllLines(journal_save, stringsarray);


    }

    public void Load(){

        Console.WriteLine("What file would you like to load? ");
        string load_journal = Console.ReadLine();

        
        string[] loaded_journal = System.IO.File.ReadAllLines(load_journal);

        foreach(string e in loaded_journal){
            string[] load_split = e.Split("|");

            string date = load_split[0];

            string prompt = load_split[1];

            string response = load_split[2];

            Entry entry1 = new Entry(prompt, response, date);

            EntryList.Add(entry1);

        }

    }

    public string Prompt(){

        List<string> prompts = new List<string>();

        prompts = ["Who was the most interesting person I interacted with today?",
                    "What was the best part of my day?",
                    "How did I see the hand of the Lord in my life today?",
                    "What was the strongest emotion I felt today?",
                    "If I had one thing I could do over today, what would it be?"];


        Random randomgen = new Random();

        int randomint = randomgen.Next(0,4);

        return prompts[randomint];
    }

}