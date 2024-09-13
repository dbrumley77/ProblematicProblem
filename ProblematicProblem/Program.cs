using System;
using System.Collections.Generic;
using System.Threading;

namespace ProblematicProblem;

    class Program
    {
       
    static void Main(string[] args)
    {
        
        bool cont = true;
        List<string> activities = new List<string>() { "Movies", "Paintball", "Bowling", "Lazer Tag", "LAN Party", "Hiking", "Axe Throwing", "Wine Tasting" };
        
        Console.Write("Hello, Welcome to the random activity generator! \nWould you like to generate a random activity? true/false: ");
        bool.TryParse(Console.ReadLine(), out cont);
        Console.WriteLine();
        Console.Write("We are going to need your information first! What is your name? ");
        string userName = Console.ReadLine();
        Console.WriteLine();
        Console.Write("What is your age? ");
        int.TryParse(Console.ReadLine(), out int userAge);
        Console.WriteLine();
        Console.Write("Would you like to see the current list of activities? true/false: ");
        bool.TryParse(Console.ReadLine(), out bool seeList);
        Console.WriteLine();
        if (seeList)
        {
            Console.WriteLine();
            foreach (string activity in activities)
            {
                Console.Write($"{activity}, ");
                
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Would you like to add any activities before we generate one? true/false: ");
            bool.TryParse(Console.ReadLine(), out bool addToList);
            Console.WriteLine();

            while (addToList)
            {
                Console.Write("What would you like to add? ");
                string userAddition = Console.ReadLine();
                activities.Add(userAddition);
                Console.Write("Updated List: ");
                foreach (string activity in activities)
                {
                    
                    Console.Write($"{activity}, ");
                    Thread.Sleep(250);
                }
                Console.WriteLine();
                Console.WriteLine();
                Console.Write("Would you like to add more? true/false: ");
                bool.TryParse(Console.ReadLine(), out addToList);
                Console.WriteLine();

            }
        }

        while (cont)
        {
            Console.WriteLine();
            Console.Write("Connecting to the database");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(". ");
                Thread.Sleep(500);
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Choosing your random activity");
            for (int i = 0; i < 9; i++)
            {
                Console.Write(". ");
                Thread.Sleep(500);
            }
            Console.WriteLine();
            Console.WriteLine();
            Random rng = new Random();
            int randomNumber = rng.Next(activities.Count);
            string randomActivity = activities[randomNumber];

            

            if (userAge < 21 && randomActivity == "Wine Tasting")
            {
                Console.WriteLine($"Oh no! Looks like you are too young to do {randomActivity}");
                Console.WriteLine("Let's find another activity");
                activities.Remove(randomActivity);
                randomNumber = rng.Next(activities.Count);
                randomActivity = activities[randomNumber];
                Console.WriteLine();

            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"Ah got it! {userName}, your random activity is: {randomActivity}! do you want to choose another activity? true/false: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            
            cont = bool.Parse(Console.ReadLine());
            
        }
        }
    }
