using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation4 World!");

        List<Activity> activities = new List<Activity>();

        int loop = 1;


        // Creating the instances and adding them to the list
        Biking biking = new Biking("28 Jul 2023", 46, 20.3);

        activities.Add(biking);

        Running running = new Running("02 Apr 2025", 30, 3.2);

        activities.Add(running);

        Swimming swimming = new Swimming("12 Dec 2025", 20, 18);

        activities.Add(swimming);



        // Looping through the list and displaying all of them.

        Console.WriteLine("\n\n--- Here is each of the three activities ---\n");

        foreach (Activity activity in activities){

            Console.WriteLine($"--{loop}--");

            activity.DisplaySummary();

            Console.WriteLine();

            loop += 1;

        }


    }
}