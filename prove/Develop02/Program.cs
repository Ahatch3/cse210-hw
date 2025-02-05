using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop02 World!");

        int menu = 0;


        Journal journal1 = new Journal();

        while (menu != 5)
        {
            Console.WriteLine("1. Write \n2. Display \n3. Save \n4. Load. \n5. Quit");
            menu = int.Parse(Console.ReadLine());

            if (menu == 1){
                journal1.Write();
                
            }

            if (menu == 2){

                journal1.Display();

            }

            if (menu == 3){

                journal1.Save();

            }

            if (menu == 4){

            }
        }

        
    }
}