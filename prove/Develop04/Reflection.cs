using System.Diagnostics;

class Reflection : Activity
{


    string[] prompts = {"Think of a time when you stood up for someone else. ",
                        "Think of a time when you did something really difficult. ",
                        "Think of a time when you helped someone in need. ",
                        "Think of a time when you did something truly selfless. "};
    string[] reflections = {
        "Why was this experience meaningful to you? ",
        "Have you ever done anything like this before? ",
        "How did you get started? ",
        "How did you feel when it was complete? ",
        "What made this time different than other times when you were not as successful? ",
        "What is your favorite thing about this experience? ",
        "What could you learn from this experience that applies to other situations? ",
        "What did you learn about yourself through this experience? ",
        "How can you keep this experience in mind in the future? "
    };

    public void Start(){

        Console.WriteLine(Start_Message,"Reflection Activity");

        Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
    
        int duration = GetTime();

        PrepTime();

        PerformReflection(duration);
    }


    private Random random = new Random();

    public void PerformReflection(int duration){


        string randomPrompt = GetRandomPrompt();

        Console.Write(randomPrompt + "Take a moment... ");
        Ani(10);
        Thread.Sleep(500);
        Console.WriteLine();

        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();


        

        while (stopwatch.Elapsed.TotalSeconds < duration)
        {
            string randomReflection = GetRandomReflection();

            Console.Write(randomReflection + "Think... ");
            Ani(15);

        }

        stopwatch.Stop();
        Console.WriteLine(End_Message + "Reflection Activity");

    }

    private string GetRandomPrompt()
    {
        int randomIndex = random.Next(prompts.Length);
        return prompts[randomIndex]; 
    }

    private string GetRandomReflection(){

        int randomIndex = random.Next(reflections.Length);
        return reflections[randomIndex];
    }


}