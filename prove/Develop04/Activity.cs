

class Activity
{

    protected static string Start_Message = "Welcome to the ";

    protected static string End_Message = "Thanks for coming to the ";


    protected static int GetTime(){

        Console.WriteLine("How many seconds would you like to participate in this activity? ");

        int time = int.Parse(Console.ReadLine());

        return time;

    }

    protected static void PrepTime(){

        Console.WriteLine("Your activity will begin in a few moments, prepare for a great mindfulness activity! ");

        Thread.Sleep(5000);

        Console.WriteLine("Begin now.");
    }

    protected static void Ani(int length){

        for(int i = length; i>0; i--){
            
            Console.Write(i);

            Thread.Sleep(1000);

            if(i > 9){
                Console.Write("\b\b  \b\b");
            }
            else{
                Console.Write("\b \b");
            }

            

        }
        Console.WriteLine();
    }







}