using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation1 World!");

        int menu = 0;

        Console.WriteLine("---Welcome to Youtube!---");

        

        while (menu != 5){

            Console.WriteLine("\n--Menu--\n\n1. Dog Throws Shark in Ocean\n2. Aliens... Real?\n3. The Importance of Being Lazy\n4. Paw Patrol Song - 4 Hour Loop\n5. Quit");

            menu = int.Parse(Console.ReadLine());

            if (menu == 1){

                string _author = "DogOnWheelz";

                int _vidLength = 2;

                string _title = "Dog Throws Shark in Ocean";

                Video video = new Video(_author, _vidLength, _title);


                video.Display();

            }

            if (menu == 2){

                string _author = "TheyAreAmongUs";

                int _vidLength = 45;

                string _title = "Aliens... Real?";

                Video video = new Video(_author, _vidLength, _title);


                video.Display();

            }

            if (menu == 3){

                string _author = "SomePoetYouUsedToKnow";

                int _vidLength = 27;

                string _title = "The Importance of Being Lazy";

                Video video = new Video(_author, _vidLength, _title);


                video.Display();

            }

            if (menu == 4){

                string _author = "PawPatrolRoxxx";

                int _vidLength = 240;

                string _title = "Paw Patrol Song - 4 Hour Loop";

                Video video = new Video(_author, _vidLength, _title);


                video.Display();

            }
        }

    }
}