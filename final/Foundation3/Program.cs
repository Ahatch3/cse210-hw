using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation3 World!");

        int menu = 0;

        Lecture lecture = new Lecture("Pre-FSY Fireside","Come and see Hank Smith speak before the upcoming FSY about how to be an unconquerable spirit. There will be refreshments afterwards.","4/10/2025", "7PM MST", "123 Elm Street, Rexburg ID", "Hank Smith", 150);

        Reception reception = new Reception("Anderson Wedding","Come and celebrate the wedding of Ethan and Ali Anderson with us! We would love any of their close friends to join us for a reception where we can celebrate this brand new family!", "6/27/2025", "6PM MST", "54 Happiness Lane, Provo, Utah", "ethanandaliwedding@gmail.com");
    
        Outdoor outdoor = new Outdoor("Trek 2025", "Be prepared for a life changing experience during the Twin Falls Stake's 2025 Trek. This should be a great time to be able to really disconnect from the world and experience the past that our ancestors did. We will have many talks, devotionals, and activities with your Ma's and Pa's. Come prepared for a great week!", "7/12/2025", "6AM", "Twin Falls Stake Center (Behind the Temple)", "sunny, but expect a couple of days with lots of rain.");
        
            

        // I want to take the time again to say that with this assignment, I only went through the effort of hard coding it to make it easier to access. I would have gone through the process of appending each of these events to a list that I could then access later, but because of the wording, this seemed the most straight forward. 
        // I probably would have also added the functionality to add a new event, which would have been fairly simple, and I could have also added a functionality to save and load, but that was not in the requirements. 

        while (menu != 2){

            Console.WriteLine("-- Welcome to the Event Planner --\n\n1. View Events\n2. Quit");

            menu = int.Parse(Console.ReadLine());


            if(menu == 1){

                Console.WriteLine("Here are each of the display methods for each of three events:");

                Console.WriteLine("\nFirst Event --\n\n");

                // This is where the Lecture event is displayed.

                Console.Write("---Short Description---\n");
                lecture.ShortDescription();

                Console.WriteLine();

                Console.Write("---Standard Description---\n");
                lecture.StandardDescription();

                Console.WriteLine();

                Console.Write("---Full Display---\n");
                lecture.DisplayFull();

                Console.WriteLine("\nSecond Event --\n\n");

                // This is where the Reception event is displayed.

                Console.Write("---Short Description---\n");
                reception.ShortDescription();

                Console.WriteLine();

                Console.Write("---Standard Description---\n");
                reception.StandardDescription();

                Console.WriteLine();

                Console.Write("---Full Display---\n");
                reception.DisplayFull();

                Console.WriteLine("\nThird Event --\n\n");

                // This is where the Outdoor Gathering event is displayed.

                Console.Write("---Short Description---\n");
                outdoor.ShortDescription();

                Console.WriteLine();

                Console.Write("---Standard Description---\n");
                outdoor.StandardDescription();

                Console.WriteLine();

                Console.Write("---Full Display---\n");
                outdoor.DisplayFull();

                Console.WriteLine();

            }



        }


    }
}