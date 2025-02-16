using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");

        string menu = "";

        while(menu != "QUIT")
        {
            temp_scripture.Display();

            Console.WriteLine("Type 'QUIT' to exit the program. ");
            Console.WriteLine("Press 'Enter' to hide more words. ");

            menu = Console.ReadLine();

            if(Check_Hidden == true)
            {
                menu = "QUIT";
            }

            temp_scripture.Hide_words();


            

        }
    }
}