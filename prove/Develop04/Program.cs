using System;
using System.ComponentModel.Design;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop04 World!");

        int menu = 0;

        Breathing breathing = new Breathing();

        Reflection reflection = new Reflection();

        Listing listing = new Listing();

        while(menu != 4){
            
            Console.WriteLine("----Menu Options----\n1. Breathing\n2. Reflection\n3. Listing\n4. Quit");

            menu = int.Parse(Console.ReadLine());

            if(menu == 1){
                breathing.Start();
            }
            else if(menu == 2){
                reflection.Start();
            }
            else if(menu == 3){
                listing.Start();
            }
            else if(menu == 4){
                Console.WriteLine("Goodbye!");
            }
        }
    }
}