using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");

        string menu = "";


        Scripture temp_scripture = new Scripture("D&C 18:10","Remember the worth of souls is great in the sight of God;");

        Scripture temp_scripture2 = new Scripture("Proverbs 3:5-6", "Trust in the Lord with all thine heart; and lean not unto thine own understanding.  In all thy ways acknowledge him, and he shall direct thy paths.");


        Console.WriteLine("What scripture would you want to memorize? 1. D&C 18:10  OR  2. Proverbs 3:5-6" );

        int choice = int.Parse(Console.ReadLine());

        if(choice == 1){

        while(menu != "QUIT")

        {
            temp_scripture.Display();

            Console.WriteLine();
            Console.WriteLine("Type 'QUIT' to exit the program. ");
            Console.WriteLine("Press 'Enter' to hide more words. ");

            menu = Console.ReadLine();

            if(temp_scripture.Check_Hidden() == true)
            {
                menu = "QUIT";
            }

            temp_scripture.Hide_words();
        }
        }
        else if(choice == 2){
            while(menu != "QUIT")

        {
            temp_scripture2.Display();

            Console.WriteLine();
            Console.WriteLine("Type 'QUIT' to exit the program. ");
            Console.WriteLine("Press 'Enter' to hide more words. ");

            menu = Console.ReadLine();

            if(temp_scripture2.Check_Hidden() == true)
            {
                menu = "QUIT";
            }

            temp_scripture2.Hide_words();
        }
        }
    }
}