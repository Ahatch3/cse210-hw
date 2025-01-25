using System;

class Program
{
    static void Main(string[] args)
    {
        Random rng = new Random();

        int m_number = rng.Next(101);

        string response;

        Console.WriteLine("What is the magic number? ");

        response = Console.ReadLine();

        int m_response = int.Parse(response);

        if (m_response == m_number)
        {
            Console.WriteLine("Congrats you got it!");
        }
        else if (m_response < m_number)
        {
            Console.WriteLine("You're a little low... Guess higher!");
        }
        else
        {
            Console.WriteLine("You're a little high... Guess lower! ");
        }

    

        while (m_response != m_number)
        {

            Console.WriteLine("What is the magic number? ");

            response = Console.ReadLine();

            m_response = int.Parse(response);

            

            if (m_response == m_number)
            {
                Console.WriteLine("Congrats you got it!");
            }
            else if (m_response < m_number)
            {
                Console.WriteLine("You're a little low... Guess higher!");
            }
            else
            {
                Console.WriteLine("You're a little high... Guess lower! ");
            }
        }




    }
}