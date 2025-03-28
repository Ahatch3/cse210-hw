using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation2 World!");

        int menu = 0;

        string address1 = "123 Elm Street";

        string city1 = "Rexburg";

        string state1 = "Idaho";

        string country1 = "US";

        string customer1 = "Prince of Porcelain Palace";

        string address2 = "789 Granville Street";

        string city2 = "Vancouver";

        string state2 = "BC";

        string country2 = "Canada";

        string customer2 = "The Game, Food, Trampoline, Couch Place";


        Product[] products = {
        new Product("Laptop", 1001, 1200, 1),
        new Product("Mouse", 1002, 25, 2),
        new Product("Keyboard", 1003, 50, 1),
        new Product("Monitor", 1004, 300, 1),
        new Product("Headphones", 1005, 80, 1),
        new Product("Webcam", 1006, 60, 1),
        new Product("Printer", 1007, 150, 1),
        new Product("Scanner", 1008, 100, 1),
        new Product("External Hard Drive", 1009, 120, 1),
        new Product("USB Flash Drive", 1010, 15, 3)
        };

        Product[] gameFoodTrampolineCouchProducts = {
        new Product("Giant Jenga Set", 2001, 35, 1),
        new Product("Deluxe Trampoline Socks", 2002, 12, 10),
        new Product("Loaded Nachos Platter", 2003, 22, 1),
        new Product("Oversized Beanbag Chair", 2004, 60, 2),
        new Product("Glow-in-the-Dark Dodgeballs", 2005, 25, 6),
        new Product("Pizza Variety Pack", 2006, 30, 1),
        new Product("Foam Pit Landing Pad", 2007, 80, 1),
        new Product("Board Game Bundle", 2008, 45, 1),
        new Product("Soda Fountain Refills", 2009, 8, 20),
        new Product("Plush Throw Blanket", 2010, 20, 5)
        };

        Random random = new Random();



        // FOR THE MENU
        // Normally I would have a whole list of things that let you say what you would like to get, assign names and even allow you to access orders and customers that you've already made, but from the instructions I assumed that this was supposed to be a standalone running program that runs without input, so I hard coded in the data instead. Just wanted to put this here now so you know it was an intentional decision based on how the assignment was worded. I could have put in more accessibility, but I figured this also helps with ease of grading as you can just see each of the orders with a press of a button.


        while (menu != 3){

            Console.WriteLine("--Order List--\n\nWhich order would you like to view today? \n1. Prince of Porcelain Palace\n2. The Game, Food, Trampoline, Couch Place\n3. Quit");

            menu = int.Parse(Console.ReadLine());

            if (menu == 1){

                Address address = new Address(address1, city1, state1, country1);

                Customer popp = new Customer(customer1, address);

                Order order = new Order(popp);

                int randomIndex = random.Next(products.Length);
                order.AddProduct(products[randomIndex]);
                int randomIndex2 = random.Next(products.Length);
                order.AddProduct(products[randomIndex2]);
                int randomIndex3 = random.Next(products.Length);
                order.AddProduct(products[randomIndex3]);

                order.Display();
            }

        
            
            if (menu == 2){

                Address address = new Address(address2, city2, state2, country2);

                Customer gftcp = new Customer(customer2, address);

                Order order = new Order(gftcp);

                int randomIndex = random.Next(gameFoodTrampolineCouchProducts.Length);
                order.AddProduct(gameFoodTrampolineCouchProducts[randomIndex]);
                int randomIndex2 = random.Next(gameFoodTrampolineCouchProducts.Length);
                order.AddProduct(gameFoodTrampolineCouchProducts[randomIndex2]);
                int randomIndex3 = random.Next(gameFoodTrampolineCouchProducts.Length);
                order.AddProduct(gameFoodTrampolineCouchProducts[randomIndex3]);

                order.Display();

            }
        }

    }
}