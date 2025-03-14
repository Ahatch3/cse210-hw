
using System.Diagnostics;

class Breathing : Activity
{

    public void Start(){

        Console.WriteLine(Start_Message,"Breathing Activity");

        Console.WriteLine("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
    
        int duration = GetTime();

        PrepTime();

        PerformBreathing(duration);
    }

    public void PerformBreathing(int duration){

        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        while (stopwatch.Elapsed.TotalSeconds < duration)
        {
            Console.Write("Breathe in...");
            Ani(5);
            Thread.Sleep(500);

            Console.Write("Breathe out...");
            Ani(5);
            Thread.Sleep(500);
        }

        stopwatch.Stop();
        Console.WriteLine(End_Message + "Breathing Activity");

    }


}