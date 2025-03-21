using System;
using System.Runtime.CompilerServices;
using System.IO; 
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop05 World!");


            int _totalPoints = 0;

            int menu = 0;

            List<Goal> goal_list = new List<Goal>();

        while(menu != 6){

            Console.WriteLine($"\n--- Menu Options ---\nTotal Points: {_totalPoints}\n\n1. Create Goal\n 2. List Goals\n3. Save\n4. Load\n5. Record a Goal\n6. Quit");


            Thread animationThread = new Thread(Animate);
            animationThread.Start();

            menu = int.Parse(Console.ReadLine());

            animationThread.Interrupt();


            

            if (menu == 1){
                
                Console.WriteLine("What kind of goal would you like to make?\n1. Simple\n2. Checklist\n 3. Eternal");

                int goal = int.Parse(Console.ReadLine());

                Console.WriteLine("What is the name of the goal? ");

                string name = Console.ReadLine();

                Console.WriteLine("What would you like to put for a description of this goal?");

                string description = Console.ReadLine();

                Console.WriteLine("How many points would you like this goal to be? ");

                int point_value = int.Parse(Console.ReadLine());

                if (goal == 1){
                    Simple simple = new Simple(name, point_value, description);

                    goal_list.Add(simple);
                }
                else if (goal == 2){

                    Console.WriteLine("How many times do you want to complete this task before checking it off? ");
                    int total_completions = int.Parse(Console.ReadLine());

                    int current_completions = 0;

                    Checklist checklist = new Checklist(name, point_value, description, current_completions, total_completions);

                    goal_list.Add(checklist);
                    
                }
                else if (goal == 3){
                    Eternal eternal = new Eternal(name, point_value, description);

                    goal_list.Add(eternal);
                }
            }
            if (menu == 2){

                Console.WriteLine("-- Current Goals --");

                int goal_number = 1;

                foreach (var goal in goal_list){
                    Console.WriteLine();
                    Console.Write($"{goal_number}. ");
                    goal.Display();
                    goal_number += 1;
                }
            }

            if (menu == 3){

                List<string> ToBeSaved = new List<string>();


                foreach(Goal e in goal_list){

                    string save = e.Save();

                    ToBeSaved.Add(save);
                }

                ToBeSaved.Add($"Points~{_totalPoints}~This will be the point total with this save.~1");

            
                string[] stringsarray = ToBeSaved.ToArray();

                Console.WriteLine("What would you like to save your file as? (Include end tags such as '.txt')");

                string fileName = Console.ReadLine();

                System.IO.File.WriteAllLines(fileName, stringsarray);

                
            }
            if (menu == 4){

                _totalPoints = Load(goal_list);
                
            }
            if (menu == 5){

                Console.WriteLine("-- Current Goals --");

                int goal_number = 1;

                foreach (var goal in goal_list){
                    Console.WriteLine();
                    Console.Write($"{goal_number}. ");
                    goal.Display();
                    goal_number += 1;
                }

                Console.WriteLine("Which goal would you like to record for? ");

                int answer = int.Parse(Console.ReadLine());

                int position = answer-1;

                int newPoints = goal_list.ElementAt(position).RecordEvent();

                _totalPoints += newPoints;

                Console.WriteLine($"\n~~~~~~~~~~~\nCongratulations! You earned {newPoints} points!\nYour total is now {_totalPoints}! Keep on going!\n~~~~~~~~~~~");


            }

        }
    }

        public static int Load(List<Goal> goal_list){

            Console.WriteLine("What file would you like to load? ");
            string load_goals = Console.ReadLine();

            
            string[] loaded_goals = System.IO.File.ReadAllLines(load_goals);

            int point_total = 0;

            foreach(string e in loaded_goals){
                

                string[] load_split = e.Split("~");

                string type = load_split[0];

                string name = load_split[1];

                string description = load_split[2];

                string points_earned = load_split[3];
                int points = int.Parse(points_earned);

                if (type == "Simple"){

                string _isCompleted = load_split[4];

                Simple simple1 = new Simple(name, points, description);

                goal_list.Add(simple1);
                }
                else if (type == "Checklist")
                {
                    int currentCompletions = int.Parse(load_split[4]);
                    int totalCompletions = int.Parse(load_split[5]);
                    Checklist checklist1 = new Checklist(name, points, description, currentCompletions, totalCompletions);
                    goal_list.Add(checklist1);
                }
                else if (type == "Eternal")
                {
                    Eternal eternal1 = new Eternal(name, points, description);
                    goal_list.Add(eternal1);
                }
                else if (type == "Points"){

                    point_total = int.Parse(load_split[1]);

                }

                

            }
            return point_total;

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