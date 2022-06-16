using System;
using System.Linq;
using System.Collections.Generic;

namespace MarioKartItemBox
{

    public class Program
    {
        static void rollDice(int position, int amountOfRolls)
        {
            var rand = new Random();
            for (int i = 0; i < amountOfRolls; i++)
            {
                int roll = rand.Next(0, 101);
                if (position >= 1 && position <= 6)
                {
                    if (roll > 0 && roll < 45)
                    {
                        Console.WriteLine("Congratulations! You rolled a Banana!");
                    }
                    else if (roll >= 45 && roll < 80)
                    {
                        Console.WriteLine("Congratulations! You rolled a Green Shell!");
                    }
                    else if (roll >= 00 && roll < 95)
                    {
                        Console.WriteLine("Congratulations! You rolled a Star!");
                    }
                    else if (roll >= 95 && roll < 99)
                    {
                        Console.WriteLine("Congratulations! You rolled a Golden Mushroom!");
                    }
                    else if (roll >= 99)
                    {
                        Console.WriteLine("Congratulations! You rolled a Bullet Bill!");
                    }
                }
                else if (position >= 7 && position <= 12)
                {
                    if (roll > 0 && roll < 5)
                    {
                        Console.WriteLine("Congratulations! You rolled a Banana!");
                    }
                    else if (roll >= 5 && roll < 10)
                    {
                        Console.WriteLine("Congratulations! You rolled a Green Shell!");
                    }
                    else if (roll >= 10 && roll < 35)
                    {
                        Console.WriteLine("Congratulations! You rolled a Star!");
                    }
                    else if (roll >= 35 && roll < 70)
                    {
                        Console.WriteLine("Congratulations! You rolled a Golden Mushroom!");
                    }
                    else if (roll >= 70)
                    {
                        Console.WriteLine("Congratulations! You rolled a Bullet Bill!");
                    }
                }
                else
                {
                    Console.WriteLine("This is not a position available in Mario Kart. Please input a different position that is listed!");
                }
            }
        }


        static void Main(string[] args)
        {
            string display = "----";
            int position = 0;
            bool killswitch = false;
            while (killswitch != true) // Boolean used to keep while loop active until a certain input changes it to true, therefore stopping the loop and exiting the program.
            {
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine("Welcome to the Mario Kart Item Box Simulator!");
                Console.WriteLine("You are current in place #" + display + "! What would you like to do?");
                Console.WriteLine("1) Specify which place you are in (type in 'position' or '1')");
                Console.WriteLine("2) Roll the dice (type in 'roll' or '2')");
                Console.WriteLine("3) Roll the dice multiple times (type in 'rollmultiple' or '3')");
                Console.WriteLine("4) Exit (type in 'exit' or '4')");
                string userInput = Console.ReadLine();
                if (userInput == "1" || userInput.ToLower() == "position")
                {
                    Console.WriteLine("What position are you in? Input a position from 1-12.");
                    position = Convert.ToInt32(Console.ReadLine());
                    display = Convert.ToString(position);
                    Console.WriteLine("Done! Your position is now in position #" + display + "! Press any key to continue...");
                    Console.ReadKey();
                }
                else if (userInput == "2" || userInput.ToLower() == "roll")
                {
                    rollDice(position, 1);
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }
                else if (userInput == "3" || userInput.ToLower() == "rollmultiple")
                {
                    Console.WriteLine("Please input an amount of times you want to roll!");
                    int amountofRolls = Convert.ToInt32(Console.ReadLine());
                    rollDice(position, amountofRolls);
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }
                else if (userInput == "4" || userInput.ToLower() == "exit")
                {
                    Console.WriteLine("Exiting the application. Press any key to continue...");
                    Console.ReadKey();
                    killswitch = true;
                }
                else
                {
                    Console.WriteLine("This isnt a part of the available options listed! Please input the options listed!");
                    Console.ReadKey();
                }
            }
        }
    }
}