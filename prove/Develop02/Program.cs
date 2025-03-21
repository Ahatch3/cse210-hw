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
            
            Thread animationThread = new Thread(Animate);
            animationThread.Start();

            menu = int.Parse(Console.ReadLine());

            animationThread.Interrupt();

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
                journal1.Load();

            }
        }
    }

                public static void Animate()
    {
        string[] animationFrames = { "|", "/", "-", "\\" };
        int currentFrame = 0;

        try
        {
            while (true)
            {
                Console.Write($"\rPlease select an option -- {animationFrames[currentFrame]} -- "); 
                currentFrame = (currentFrame + 1) % animationFrames.Length;
                Thread.Sleep(200); 
            }
        }
        catch (ThreadInterruptedException)
        {
            Console.Write("\r");
        }
    }

        
}