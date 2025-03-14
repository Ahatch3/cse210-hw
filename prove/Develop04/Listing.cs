using System.Diagnostics;

class Listing : Activity
{


    private Random random = new Random();

    string[] prompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"};

    public void Start(){

        Console.WriteLine(Start_Message,"Listing Activity");

        Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
    
        int duration = GetTime();

        PrepTime();

        PerformListing(duration);
    }


    



    public void PerformListing(int duration){


        string randomPrompt = GetRandomPrompt();

        List<string> items = new List<string>();

        Console.WriteLine(randomPrompt);
        Console.Write("Get ready to write a list... ");
        Ani(10);

        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        Console.WriteLine("Start listing as many as you can think of! \n");

        while (stopwatch.Elapsed.TotalSeconds < duration)
        {
            string item = Console.ReadLine();
            if (!string.IsNullOrEmpty(item))
            {
                items.Add(item);
            }
        }

        stopwatch.Stop();

        Console.WriteLine($"\nYou listed {items.Count} items:");
        foreach (string item in items)
        {
            Console.WriteLine($"- {item}");
        }
        Console.WriteLine();
        Console.WriteLine(End_Message + "Listing Activity\n");

    }

    private string GetRandomPrompt()
    {
        int randomIndex = random.Next(prompts.Length);
        return prompts[randomIndex]; 
    }


}